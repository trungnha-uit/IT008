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
    public partial class Bai01 : Form {
        
        public Bai01() {
            InitializeComponent();
            lbEventLog.Items.Add("Ngày " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + $"\t{this.Text}: được khởi tạo.");
        }

        private void bExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Bai01_Load(object sender, EventArgs e) {
            lbEventLog.Items.Add("Ngày " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + $"\t{this.Text}: bắt đầu tải các điều khiển.");
        }

        private void Bai01_Activated(object sender, EventArgs e) {
            lbEventLog.Items.Add("Ngày " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + $"\t{this.Text}: được kích hoạt (focus).");
        }

        private void Bai01_Shown(object sender, EventArgs e) {
            lbEventLog.Items.Add("Ngày " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + $"\t{this.Text}: được hiển thị.");
        }

        private void Bai01_Click(object sender, EventArgs e) {
            lbEventLog.Items.Add("Ngày " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + $"\t{this.Text}: được nhấp vào.");
        }

        private void Bai01_Resize(object sender, EventArgs e) {
            lbEventLog.Items.Add("Ngày " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + $"\t{this.Text}: được thay đổi kích thước.");
        }

        private void Bai01_Move(object sender, EventArgs e) {
            lbEventLog.Items.Add("Ngày " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + $"\t{this.Text}: được di chuyển.");
        }

        private void Bai01_Deactivate(object sender, EventArgs e) {
            lbEventLog.Items.Add("Ngày " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + $"\t{this.Text}: bị mất kích hoạt (lost focus).");
        }

        private void Bai01_FormClosing(object sender, FormClosingEventArgs e) {
            lbEventLog.Items.Add("Ngày " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + $"\t{this.Text}: đang đóng.");

            if (MessageBox.Show("Thoát?", "", MessageBoxButtons.YesNo) == DialogResult.No) {
                e.Cancel = true;
            }

            lbEventLog.Items.Add("Ngày " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + $"\t{this.Text}: hủy đóng.");
        }
    }
}
