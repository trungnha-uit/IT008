using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH3 {
    public partial class Bai06 : Form {
        public Bai06() {
            InitializeComponent();
        }

        private double NumAns = 0;
        private double Mem = 0;
        private char op = '\0';

       private void b0_Click(object sender, EventArgs e) {
            tbNumber.Text += "0";
        }

        private void b1_Click(object sender, EventArgs e) {
            tbNumber.Text += "1";
        }

        private void b2_Click(object sender, EventArgs e) {
            tbNumber.Text += "2";
        }

        private void b3_Click(object sender, EventArgs e) {
            tbNumber.Text += "3";
        }

        private void b4_Click(object sender, EventArgs e) {
            tbNumber.Text += "4";
        }

        private void b5_Click(object sender, EventArgs e) {
            tbNumber.Text += "5";
        }

        private void b6_Click(object sender, EventArgs e) {
            tbNumber.Text += "6";
        }

        private void b7_Click(object sender, EventArgs e) {
            tbNumber.Text += "7";
        }

        private void b8_Click(object sender, EventArgs e) {
            tbNumber.Text += "8";
        }

        private void b9_Click(object sender, EventArgs e) {
            tbNumber.Text += "9";
        }

        private void bDot_Click(object sender, EventArgs e) {
            tbNumber.Text += ".";
        }

        private void bNegative_Click(object sender, EventArgs e) {
            if(tbNumber.Text.Length == 0) {
                return;
            }

            if (tbNumber.Text[0] == '-') { 
                tbNumber.Text = tbNumber.Text.Substring(1);
            } else {
                tbNumber.Text = "-" + tbNumber.Text;
            }
        }

        private double Safe_Convert(string num) {
            if (string.IsNullOrWhiteSpace(num))
                throw new Exception("Vui lòng nhập số!");

            if (!double.TryParse(num, out double res))
                throw new Exception("Sai định dạng số!");

            return res;
        }

        private void ApplyOperator() {
            try {
                double val = Safe_Convert(tbNumber.Text);

                switch (op) {
                    case '+':
                        NumAns += val;
                        break;
                    case '-':
                        NumAns -= val;
                        break;
                    case '*':
                        NumAns *= val;
                        break;
                    case '/':
                        if (val == 0)
                            throw new Exception("Không thể chia cho 0!");
                        NumAns /= val;
                        break;
                    default:
                        NumAns = val;
                        break;
                }

                tbNumber.Text = "";
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNumber.Text = "";
            }
        }


        private void bAdd_Click(object sender, EventArgs e) {
            ApplyOperator();
            op = '+';
        }

        private void bSub_Click(object sender, EventArgs e) {
            ApplyOperator();
            op = '-';
        }

        private void bMul_Click(object sender, EventArgs e) {
            ApplyOperator();
            op = '*';
        }

        private void bDiv_Click(object sender, EventArgs e) {
            ApplyOperator();
            op = '/';
        }

        private void bAns_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(tbNumber.Text)){
                tbNumber.Text = NumAns.ToString();
            }else {
                ApplyOperator();
                tbNumber.Text = NumAns.ToString();
                op = '\0';
            }
        }

        private void bBSpace_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(tbNumber.Text)) {
                tbNumber.Text = tbNumber.Text.Substring(0, tbNumber.Text.Length - 1);
            }
        }

        private void C_Click(object sender, EventArgs e) {
            tbNumber.Text = "";
            op = '\0';
            NumAns = 0;
        }

        private void bCE_Click(object sender, EventArgs e) {
            tbNumber.Text = "";
        }

        private void bSqrt_Click(object sender, EventArgs e) {
            try {
                double val = Safe_Convert(tbNumber.Text);
                if (val < 0)
                    throw new Exception("Không thể lấy căn số âm!");
                NumAns = Math.Sqrt(val);
                tbNumber.Text = NumAns.ToString();
                op = '\0';
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void pPercent_Click(object sender, EventArgs e) {
            try {
                NumAns = Safe_Convert(tbNumber.Text) / 100;
                tbNumber.Text = NumAns.ToString();
                op = '\0';
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void b_Click(object sender, EventArgs e) {
            try {
                double v = Safe_Convert(tbNumber.Text);
                if (v == 0)
                    throw new Exception("Không thể chia cho 0!");
                NumAns = 1.0 / v;
                tbNumber.Text = NumAns.ToString();
                op = '\0';
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void bMC_Click(object sender, EventArgs e) {
            Mem = 0;
        }

        private void bMR_Click(object sender, EventArgs e) {
            tbNumber.Text = Mem.ToString();
        }

        private void bMS_Click(object sender, EventArgs e) {
            try {
                Mem = Safe_Convert(tbNumber.Text);
            }catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void bMplus_Click(object sender, EventArgs e) {
            Mem += Safe_Convert(tbNumber.Text);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e) {
            if(!string.IsNullOrEmpty(tbNumber.Text))
                Clipboard.SetText(tbNumber.Text);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e) {
            if (Clipboard.ContainsText()) 
                tbNumber.Text = Clipboard.GetText();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Chưa cài đặt.", "View", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e) {
            Process.Start("https://support.microsoft.com/en-us/windows/use-the-calculator-in-windows-8dc0eb59-a45f-72b6-71bd-e752920f36c3");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Máy tính được viết bằng WinForms (Dựa trên Calculator của Microsoft). \n\nCác chức năng: + - × /, căn bậc 2, %, 1/x,... \n\nBy Trung-nha 24521886.", 
                "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
