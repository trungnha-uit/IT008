using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH5 {
    public partial class Bai04 : Form {
        public Bai04() {
            InitializeComponent();

            addFont_CBFont();

            InitializeControl();
        }

        private void InitializeControl() {
            this.SuspendLayout();

            cbFont.Text = "Arial";
        }

        private void addFont_CBFont() {
            InstalledFontCollection FONTS = new InstalledFontCollection();
            foreach(FontFamily font in FONTS.Families) {
                cbFont.Items.Add(font.Name);
            }
        }

        private void tbShow_FontChanged(object sender, EventArgs e) {
            int textWidth = TextRenderer.MeasureText("Hello", tbShow.Font).Width;
            int textHeight = TextRenderer.MeasureText("Hello", tbShow.Font).Height;

            tbShow.Width = textWidth * 2;

            tbShow.Location = new Point((this.ClientSize.Width - tbShow.Width) / 2, this.ClientSize.Height - tbShow.Height - 20);
        }

        private void cbSize_TextChange(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(cbSize.Text))
                return;

            float FontSize;

            if(!float.TryParse(cbSize.Text, out FontSize) || FontSize <= 0) {
                MessageBox.Show("Nhập số dương.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbSize.Text = "";
                return;
            }
            if(FontSize > 80) {
                MessageBox.Show("Font Size quá lớn!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbSize.Text = "";
                return;
            }

            Font old = tbShow.Font;

            tbShow.Font = new Font(tbShow.Font.FontFamily, FontSize, old.Style);
        }

        private void button1_Click(object sender, EventArgs e) {
            DialogResult r = colorDialog1.ShowDialog();

            if (r == DialogResult.OK) {
                bColor.BackColor = colorDialog1.Color;
                tbShow.ForeColor = colorDialog1.Color;
            }
        }

        private void cbFont_SelectedIndexChanged(object sender, EventArgs e) {
            if (cbFont.SelectedItem == null)
                return;

            Font old = tbShow.Font;

            tbShow.Font = new Font(cbFont.Text, float.Parse(cbSize.Text), old.Style);
        }

        private void rbLeft_CheckedChanged(object sender, EventArgs e) {
            if (rbLeft.Checked) {
                tbShow.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void rbCenter_CheckedChanged(object sender, EventArgs e) {
            if (rbCenter.Checked) { 
                tbShow.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void rbRight_CheckedChanged(object sender, EventArgs e) {
            if (rbRight.Checked) { 
                tbShow.TextAlign= HorizontalAlignment.Right;
            }
        }

        private void checkBBold_CheckedChanged(object sender, EventArgs e) {
            Font old = tbShow.Font;

            FontStyle newStyle = tbShow.Font.Style;
            newStyle = checkBBold.Checked ? (newStyle | FontStyle.Bold) : (newStyle & ~FontStyle.Bold);

            tbShow.Font = new Font(old, newStyle);
        }

        private void checkBItalic_CheckedChanged(object sender, EventArgs e) {
            Font old = tbShow.Font;

            FontStyle newStyle = tbShow.Font.Style;
            newStyle = checkBItalic.Checked ? (newStyle | FontStyle.Italic) : (newStyle & ~FontStyle.Italic);

            tbShow.Font = new Font(old, newStyle);
        }

        private void checkBUnderline_CheckedChanged(object sender, EventArgs e) {
            Font old = tbShow.Font;

            FontStyle newStyle = tbShow.Font.Style;
            newStyle = checkBUnderline.Checked ? (newStyle | FontStyle.Underline) : (newStyle & ~FontStyle.Underline);

            tbShow.Font = new Font(old, newStyle);
        }
    }
}
