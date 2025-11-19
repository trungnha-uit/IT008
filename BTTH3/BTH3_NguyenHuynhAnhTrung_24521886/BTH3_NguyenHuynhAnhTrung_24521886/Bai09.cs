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
    public partial class Bai09 : Form {
        public Bai09() {
            InitializeComponent();
        }

        // Chuyen cac Mon hoc sang listbox Mon hoc tham gia
        private void bChonMonHoc_Click(object sender, EventArgs e) {
            if (lbMonHoc.SelectedItems.Count <= 0) {
                MessageBox.Show("Chọn ít nhất 1 môn học để đăng ký!");
                return;
            }

            for (int i = 0; i < lbMonHoc.SelectedItems.Count; ++i) {
                object item = lbMonHoc.SelectedItems[i];

                if (!lbMonThamGia.Items.Contains(item)) {
                    lbMonThamGia.Items.Add(item);
                }
            }

            lbMonHoc.ClearSelected();
        }

        // Xoa cac mon duoc chon trong listbox Mon hoc tham gia
        private void bXoaMonHoc_Click(object sender, EventArgs e) {
            if (lbMonThamGia.SelectedItems.Count <= 0) {
                MessageBox.Show("Chọn ít nhất 1 môn học để hủy đăng ký!");
                return;
            }

            for (int i = lbMonThamGia.SelectedIndices.Count - 1; i >= 0; --i) {
                int idx = lbMonThamGia.SelectedIndices[i];

                lbMonThamGia.Items.RemoveAt(idx);
            }
        }

        // Xoa theo MSSV hoac dong duoc chon
        private void bXoa_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(tbMssv.Text)) {
                for (int i = 0; i < dgvSinhVien.Rows.Count; i++) {
                    if (dgvSinhVien.Rows[i].Cells[0].Value != null &&
                        dgvSinhVien.Rows[i].Cells[0].Value.ToString() == tbMssv.Text) {
                        dgvSinhVien.Rows.RemoveAt(i);
                        return;
                    }
                }

                MessageBox.Show("Không tìm thấy MSSV cần xóa!");
                return;
            }

            if (dgvSinhVien.SelectedRows.Count > 0)
                try {
                    dgvSinhVien.Rows.RemoveAt(dgvSinhVien.SelectedRows[0].Index);
                }
                catch {
                    MessageBox.Show("Không có gì để xóa!");
                }
            else
                MessageBox.Show("Chọn ít nhất 1 hàng hoặc nhập MSSV để xóa!");
        }

        // Luu thong tin sinh vien (co kiem tra cac truong rong va da ton tai sinh vien)
        private void bLuu_Click(object sender, EventArgs e) {
            if (!check_ThongTin())
                return;

            string gt;
            if (rbNam.Checked)
                gt = "Nam";
            else
                gt = "Nữ";

            string danhSachMon = "";
            foreach (var item in lbMonThamGia.Items) {
                danhSachMon += item.ToString() + ",";
            }
            danhSachMon = danhSachMon.TrimEnd(',');

            dgvSinhVien.Rows.Add(tbMssv.Text, tbHoTen.Text, cbChuyenNganh.SelectedItem.ToString(), gt, danhSachMon);

            xoa_ThongTin();
        }

        // Kiem tra de luu
        private bool check_ThongTin() {
            try {
                if (string.IsNullOrEmpty(tbMssv.Text) ||
                    string.IsNullOrEmpty(tbHoTen.Text) ||
                    cbChuyenNganh.SelectedIndex < 0)
                    throw new Exception("Điền đầy đủ thông tin!");

                if (!(rbNam.Checked || rbNu.Checked))
                    throw new Exception("Chưa chọn giới tính!");

                if (lbMonThamGia.Items.Count == 0)
                    throw new Exception("Cần đăng ký ít nhất 1 môn học!");

                for(int i = 0; i < dgvSinhVien.Rows.Count; ++i) {
                    if(dgvSinhVien.Rows[i].Cells[0].Value != null && tbMssv.Text == dgvSinhVien.Rows[i].Cells[0].Value.ToString()) {
                        throw new Exception("Đã tồn tại thông tin sinh viên! \nNếu muốn cập nhật cần xóa thông tin đã lưu.");
                    }
                }

                return true;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // Xoa thong tin
        private void xoa_ThongTin() {
            tbMssv.Text = string.Empty;
            tbHoTen.Text = string.Empty;
            rbNam.Checked = false;
            rbNu.Checked = false;
            cbChuyenNganh.SelectedIndex = -1;
            lbMonThamGia.Items.Clear();
            lbMonHoc.Items.Clear();
        }

        // Doi chuyen nganh doi mon hoc
        private void cbChuyenNganh_SelectedIndexChanged(object sender, EventArgs e) {
            object[] MonChung = new object[] {
            "Nhập Môn Lập Trình",
            "Giải Tích",
            "Đại Số Tuyến Tính",
            "Anh Văn",
            "Cơ Sở Dữ Liệu ",
            "Triết Học",
            "Tư Tưởng Hồ Chí Minh",
            "DSA",
            "OOP"};

            lbMonHoc.Items.Clear();
            lbMonHoc.Items.AddRange(MonChung);

            switch (cbChuyenNganh.SelectedIndex) {
                case 0:
                    lbMonHoc.Items.Add("Nhập môn ATTT");
                    break;
                case 1:
                    lbMonHoc.Items.Add("Nhập môn HTTT");
                    break;
                case 2:
                    lbMonHoc.Items.Add("Nhập môn TTNT");
                    break;
                case 3:
                    lbMonHoc.Items.AddRange(new object[] { "Nhập môn KTPM", "Lập trình trực quan" });
                    break;
                case 4:
                    lbMonHoc.Items.Add("Nhập môn TTDPT");
                    break;
                case 5:
                    lbMonHoc.Items.Add("Nhập môn CNTT");
                    break;
                case 6:
                    lbMonHoc.Items.Add("Nhập môn KHMT");
                    break;
                case 7:
                    lbMonHoc.Items.Add("Nhập môn KHDL");
                    break;
                case 8:
                    lbMonHoc.Items.Add("Nhập môn KTMT");
                    break;
                case 9:
                    lbMonHoc.Items.Add("Nhập môn TKVM");
                    break;
            }
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0)
                return; 

            DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];

            tbMssv.Text = row.Cells[0].Value?.ToString();
            tbHoTen.Text = row.Cells[1].Value?.ToString();

            string gt = row.Cells[3].Value?.ToString();
            if (gt == "Nam")
                rbNam.Checked = true;
            else if (gt == "Nữ")
                rbNu.Checked = true;

            cbChuyenNganh.SelectedItem = row.Cells[2].Value?.ToString();

            lbMonThamGia.Items.Clear();
            if (row.Cells[4].Value != null) {
                string[] mon = row.Cells[4].Value.ToString().Split(',');
                foreach (string m in mon)
                    lbMonThamGia.Items.Add(m.Trim());
            }
        }
    }
}
