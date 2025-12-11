using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH5 {
    public partial class Bai10 : Form {
        DashStyle dashStyle;
        DashCap cap;
        LineJoin lineJoin;
        float[] Pattern;
        int DashWidth;

        Point Start;
        Point End;

        bool flag;

        List<List<Point>> lineList = new List<List<Point>>();
        Pen pen;

        public Bai10() {
            InitializeComponent();

            lDCustom.Visible = false;
            tbDCustom.Visible = false;
        }

        private void Bai10_MouseDown(object sender, MouseEventArgs e) {
            Start = e.Location;
            flag = true;

            if(pen != null)
                pen.Dispose();

            pen = new Pen(Color.Red, DashWidth);
            pen.DashStyle = dashStyle;
            pen.DashCap = cap;
            pen.LineJoin = lineJoin;
            pen.StartCap = getLineCap(cbStartCap);
            pen.EndCap = getLineCap(cbEndCap);

            if (dashStyle == DashStyle.Custom && Pattern != null && Pattern.Length > 0) {
                try {
                    pen.DashPattern = Pattern;
                }
                catch (Exception ex) {
                    MessageBox.Show("Pattern custom lỗi: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Bai10_MouseMove(object sender, MouseEventArgs e) {
            if (flag) { 
                End = e.Location;

                this.Invalidate();
            }
        }

        private void Bai10_MouseUp(object sender, MouseEventArgs e) {
            End = e.Location;

            if(pen != null && Start != End) {
                if(lineList.Count == 0) {
                    lineList.Add(new List<Point>());
                    lineList[0].Add(Start);
                    lineList[0].Add(End);
                } else {
                    if (!JoinNearedLine(Start, End)) { 
                        lineList.Add(new List<Point>());
                        lineList[lineList.Count - 1].Add(Start);
                        lineList[lineList.Count - 1].Add(End);
                    }
                }
            }

            flag = false;

            this.Invalidate();
        }

        private void cbWidth_TextChanged(object sender, EventArgs e) {
            Changed_Style();

            if (string.IsNullOrEmpty(cbWidth.Text)) {
                DashWidth = 0;
                return;
            }

            if(!int.TryParse(cbWidth.Text, out DashWidth)) {
                MessageBox.Show("Width phải là số nguyên dương.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbDashStyle_TextChanged(object sender, EventArgs e) {
            Changed_Style();

            lDCustom.Visible = false;
            tbDCustom.Visible = false;

            switch (cbDashStyle.Text) {
                case "Dash":
                    dashStyle = DashStyle.Dash;
                    break;
                case "DashDot":
                    dashStyle = DashStyle.DashDot;
                    break;
                case "DashDotDot":
                    dashStyle = DashStyle.DashDotDot;
                    break;
                case "Dot":
                    dashStyle = DashStyle.Dot;
                    break;
                case "Solid":
                    dashStyle = DashStyle.Solid;
                    break;
                case "Custom":
                    dashStyle = DashStyle.Custom;

                    lDCustom.Visible = true;
                    tbDCustom.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void tbDCustom_TextChanged(object sender, EventArgs e) {
            Changed_Style();

            string str = tbDCustom.Text;

            if (string.IsNullOrEmpty(str)) {
                Pattern = null;
                return;
            }

            if (str.StartsWith("Ex:")) {
                str = str.Substring(3).Trim();
            }

            string[] tmp = str.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries);
            List<float> list = new List<float>();
            float p;

            foreach(string s in tmp) {
                if (float.TryParse(s.Trim(), out p)) {
                    if (p <= 0f) {
                        MessageBox.Show("Mỗi giá trị trong chuỗi custom phải > 0.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Pattern = null;
                        return;
                    }
                    list.Add(p);
                } else {
                    MessageBox.Show("Vui lòng nhập đúng định dạng.\n\tVD: 5,3,1,3,...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Pattern = null;
                    return;
                }
            }

            if (list.Count == 0) {
                Pattern = null;
                return;
            }

            Pattern = list.ToArray();
        }

        private void cbLineJoin_TextChanged(object sender, EventArgs e) {
            Changed_Style();   
            
            switch (cbLineJoin.Text) {
                case "Miter":
                    lineJoin = LineJoin.Miter;
                    break;
                case "Bevel":
                    lineJoin = LineJoin.Bevel;
                    break;
                case "Round":
                    lineJoin = LineJoin.Round;
                    break;
                case "MiterClipped":
                    lineJoin = LineJoin.MiterClipped;
                    break;
                default:
                    break;
            }
        }

        private void cbDashCap_TextChanged(object sender, EventArgs e) {
            Changed_Style();

            switch (cbDashCap.Text) {
                case "Flat":
                    cap = DashCap.Flat;
                    break;
                case "Triangle":
                    cap = DashCap.Triangle;
                    break;
                case "Round":
                    cap = DashCap.Round;
                    break;
                default:
                    break;
            }
        }

        private void StartEndCap_TextChange(object sender, EventArgs e) {
            Changed_Style();
        }

        private LineCap getLineCap(object sender){
            ComboBox type = (ComboBox)sender;

            switch (type.Text) {
                case "Flat":
                    return LineCap.Flat;
                case "Square":
                    return LineCap.Square;
                case "Triangle":
                    return LineCap.Triangle;
                case "Round":
                    return LineCap.Round;
                case "ArrowAnchor":
                    return LineCap.ArrowAnchor;
                case "SquareAnchor":
                    return LineCap.SquareAnchor;
                case "RoundAnchor":
                    return LineCap.RoundAnchor;
                case "DiamondAnchor":
                    return LineCap.DiamondAnchor;
                case "Custom":
                    MessageBox.Show("Chưa cài đặt.\nDùng No Anchor.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    type.Text = "NoAnchor";
                    return LineCap.NoAnchor;
                default:
                    return LineCap.NoAnchor;
            }
        }

        private void Changed_Style() {
            lineList.Clear();

            this.Invalidate();
        }

        private void Bai10_Paint(object sender, PaintEventArgs e) {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            if (DashWidth <= 0 || pen == null)
                return;

            DrawLine(graphics);

            if(flag)
                graphics.DrawLine(pen, Start, End);
        }

        private void DrawLine(Graphics g) {
            if (lineList == null || lineList.Count == 0)
                return;

            foreach(List<Point> list in lineList){
                if (list.Count == 0)
                    continue;

                g.DrawLines(pen, list.ToArray());
            }
        }

        private double Distance(Point a, Point b) {
            int dx = a.X - b.X;
            int dy = a.Y - b.Y;

            return Math.Sqrt(dx * dx + dy * dy);
        }

        private bool JoinNearedLine(Point Start, Point End) {
            double Min = 15.0;

            foreach (List<Point> list in lineList) { 
                Point last = list[list.Count - 1];

                if(Distance(Start, last) <= Min) {
                    list.Add(Start);
                    list.Add(End);
                    return true;
                }
            }

            return false;
        }
    }
}
