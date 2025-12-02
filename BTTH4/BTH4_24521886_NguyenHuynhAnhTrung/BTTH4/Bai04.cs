using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTTH4 {
    public partial class Bai04 : Form {
        private bool Bold;
        private bool Italic;
        private bool Underline;
        public Bai04() {
            InitializeComponent();

            InstalledFontCollection font = new InstalledFontCollection();
            foreach(FontFamily fontFamily in font.Families) {
                tStripFont.Items.Add(fontFamily.Name);
            }

            DefaulteFile();
        }

        private void DefaulteFile() {
            openFileDialog1.FileName = "";

            richTextBox1.Clear();
            richTextBox1.SelectionFont = new Font("Tahoma", 14);
            tStripFont.Text = "Tahoma";
            tStripFontSize.Text = "14";
        }

        private void Open() {
            if (!string.IsNullOrEmpty(richTextBox1.Text)) {
                DialogResult r = MessageBox.Show("Bạn có muốn lưu file hiện tại ?", "Thông Báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (r == DialogResult.Yes) {
                    Save();
                    OpenFile();
                } else if (r == DialogResult.Cancel)
                    return;
                else
                    OpenFile();
            }else
                OpenFile();
        }

        private void OpenFile() {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "RichText File (*.rtf)|*.rtf|TXT File (*.txt)|*.txt";

            DialogResult r = openFileDialog1.ShowDialog();
            if (r == DialogResult.OK) {
                try {
                    if (openFileDialog1.FileName.EndsWith(".rtf")) {
                        richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    } else {
                        richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show($"Mở file không thành công. Do {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            richTextBox1.SelectionStart = richTextBox1.TextLength / 2;
            richTextBox1.SelectionStart = richTextBox1.TextLength;
        }

        private void Save() {
            if (string.IsNullOrEmpty(openFileDialog1.FileName)) {
                SaveFile();
            } else {
                try {
                    richTextBox1.SaveFile(openFileDialog1.FileName);
                    MessageBox.Show("Lưu văn bản thành công.", "Thông Báo", MessageBoxButtons.OK);
                }
                catch (Exception ex) {
                    MessageBox.Show($"Lưu văn bản không thành công. Do {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveFile() {
            saveFileDialog1.FileName = "RichText_File";
            saveFileDialog1.Filter = "RichText File (*.rtf)|*.rtf";

            DialogResult r = saveFileDialog1.ShowDialog();
            if (r == DialogResult.OK) {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e) {
            DialogResult r = fontDialog1.ShowDialog();

            if (r == DialogResult.OK) { 
                richTextBox1.SelectionFont = fontDialog1.Font;

                tStripFont.Text = fontDialog1.Font.FontFamily.Name;
                tStripFontSize.Text = ((int)fontDialog1.Font.Size).ToString();

                getFontStyle();
            }
        }

        private void tStripNewFile_Click(object sender, EventArgs e) {
            DefaulteFile();
        }

        private void tStripSave_Click(object sender, EventArgs e) {
            Save();
        }

        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e) {
            DefaulteFile();
        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e) {
            Open();
        }

        private void lưuNộiDungVănBảnToolStripMenuItem_Click(object sender, EventArgs e) {
            Save();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(richTextBox1.Text)) {
                DialogResult r = MessageBox.Show("Bạn có muốn lưu file trước khi thoát ?", "Thông Báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (r == DialogResult.Yes) {
                    Save();
                    OpenFile();
                } else if (r == DialogResult.Cancel)
                    return;
            }

            Close();
        }

        private void tStripFont_Size_IndexChanged(object sender, EventArgs e) {
            try {
                if (richTextBox1.SelectionFont == null)
                    return;

                Font old = richTextBox1.SelectionFont;

                richTextBox1.SelectionFont = new Font(tStripFont.Text, int.Parse(tStripFontSize.Text), old.Style);
            }
            catch { }
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e) {
            if (richTextBox1.SelectionFont != null) {
                tStripFont.Text = richTextBox1.SelectionFont.FontFamily.Name;
                tStripFontSize.Text = ((int)richTextBox1.SelectionFont.Size).ToString();

                getFontStyle();
            }
        }

        private void tStripBold_Click(object sender, EventArgs e) {
            Bold = !Bold;
            FontStyle style;
            tStripBold.BackColor = Bold ? Color.Gray : Color.White;

            if (richTextBox1.SelectionLength > 0) {

                // Duyet tung ki tu de giu dinh dang TH nhieu dinh dang khac nhau
                ChangeStyleChar(Bold, FontStyle.Bold);
            } else {

                style = Bold ? richTextBox1.SelectionFont.Style | FontStyle.Bold : richTextBox1.SelectionFont.Style & ~FontStyle.Bold;
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
            }
        }

        private void tStripItalic_Click(object sender, EventArgs e) {
            Italic = !Italic;
            FontStyle style;
            tStripItalic.BackColor = Italic ? Color.Gray : Color.White;

            if (richTextBox1.SelectionLength > 0) {
                ChangeStyleChar(Italic, FontStyle.Italic);
            } else {
                style = Italic ? richTextBox1.SelectionFont.Style | FontStyle.Italic : richTextBox1.SelectionFont.Style & ~FontStyle.Italic;
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
            }
        }

        private void tStripUnderline_Click(object sender, EventArgs e) {
            Underline = !Underline;
            FontStyle style;
            tStripUnderline.BackColor = Underline ? Color.Gray : Color.White;

            if (richTextBox1.SelectionLength > 0) {
                ChangeStyleChar(Underline, FontStyle.Underline);
            } else {
                style = Underline ? richTextBox1.SelectionFont.Style | FontStyle.Underline : richTextBox1.SelectionFont.Style & ~FontStyle.Underline;
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
            }
        }

        private void getFontStyle() {
            Bold = richTextBox1.SelectionFont.Bold;
            Italic = richTextBox1.SelectionFont.Italic;
            Underline = richTextBox1.SelectionFont.Underline;

            tStripBold.BackColor = Bold ? Color.Gray : Color.White;
            tStripItalic.BackColor = Italic ? Color.Gray : Color.White;
            tStripUnderline.BackColor = Underline ? Color.Gray : Color.White;
        }

        private void ChangeStyleChar(bool type, FontStyle Fstyle) {
            FontStyle style;
            int start = richTextBox1.SelectionStart;
            int end = richTextBox1.SelectionLength;

            if (type) {
                for (int i = start; i < start + end; ++i) {
                    richTextBox1.SelectionStart = i;
                    richTextBox1.SelectionLength = 1;
                    style = richTextBox1.SelectionFont.Style | Fstyle;

                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
                }
            } else {
                for (int i = start; i < start + end; ++i) {
                    richTextBox1.SelectionStart = i;
                    richTextBox1.SelectionLength = 1;
                    style = richTextBox1.SelectionFont.Style & ~Fstyle;

                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
                }
            }
            richTextBox1.SelectionStart = start + end;
            richTextBox1.SelectionLength = 0;
        }

        private void Bai04_FormClosing(object sender, FormClosingEventArgs e) {
            if (!string.IsNullOrEmpty(richTextBox1.Text)) {
                DialogResult r = MessageBox.Show("Bạn có muốn lưu file trước khi thoát ?", "Thông Báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (r == DialogResult.Yes) {
                    Save();
                    OpenFile();
                } else if (r == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }
    }
}
