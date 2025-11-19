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
            errorProvider1.SetError(tbAnswer, "");
            double num1 = double.Parse(tbNumber1.Text);
            double num2 = double.Parse(tbNumber2.Text);

            tbAnswer.Text = Calculated((a, b) => (a + b)).ToString();
        }

        private void bSub_Click(object sender, EventArgs e) {
            errorProvider1.SetError(tbAnswer, "");
            double num1 = double.Parse(tbNumber1.Text);
            double num2 = double.Parse(tbNumber2.Text);

            tbAnswer.Text = Calculated((a, b) => (a - b)).ToString();
        }

        private void bMul_Click(object sender, EventArgs e) {
            errorProvider1.SetError(tbAnswer, "");
            double num1 = double.Parse(tbNumber1.Text);
            double num2 = double.Parse(tbNumber2.Text);

            tbAnswer.Text = Calculated((a, b) => (a * b)).ToString();
        }

        private void bDiv_Click(object sender, EventArgs e) {
            errorProvider1.SetError(tbAnswer, "");
            double num1 = double.Parse(tbNumber1.Text);
            double num2 = double.Parse(tbNumber2.Text);

            tbAnswer.Text = Calculated((a, b) => (a / b)).ToString();
        }

        private void tbNumber1_TextChanged(object sender, EventArgs e) {
            ValidateInput(tbNumber1);
            Enabled_gbCal();
        }

        private void tbNumber2_TextChanged(object sender, EventArgs e) {
            if (ValidateInput(tbNumber2)) {
                double v = double.Parse(tbNumber2.Text);
                bDiv.Enabled = Math.Abs(v) > 1e-9;
            }
            Enabled_gbCal();
        }

        private bool ValidateInput(TextBox tb) {
            try {
                if (string.IsNullOrEmpty(tb.Text))
                    throw new Exception("Khong the rong");

                double value = double.Parse(tb.Text);
                if (double.IsInfinity(value))
                    throw new OverflowException();

                errorProvider1.SetError(tb, "");
                return true;
            }
            catch (OverflowException) {
                errorProvider1.SetError(tb, "Tran so (Overflow)");
            }
            catch (FormatException) {
                errorProvider1.SetError(tb, "Nhap so");
            }
            catch (Exception ex) {
                errorProvider1.SetError(tb, ex.Message);
            }

            return false;
        }

        private void Enabled_gbCal() {
            gbCal.Enabled =
                string.IsNullOrEmpty(errorProvider1.GetError(tbNumber1)) &&
                string.IsNullOrEmpty(errorProvider1.GetError(tbNumber2)) &&
                !string.IsNullOrEmpty(tbNumber1.Text) &&
                !string.IsNullOrEmpty(tbNumber2.Text);
        }

        private void Bai05_Load(object sender, EventArgs e) {
            gbCal.Enabled = false;
        }

        private double Calculated(Func<double, double, double> op) {
            try {
                double num1 = double.Parse(tbNumber1.Text);
                double num2 = double.Parse(tbNumber2.Text);

                double res = op(num1, num2);

                if (double.IsInfinity(res))
                    throw new OverflowException();

                return res;
            }
            catch (OverflowException) {
                tbAnswer.Text = "";
                errorProvider1.SetError(tbAnswer, "Tran so (Overflow)");
            }
            catch (Exception ex) {
                tbAnswer.Text = "";
                errorProvider1.SetError(tbAnswer, ex.Message);
            }
            return 0;
        }
    }
}
