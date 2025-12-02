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

namespace BTTH4 {
    public partial class Bai03 : Form {
        public Bai03() {
            InitializeComponent();

            DateTime now = DateTime.Now;
            toolStripStatusLabel1.Text = "Hôm nay là ngày " + now.ToString("dd/MM/yyyy") + " - Bây giờ là " + now.ToString("T");
        }

        private void timer1_Tick(object sender, EventArgs e) {
            DateTime now = DateTime.Now;
            toolStripStatusLabel1.Text = "Hôm nay là ngày " + now.ToString("dd/MM/yyyy") + " - Bây giờ là " + now.ToString("T");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "AVI File (*.avi)|*.avi|MPEG File (*.mpeg)|*.mpeg|WAV File (*.wav)|*.wav|" +
                "MIDI File (*.mid)|*.mid|MP4 File (*.mp4)|*.mp4|MP3 File (*.mp3)|*.mp3";

            DialogResult r = openFileDialog1.ShowDialog();
            if (r == DialogResult.OK) {

                if (!File.Exists(openFileDialog1.FileName)) {
                    MessageBox.Show("File khong ton tai.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                WMP.URL = openFileDialog1.FileName;
            }
        }

        private void Bai03_Resize(object sender, EventArgs e) {
            WMP.Size = this.ClientSize;
        }

        private void WMP_MediaError(object sender, AxWMPLib._WMPOCXEvents_MediaErrorEvent e) {
            MessageBox.Show("File loi.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
