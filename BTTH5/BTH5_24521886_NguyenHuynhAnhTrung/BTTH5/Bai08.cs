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
    public partial class Bai08 : Form {
        DateTime now;
        public Bai08() {
            InitializeComponent();
            
            now = DateTime.Now;
        }

        private void Bai08_Paint(object sender, PaintEventArgs e) {
            DrawClockFace(e.Graphics);

            DrawSecond(e.Graphics);
            DrawMinute(e.Graphics);
            DrawHour(e.Graphics);
        }

        private void DrawClockFace(Graphics g) {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            int minuteSize = 8;
            int radius = Math.Min(centerX, centerY) - minuteSize - 10;

            for (int i = 0; i < 60; i++) {
                double theta = -i * (360 / 60) * Math.PI / 180;

                double x = centerX + radius * Math.Cos(theta) - minuteSize / 2f;
                double y = centerY + radius * Math.Sin(theta) - minuteSize / 2f;

                g.FillEllipse(Brushes.White, (float)x, (float)y, minuteSize, minuteSize);
            }

            int hourSize = 25;

            for (int i = 0; i < 12; ++i) {
                double theta = i * (360 / 12) * Math.PI / 180;

                double x = centerX + radius * Math.Cos(theta) - hourSize / 2f;
                double y = centerY + radius * Math.Sin(theta) - hourSize / 2f;

                g.FillEllipse(Brushes.White, (float)x, (float)y, hourSize, hourSize);
            }
        }

        private void DrawSecond(Graphics g) {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int second = now.Second;

            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;
            Point center = new Point(centerX, centerY);

            double theta = (second * (360 / 60) - 90) * Math.PI / 180;

            double x = centerX + 175 * Math.Cos(theta);
            double y = centerY + 175 * Math.Sin(theta);
            Point head = new Point((int)x, (int)y);

            g.DrawLine(Pens.White, center, head);
        }

        private void DrawMinute(Graphics g) {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int minute = now.Minute;

            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            double theta = (minute * (360 / 60) - 90) * Math.PI / 180;

            double x = centerX + 10 * Math.Cos(theta + Math.PI / 2);
            double y = centerY + 10 * Math.Sin(theta + Math.PI / 2);
            Point left = new Point((int)x, (int)y);

            x = centerX + 10 * Math.Cos(theta - Math.PI / 2);
            y = centerY + 10 * Math.Sin(theta - Math.PI / 2);
            Point right = new Point((int)x, (int)y);

            x = centerX + 32 * Math.Cos(theta + Math.PI);
            y = centerY + 32 * Math.Sin(theta + Math.PI);
            Point end = new Point((int)x, (int)y);

            x = centerX + 175 * Math.Cos(theta);
            y = centerY + 175 * Math.Sin(theta);
            Point head = new Point((int)x, (int)y);

            Point[] point = new Point[] {
                head, left, end, right
            };

            g.DrawPolygon(Pens.White, point);
        }

        private void DrawHour(Graphics g) {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int hour = now.Hour;

            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            double theta = (hour * (360 / 12) - 90) * Math.PI / 180;

            double x = centerX + 20 * Math.Cos(theta + Math.PI / 2);
            double y = centerY + 20 * Math.Sin(theta + Math.PI / 2);
            Point left = new Point((int)x, (int)y);

            x = centerX + 20 * Math.Cos(theta - Math.PI / 2);
            y = centerY + 20 * Math.Sin(theta - Math.PI / 2);
            Point right = new Point((int)x, (int)y);

            x = centerX + 12 * Math.Cos(theta + Math.PI);
            y = centerY + 12 * Math.Sin(theta + Math.PI);
            Point end = new Point((int)x, (int)y);

            x = centerX + 125 * Math.Cos(theta);
            y = centerY + 125 * Math.Sin(theta);
            Point head = new Point((int)x, (int)y);

            Point[] point = new Point[] {
                head, left, end, right
            };

            g.DrawPolygon(Pens.White, point);
        }

        private void timer1_Tick(object sender, EventArgs e) {
            now = DateTime.Now;

            this.Invalidate();
        }
    }
}
