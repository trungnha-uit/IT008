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
    public partial class Bai11 : Form {
        Color color;
        int PenWidth = 1;
        Brush brush;
        string shapes;
        bool flag;

        Bitmap image;
        Graphics g;

        Point Start;
        Point End;

        public Bai11() {
            InitializeComponent();

            color = Color.Black;
            image = new Bitmap(ClientSize.Width, ClientSize.Height);
            g = Graphics.FromImage(image);
            g.SmoothingMode = SmoothingMode.AntiAlias;
        }

        private void bPenColor_Click(object sender, EventArgs e) {
            DialogResult r = colorDialog1.ShowDialog();

            if (r == DialogResult.OK) {
                color = colorDialog1.Color;
            }
        }

        private void rbSolidBrush_CheckedChanged(object sender, EventArgs e) {
            if(brush != null) 
                brush.Dispose();
            if (rbSolidBrush.Checked)
                brush = new SolidBrush(Color.Green);
        }

        private void rbHatchBrush_CheckedChanged(object sender, EventArgs e) {
            if(brush != null)
                brush.Dispose();
            if (rbHatchBrush.Checked)
                brush = new HatchBrush(HatchStyle.Horizontal, Color.Blue, Color.Green);
        }

        private void rbTextureBrush_CheckedChanged(object sender, EventArgs e) {
            if (brush != null)
                brush.Dispose();

            Image img;

            if (rbTextureBrush.Checked) {
                DialogResult r = MessageBox.Show("Sử dụng ảnh mặc định?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.No) { 
                    openFileDialog1.Filter = "Bitmap (*.bmp)|*.bmp|PNG (*.png)|*.png";
                    DialogResult opf = openFileDialog1.ShowDialog();
                    if (opf == DialogResult.OK) {
                        img = Image.FromFile(openFileDialog1.FileName);
                    } else {
                        img = Properties.Resources.flower;
                    }
                } else {
                    img = Properties.Resources.flower;
                }

                brush = new TextureBrush(img);
            }
                
        }

        private void rbLinearGradientBrush_CheckedChanged(object sender, EventArgs e) {
            if(brush != null)
                brush.Dispose();
        }

        private void tbWidthPen_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(tbWidthPen.Text)) {
                PenWidth = 0;
                return;
            }

            if (!int.TryParse(tbWidthPen.Text, out PenWidth) || PenWidth < 0) {
                MessageBox.Show("Pen Width phải là số nguyên lớn hơn 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbWidthPen.Text = "1";
            }
        }

        private void Disable_Brushes() {
            rbSolidBrush.Checked = false;
            rbLinearGradientBrush.Checked = false;
            rbTextureBrush.Checked = false;
            rbHatchBrush.Checked = false;
        }

        private void rbLine_CheckedChanged(object sender, EventArgs e) {
            if (rbLine.Checked) {
                shapes = "Line";
                Disable_Brushes();
                gbBrushes.Enabled = false;
            } else {
                rbSolidBrush.Checked = true;
                gbBrushes.Enabled = true;
            }
        }

        private void rbRectangle_CheckedChanged(object sender, EventArgs e) {
            if (rbRectangle.Checked)
                shapes = "Rectangle";
        }

        private void rbEllipse_CheckedChanged(object sender, EventArgs e) {
            if (rbEllipse.Checked)
                shapes = "Ellipse";
        }

        private void Bai11_MouseDown(object sender, MouseEventArgs e) {
            Start = e.Location;
            flag = true;
        }

        private void Bai11_MouseMove(object sender, MouseEventArgs e) {
            if (flag) {
                End = e.Location;

                this.Invalidate();
            }
        }

        private void Bai11_MouseUp(object sender, MouseEventArgs e) {
            if (!flag)
                return;

            End = e.Location;
            flag = false;

            if (shapes == "Line") {
                if (PenWidth == 0)
                    return;

                g.DrawLine(new Pen(color, PenWidth), Start, End);
            } else {
                Rectangle rect = Create_Rect();

                if (rbLinearGradientBrush.Checked) {
                    if (rect.Width > 0 && rect.Height > 0)
                        brush = new LinearGradientBrush(rect, Color.Red, Color.Green, LinearGradientMode.Vertical);
                    else
                        return;
                }

                if (shapes == "Rectangle")
                    g.FillRectangle(brush, rect);
                else
                    g.FillEllipse(brush, rect);
            }

            this.Invalidate();
        }

        private Rectangle Create_Rect() {
            int x = Math.Min(Start.X, End.X);
            int y = Math.Min(Start.Y, End.Y);

            int width = Math.Abs(Start.X - End.X);
            int height = Math.Abs(Start.Y - End.Y);

            return new Rectangle(x, y, width, height);
        }

        private void Bai11_Paint(object sender, PaintEventArgs e) {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            graphics.DrawImage(image, 0, 0);

            if (!flag)
                return;

            if(shapes == "Line") {
                if (PenWidth == 0)
                    return;

                graphics.DrawLine(new Pen(color, PenWidth), Start, End);
            } else {
                Rectangle rect = Create_Rect();

                if (rbLinearGradientBrush.Checked) {
                    if (rect.Width > 0 && rect.Height > 0)
                        brush = new LinearGradientBrush(rect, Color.Red, Color.Green, LinearGradientMode.Vertical);
                    else
                        return;
                }

                if (shapes == "Rectangle")
                    graphics.FillRectangle(brush, rect);
                else
                    graphics.FillEllipse(brush, rect);
            }
        }

        private void Bai11_Resize(object sender, EventArgs e) {
            if (ClientSize.Width <= 0 || ClientSize.Height <= 0 || image == null || g == null)
                return;

            Bitmap img = new Bitmap(ClientSize.Width, ClientSize.Height);
            Graphics gNew = Graphics.FromImage(img);
            gNew.SmoothingMode = SmoothingMode.AntiAlias;
            gNew.DrawImage(image, 0, 0);

            image.Dispose();
            image = img;

            g.Dispose();
            g = gNew;

            this.Invalidate();
        }
    }
}
