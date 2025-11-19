using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH3 {
    public partial class Bai03 : Form {
        public Bai03() {
            InitializeComponent();
        }

        private void bChangeColor_Click(object sender, EventArgs e) {
            Random rand = new Random();

            this.BackColor = Color.FromArgb(
                    rand.Next(255),
                    rand.Next(255),
                    rand.Next(255)
            );
        }
    }
}
