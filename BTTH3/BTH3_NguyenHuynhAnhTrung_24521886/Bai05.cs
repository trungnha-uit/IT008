using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH3 {
    public partial class Bai05 : Form {
        public Bai05() {
            InitializeComponent();
        }

        private void bPlus_Click(object sender, EventArgs e) {
            double num1 = double.Parse(tbNumber1.Text);
            double num2 = double.Parse(tbNumber2.Text);

            tbAnswer.Text = (num1 + num2).ToString();
        }

        private void bSub_Click(object sender, EventArgs e) {
            double num1 = double.Parse(tbNumber1.Text);
            double num2 = double.Parse(tbNumber2.Text);

            tbAnswer.Text = (num1 - num2).ToString();
        }

        private void bMul_Click(object sender, EventArgs e) {
            double num1 = double.Parse(tbNumber1.Text);
            double num2 = double.Parse(tbNumber2.Text);

            tbAnswer.Text = (num1 * num2).ToString();
        }

        private void bDiv_Click(object sender, EventArgs e) {
            double num1 = double.Parse(tbNumber1.Text);
            double num2 = double.Parse(tbNumber2.Text);

            tbAnswer.Text = (num1 / num2).ToString();
        }

        private void tbNumber1_TextChanged(object sender, EventArgs e) {
            try {
                if (string.IsNullOrEmpty(tbNumber1.Text))
                    throw new Exception("Khong the rong");

                double value = double.Parse(tbNumber1.Text);
                if (double.IsInfinity(value))
                    throw new OverflowException();

                errorProvider1.SetError(tbNumber1, "");
            }
            catch (OverflowException) {
                errorProvider1.SetError(tbNumber1, "Tran so (Overflow)");
            }
            catch (FormatException) {
                errorProvider1.SetError(tbNumber1, "Nhap so");
            }
            catch (Exception ex) {
                errorProvider1.SetError(tbNumber1, ex.Message);
            }


            Enabled_gbCal();
        }

        private void tbNumber2_TextChanged(object sender, EventArgs e) {
            try {
                if (string.IsNullOrEmpty(tbNumber2.Text))
                    throw new Exception("Khong the rong");

                double value = double.Parse(tbNumber2.Text);
                if (double.IsInfinity(value))
                    throw new OverflowException();

                errorProvider1.SetError(tbNumber2, "");
                if(Math.Abs(value) <= 1e-9)
                    bDiv.Enabled = false;
                else 
                    bDiv.Enabled = true;
            }
            catch (OverflowException) {
                errorProvider1.SetError(tbNumber2, "Tran so (Overflow)");
            }
            catch (FormatException) {
                errorProvider1.SetError(tbNumber2, "Nhap so");
            }
            catch (Exception ex) {
                errorProvider1.SetError(tbNumber2, ex.Message);
            }

            Enabled_gbCal();
        }


        private void Enabled_gbCal() {
            gbCal.Enabled =
                string.IsNullOrEmpty(errorProvider1.GetError(tbNumber1)) &&
                string.IsNullOrEmpty(errorProvider1.GetError(tbNumber2));
        }

        private void Bai05_Load(object sender, EventArgs e) {
            gbCal.Enabled = false;
        }

        private void Calculated(Func<double, double, double> op) {
            try {
                double num1 = double.Parse(tbNumber1.Text);
                double num2 = double.Parse(tbNumber2.Text);

                double res = op(num1, num2);

                if (double.IsInfinity(res))
                    throw new OverflowException();


            }
            catch (OverflowException) {
                tbAnswer.Text = "";
                errorProvider1.SetError(tbAnswer, "Tran so (Overflow)");
            }
            catch (Exception ex) {
                tbAnswer.Text = "";
                errorProvider1.SetError(tbAnswer, ex.Message);
            }
        }
    }
}
