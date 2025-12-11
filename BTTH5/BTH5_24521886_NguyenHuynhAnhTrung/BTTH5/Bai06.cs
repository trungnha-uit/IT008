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
    public partial class Bai06 : Form {
        public Bai06() {
            InitializeComponent();

            AddFonts();
        }

        private void AddFonts() {
            InstalledFontCollection Fonts = new InstalledFontCollection();

            foreach(FontFamily font in Fonts.Families) {
                int start = richTextBox1.Text.Length;

                richTextBox1.AppendText(font.Name + "\n");

                richTextBox1.SelectionStart = start;
                richTextBox1.SelectionLength = font.Name.Length;

                richTextBox1.SelectionFont = new Font(font.Name, 12);
            }

            richTextBox1.SelectionLength = 0;
            richTextBox1.SelectionStart = 0;
        }
    }
}
