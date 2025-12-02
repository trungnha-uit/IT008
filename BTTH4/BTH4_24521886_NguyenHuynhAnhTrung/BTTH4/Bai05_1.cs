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
    public partial class Bai05_1 : Form {
        DataGridView dgvAdd;
        public Bai05_1(DataGridView dgv) {
            InitializeComponent();

            this.dgvAdd = dgv;
        }

        private void bThoat_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void bThemMoi_Click(object sender, EventArgs e) {
            if (checkError())
                return;
            if (checkExitMSSV()) {
                MessageBox.Show("MSSV da ton tai.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int stt = dgvAdd.RowCount;
            dgvAdd.Rows.Add(stt, tbMSSV.Text, tbTenSV.Text, cbKhoa.Text, double.Parse(tbDiemTB.Text));
            clearData();
        }

        private bool checkError() {
            try {
                if (string.IsNullOrEmpty(tbMSSV.Text))
                    throw new Exception("Truong MSSV khong the rong.");

                if (string.IsNullOrEmpty(tbTenSV.Text))
                    throw new Exception("Truong Ten Sinh Vien khong the rong.");

                if (string.IsNullOrEmpty(cbKhoa.Text))
                    throw new Exception("Truong Khoa khong the rong.");

                double tmp;
                if (!double.TryParse(tbDiemTB.Text, out tmp) || tmp < 0 || tmp > 10) {
                    throw new Exception("Loi truong Diem TB");
                }
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }

        private void clearData() {
            tbMSSV.Text = "";
            tbTenSV.Text = "";
            tbDiemTB.Text = "";
            cbKhoa.SelectedIndex = -1;
        }

        private bool checkExitMSSV() {
            string MSSV = tbMSSV.Text.Trim();

            foreach(DataGridViewRow item in dgvAdd.Rows) {
                if (!item.IsNewRow) {
                    string value = item.Cells["MSSV"].Value?.ToString().Trim();
                    if (value == MSSV) {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
