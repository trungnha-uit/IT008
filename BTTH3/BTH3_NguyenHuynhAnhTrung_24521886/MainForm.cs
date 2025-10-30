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
    }
}
