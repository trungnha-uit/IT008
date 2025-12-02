using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH4 {
    public partial class Bai05 : Form {
        public Bai05() {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e) {
            Bai05_1 fBai05_1 = new Bai05_1(dataGridView1);
            fBai05_1.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e) {
            Bai05_1 fBai05_1 = new Bai05_1(dataGridView1);
            fBai05_1.Show();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(toolStripTextBox1.Text)) {
                string find = toolStripTextBox1.Text.Trim().ToLower();

                foreach (DataGridViewRow item in dataGridView1.Rows) {
                    if (!item.IsNewRow) {
                        string ten = item.Cells["TenSV"].Value?.ToString().Trim().ToLower();

                        item.Visible = ten.Contains(find);
                    }
                }
            } else {
                foreach (DataGridViewRow item in dataGridView1.Rows) {
                    item.Visible = true;
                }
            }
        }

        private void Bai05_FormClosing(object sender, FormClosingEventArgs e) {
            DialogResult r = MessageBox.Show("Đóng form?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (r == DialogResult.Cancel) {
                e.Cancel = true;
            }
        }
    }
}
