using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTTH3 {
    public partial class Bai08 : Form {
        private static int stt = 1;
        private decimal sum = 0;
        public Bai08() {
            InitializeComponent();
        }

        private void bAddUpdate_Click(object sender, EventArgs e) {
            if (!Check_TextBox()) {
                return;
            }

            foreach (ListViewItem item in lvKhachHang.Items) {
                if (item.SubItems[1].Text == tbSoTaiKhoan.Text) {
                    sum -= decimal.Parse(item.SubItems[4].Text);
                    decimal tmp = decimal.Parse(tbSoTien.Text);
                    try {
                        checked {
                            sum = sum + tmp;
                        }
                    }
                    catch (OverflowException) {
                        MessageBox.Show("Không thể thêm mới cập nhật! \nTổng số tiền vượt quá giới hạn cho phép!");
                        return;
                    }
                    tbSumTien.Text = sum.ToString();

                    item.SubItems[2].Text = tbTenKhachHang.Text;
                    item.SubItems[3].Text = tbDiaChi.Text;
                    item.SubItems[4].Text = tbSoTien.Text;

                    MessageBox.Show("Cập nhật dữ liệu thành công!");
                    Reset_TextBox();

                    return;
                }
            }
            
            string[] row = {stt.ToString(), tbSoTaiKhoan.Text, tbTenKhachHang.Text, tbDiaChi.Text, tbSoTien.Text};
            decimal newValue = decimal.Parse(tbSoTien.Text);
            try {
                checked {
                    sum = sum + newValue;
                }
            }
            catch (OverflowException) {
                MessageBox.Show("Không thể thêm mới! \nTổng số tiền vượt quá giới hạn cho phép!");
                return;
            }
            tbSumTien.Text = sum.ToString();
            lvKhachHang.Items.Add(new ListViewItem(row));
            MessageBox.Show("Thêm mới dữ liệu thành công!");

            stt++;

            Reset_TextBox();
        }

        private void bDel_Click(object sender, EventArgs e) {
            int idx = -1;
            for(int i = 0; i < lvKhachHang.Items.Count; ++i) {
                if (lvKhachHang.Items[i].SubItems[1].Text == tbSoTaiKhoan.Text) {
                    idx = i; 
                    break;
                }
            }

            if (idx >= 0) {
                DialogResult reuslt = MessageBox.Show($"Bạn có chắc muốn xóa tài khoản {tbSoTaiKhoan.Text}?", "Cảnh báo", MessageBoxButtons.YesNo);

                if (reuslt == DialogResult.Yes) {
                    sum -= decimal.Parse(lvKhachHang.Items[idx].SubItems[4].Text);
                    tbSumTien.Text = sum.ToString();

                    lvKhachHang.Items.RemoveAt(idx);
                    MessageBox.Show("Xóa tài khoản thành công");

                    stt = 1;
                    foreach(ListViewItem item in lvKhachHang.Items) {
                        item.SubItems[0].Text = stt.ToString();
                        stt++;
                    }
                }
            } else {
                MessageBox.Show("Không tìm thấy số tài khoản cần xóa");
            }
        }

        private void bExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private bool Check_TextBox() {
            try {
                if (string.IsNullOrEmpty(tbSoTaiKhoan.Text) ||
                    string.IsNullOrEmpty(tbTenKhachHang.Text) ||
                    string.IsNullOrEmpty(tbDiaChi.Text))
                    throw new InvalidDataException();

                decimal tmp = decimal.Parse(tbSoTien.Text);
                if(tmp < 0) {
                    throw new Exception();
                }
            }
            catch(InvalidDataException) {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return false;
            }
            catch {
                MessageBox.Show("Trường số tiền không đúng định dạng! \nCó thể bị tràn, số âm, kí tự, ....");
                return false;
            }

            return true;
        }

        private void lvKhachHang_SelectedIndexChanged(object sender, EventArgs e) {
            if (lvKhachHang.SelectedItems.Count <= 0)
                return;
            if (lvKhachHang.SelectedItems.Count > 1)
                MessageBox.Show("Chỉ có thể hiển thị tài khoản có STT nhỏ nhất!");

            tbSoTaiKhoan.Text = lvKhachHang.SelectedItems[0].SubItems[1].Text;
            tbTenKhachHang.Text = lvKhachHang.SelectedItems[0].SubItems[2].Text;
            tbDiaChi.Text = lvKhachHang.SelectedItems[0].SubItems[3].Text;
            tbSoTien.Text = lvKhachHang.SelectedItems[0].SubItems[4].Text;
        }

        private void Reset_TextBox() {
            tbSoTaiKhoan.Text = "";
            tbTenKhachHang.Text = "";
            tbDiaChi.Text = "";
            tbSoTien.Text = "";
        }
    }
}
