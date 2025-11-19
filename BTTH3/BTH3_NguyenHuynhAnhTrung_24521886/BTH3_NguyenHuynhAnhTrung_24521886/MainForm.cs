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
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void bBai03_Click(object sender, EventArgs e) {
            Bai03 fBai03 = new Bai03();
            fBai03.Show();
        }

        private void bBai04_Click(object sender, EventArgs e) {
            Bai04 fBai04 = new Bai04();
            fBai04.Show();
        }

        private void bBai05_Click(object sender, EventArgs e) {
            Bai05 fBai05 = new Bai05();
            fBai05.Show();
        }

        private void button1_Click(object sender, EventArgs e) {
            Bai06 fBai06 = new Bai06();
            fBai06.Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            Bai07 fBai07 = new Bai07();
            fBai07.Show();
        }

        private void bBai08_Click(object sender, EventArgs e) {
            Bai08 fBai08 = new Bai08();
            fBai08.Show();
        }

        private void bBai09_Click(object sender, EventArgs e) {
            Bai09 fBai09 = new Bai09();
            fBai09.Show();
        }

        private void bBai01_Click(object sender, EventArgs e) {
            Bai01 fbai01 = new Bai01();
            fbai01.Show();
        }

        private void bBai02_Click(object sender, EventArgs e) {
            Bai02 fbai02 = new Bai02();
            fbai02.Show();
        }
    }
}
