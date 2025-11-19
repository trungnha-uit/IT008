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
using static System.Net.Mime.MediaTypeNames;

namespace BTTH3 {
    public partial class Bai02 : Form {
        public Bai02() {
            InitializeComponent();

        }

        Random rand = new Random();

        protected override void OnPaint(PaintEventArgs e) {
            Graphics g = e.Graphics;

            string str = "Paint Event";
            Font f = new Font("Time New Roman", 16, FontStyle.Bold);
            SizeF textSize = g.MeasureString(str, f);
            int MaxX = this.Width - (int)textSize.Width;
            int MaxY = this.Height - (int)textSize.Height;

            Point p = new Point(rand.Next(MaxX), rand.Next(MaxY));

            Brush brush = new SolidBrush(randColor());

            g.DrawString(str, f, brush, p);
        }

        private Color randColor() {
            return Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
        }

        private void Timer_Tick(object sender, EventArgs e) {
            this.Invalidate();
        }
    }
}
