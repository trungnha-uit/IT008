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
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void bBai04_Click(object sender, EventArgs e) {
            Bai04 fBai04 = new Bai04();
            fBai04.Show();
        }

        private void bBai06_Click(object sender, EventArgs e) {
            Bai06 fBai06 = new Bai06();
            fBai06.Show();
        }

        private void bBai08_Click(object sender, EventArgs e) {
            Bai08 fBai08 = new Bai08();
            fBai08.Show();
        }

        private void bBai09_Click(object sender, EventArgs e) {
            Bai09 fBai09 = new Bai09();
            fBai09.Show();
        }

        private void bBai10_Click(object sender, EventArgs e) {
            Bai10 fBai10 = new Bai10();
            fBai10.Show();
        }

        private void bBai11_Click(object sender, EventArgs e) {
            Bai11 fBai11 = new Bai11();
            fBai11.Show();
        }
    }
}
