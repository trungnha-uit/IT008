using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH5 {
    public partial class Bai09 : Form {
        private Point startPoint;
        private Point endPoint;
        private bool flag;

        public Bai09() {
            InitializeComponent();
        }

        private void Bai09_MouseDown(object sender, MouseEventArgs e) {
            startPoint = e.Location;
            flag = true;
        }

        private void Bai09_MouseUp(object sender, MouseEventArgs e) {
            endPoint = e.Location;
            flag = false;
            this.Invalidate();
        }

        private void Bai09_Paint(object sender, PaintEventArgs e) {
            groupBox1.Visible = false;
            string choice = comboBox1.Text;
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int x = Math.Min(startPoint.X, endPoint.X);
            int y = Math.Min(startPoint.Y, endPoint.Y);

            int width = Math.Abs(endPoint.X - startPoint.X);
            int height = Math.Abs(endPoint.Y - startPoint.Y);
            int d = Math.Max(width, height);

            int sweepAngle;
            int startAngle;
            if (!int.TryParse(tbSweepAngle.Text, out sweepAngle)) {
                MessageBox.Show("Nhập số nguyên Sweep Angle.", "ERROR");
                tbSweepAngle.Text = "0";
                return;
            }
            if (!int.TryParse(tbStartAngle.Text, out startAngle)) {
                MessageBox.Show("Nhập số nguyên Start Angle.", "ERROR");
                tbStartAngle.Text = "0";
                return;
            }

            switch (choice) {
                case "Circle":
                    g.DrawEllipse(Pens.Black, x, y, d, d);
                    break;
                case "Filled Circle":
                    g.FillEllipse(Brushes.Red, x, y, d, d);
                    break;
                case "Square":
                    g.DrawRectangle(Pens.Black, x, y, d, d);
                    break;
                case "Filled Square":
                    g.FillRectangle(Brushes.Red, x, y, d, d);
                    break;
                case "Ellipse":
                    g.DrawEllipse(Pens.Black, x, y, width, height);
                    break;
                case "Filled Ellipse":
                    g.FillEllipse(Brushes.Red, x, y, width, height);
                    break;
                case "Rectangle":
                    g.DrawRectangle(Pens.Black, x, y, width, height);
                    break;
                case "Filled Rectangle":
                    g.FillRectangle(Brushes.Red, x, y, width, height);
                    break;
                case "Pie":
                    groupBox1.Visible = true;

                    if (width == 0 || height == 0 || sweepAngle == 0)
                        break;
                    g.DrawPie(Pens.Black, x, y, width, height, startAngle, sweepAngle);
                    break;
                case "Filled Pie":
                    groupBox1.Visible = true;

                    if (width == 0 || height == 0 || sweepAngle == 0)
                        break;
                    g.FillPie(Brushes.Red, x, y, width, height, startAngle, sweepAngle);
                    break;
            }
        }

        private void Bai09_MouseMove(object sender, MouseEventArgs e) {
            if (flag) {
                endPoint = e.Location;

                this.Invalidate();
            }
        }
    }
}
