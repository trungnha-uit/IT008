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
    public partial class Bai06 : Form {
        public Bai06() {
            InitializeComponent();

            toolTip1.SetToolTip(tbPathSrc, "Địa chỉ thư mục nguồn");
            toolTip1.SetToolTip(tbPathDest, "Địa chỉ thư mục đích");
            toolTip1.SetToolTip(bPathSrc, "Chọn thư mục nguồn");
            toolTip1.SetToolTip(bPathDest, "Chọn thư mục đích");
            toolTip1.SetToolTip(bCopy, "Bắt đầu sao chép");

            progressBar1.Value = 0;
            progressBar1.Maximum = 0;
        }

        bool SrcFlag, DestFlag, isFormClosing;

        private void bPathSrc_Click(object sender, EventArgs e) {
            DialogResult r = getSrcLocation.ShowDialog();

            if (r == DialogResult.OK) {
                tbPathSrc.Text = getSrcLocation.SelectedPath;
            } else {
                getSrcLocation.SelectedPath = null;
            }
        }

        private void bPathDest_Click(object sender, EventArgs e) {
            DialogResult r = getDestLocation.ShowDialog();

            if (r == DialogResult.OK) { 
                tbPathDest.Text = getDestLocation.SelectedPath;
            } else {
                getDestLocation.SelectedPath = null;
            }
        }

        private void tbPathSrc_TextChanged(object sender, EventArgs e) {
            try {
                getSrcLocation.SelectedPath = tbPathSrc.Text;
                SrcFlag = true;
                bCopy.Enabled = SrcFlag & DestFlag;
                errorProvider1.SetError(tbPathSrc, "");
            }catch {
                errorProvider1.SetError(tbPathSrc, "Lỗi đường dẫn thư mục!");
                SrcFlag = false;
            }
        }

        private void tbPathDest_TextChanged(object sender, EventArgs e) {
            try {
                getDestLocation.SelectedPath = tbPathDest.Text;
                DestFlag = true;
                bCopy.Enabled = DestFlag & SrcFlag;
                errorProvider1.SetError(tbPathDest, "");
            }
            catch {
                errorProvider1.SetError(tbPathDest, "Lỗi đường dẫn thư mục!");
                DestFlag = false;
            }
        }

        private async void bCopy_Click(object sender, EventArgs e) {
            try {
                string src = getSrcLocation.SelectedPath;
                string dest = getDestLocation.SelectedPath;
                if (!Directory.Exists(src)) {
                    MessageBox.Show("Thư mục không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Directory.Exists(dest)) { 
                    Directory.CreateDirectory(dest);
                }

                string[] files = Directory.GetFiles(src);
                progressBar1.Maximum = files.Length;
                progressBar1.Value = 0;

                foreach(string file in files) {
                    if (isFormClosing)
                        return;

                    string destFile = Path.Combine(dest, Path.GetFileName(file));

                    toolStripStatusLabel1.Text = "Đang sao chép: " + file;
                    toolTip1.SetToolTip(statusStrip1, $"Đang sao chép: {file}");
                    toolTip1.SetToolTip(progressBar1, $"Sao chép được: {progressBar1.Value * 100.0 / progressBar1.Maximum}%");
                    statusStrip1.Refresh();
                    progressBar1.Value++;

                    if (File.Exists(destFile)) {
                        DialogResult r = MessageBox.Show($"Đã tồn tại file {destFile}. Muốn replace?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if(r == DialogResult.No) {
                            continue;
                        }
                    }

                    File.Copy(file, destFile, true);

                    await Task.Delay(500);
                }

                statusStrip1.Refresh();
                await Task.Delay(500);
                MessageBox.Show("Hoàn thành.", "Thông báo", MessageBoxButtons.OK);
                toolStripStatusLabel1.Text = "";
                ResetPath();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bai06_FormClosing(object sender, FormClosingEventArgs e) {
            if (progressBar1.Value < progressBar1.Maximum) {
                DialogResult r = MessageBox.Show("Chưa hoàn thành việc sao chép. Muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (r == DialogResult.Cancel) { 
                    e.Cancel = true;
                } else {
                    isFormClosing = true;
                }
            }
        }

        private void ResetPath() {
            getSrcLocation.SelectedPath = "";
            getDestLocation.SelectedPath = "";

            tbPathSrc.Text = "";
            tbPathDest.Text = "";

            progressBar1.Value = 0;
            progressBar1.Maximum = 0;
        }
    }
}
