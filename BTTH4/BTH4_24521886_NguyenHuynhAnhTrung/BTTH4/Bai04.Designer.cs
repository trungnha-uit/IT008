namespace BTTH4 {
    partial class Bai04 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoVănBảnMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mởTậpTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lưuNộiDungVănBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.địnhDạngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tStripNewFile = new System.Windows.Forms.ToolStripButton();
            this.tStripSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tStripFont = new System.Windows.Forms.ToolStripComboBox();
            this.tStripFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.tStripBold = new System.Windows.Forms.ToolStripButton();
            this.tStripItalic = new System.Windows.Forms.ToolStripButton();
            this.tStripUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.địnhDạngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoVănBảnMớiToolStripMenuItem,
            this.mởTậpTinToolStripMenuItem,
            this.toolStripSeparator1,
            this.lưuNộiDungVănBảnToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 26);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // tạoVănBảnMớiToolStripMenuItem
            // 
            this.tạoVănBảnMớiToolStripMenuItem.Image = global::BTTH4.Properties.Resources.file_icon;
            this.tạoVănBảnMớiToolStripMenuItem.Name = "tạoVănBảnMớiToolStripMenuItem";
            this.tạoVănBảnMớiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tạoVănBảnMớiToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.tạoVănBảnMớiToolStripMenuItem.Text = "Tạo văn bản mới";
            this.tạoVănBảnMớiToolStripMenuItem.Click += new System.EventHandler(this.tạoVănBảnMớiToolStripMenuItem_Click);
            // 
            // mởTậpTinToolStripMenuItem
            // 
            this.mởTậpTinToolStripMenuItem.Image = global::BTTH4.Properties.Resources.open_file;
            this.mởTậpTinToolStripMenuItem.Name = "mởTậpTinToolStripMenuItem";
            this.mởTậpTinToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mởTậpTinToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.mởTậpTinToolStripMenuItem.Text = "Mở tập tin";
            this.mởTậpTinToolStripMenuItem.Click += new System.EventHandler(this.mởTậpTinToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(282, 6);
            // 
            // lưuNộiDungVănBảnToolStripMenuItem
            // 
            this.lưuNộiDungVănBảnToolStripMenuItem.Image = global::BTTH4.Properties.Resources.save_icon;
            this.lưuNộiDungVănBảnToolStripMenuItem.Name = "lưuNộiDungVănBảnToolStripMenuItem";
            this.lưuNộiDungVănBảnToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.lưuNộiDungVănBảnToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.lưuNộiDungVănBảnToolStripMenuItem.Text = "Lưu nội dung văn bản";
            this.lưuNộiDungVănBảnToolStripMenuItem.Click += new System.EventHandler(this.lưuNộiDungVănBảnToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // địnhDạngToolStripMenuItem
            // 
            this.địnhDạngToolStripMenuItem.Name = "địnhDạngToolStripMenuItem";
            this.địnhDạngToolStripMenuItem.Size = new System.Drawing.Size(92, 26);
            this.địnhDạngToolStripMenuItem.Text = "Định dạng";
            this.địnhDạngToolStripMenuItem.Click += new System.EventHandler(this.địnhDạngToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripNewFile,
            this.tStripSave,
            this.toolStripSeparator2,
            this.tStripFont,
            this.tStripFontSize,
            this.tStripBold,
            this.tStripItalic,
            this.tStripUnderline,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tStripNewFile
            // 
            this.tStripNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tStripNewFile.Image = global::BTTH4.Properties.Resources.file_icon;
            this.tStripNewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripNewFile.Name = "tStripNewFile";
            this.tStripNewFile.Size = new System.Drawing.Size(29, 28);
            this.tStripNewFile.Text = "toolStripButton1";
            this.tStripNewFile.Click += new System.EventHandler(this.tStripNewFile_Click);
            // 
            // tStripSave
            // 
            this.tStripSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tStripSave.Image = global::BTTH4.Properties.Resources.save_icon;
            this.tStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripSave.Name = "tStripSave";
            this.tStripSave.Size = new System.Drawing.Size(29, 28);
            this.tStripSave.Text = "toolStripButton2";
            this.tStripSave.Click += new System.EventHandler(this.tStripSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // tStripFont
            // 
            this.tStripFont.Name = "tStripFont";
            this.tStripFont.Size = new System.Drawing.Size(200, 31);
            this.tStripFont.SelectedIndexChanged += new System.EventHandler(this.tStripFont_Size_IndexChanged);
            // 
            // tStripFontSize
            // 
            this.tStripFontSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.tStripFontSize.Name = "tStripFontSize";
            this.tStripFontSize.Size = new System.Drawing.Size(121, 31);
            this.tStripFontSize.SelectedIndexChanged += new System.EventHandler(this.tStripFont_Size_IndexChanged);
            // 
            // tStripBold
            // 
            this.tStripBold.BackColor = System.Drawing.SystemColors.Control;
            this.tStripBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tStripBold.Image = global::BTTH4.Properties.Resources.bold_icon;
            this.tStripBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripBold.Name = "tStripBold";
            this.tStripBold.Size = new System.Drawing.Size(29, 28);
            this.tStripBold.Text = "toolStripButton3";
            this.tStripBold.Click += new System.EventHandler(this.tStripBold_Click);
            // 
            // tStripItalic
            // 
            this.tStripItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tStripItalic.Image = global::BTTH4.Properties.Resources.italic_icon;
            this.tStripItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripItalic.Name = "tStripItalic";
            this.tStripItalic.Size = new System.Drawing.Size(29, 28);
            this.tStripItalic.Text = "toolStripButton4";
            this.tStripItalic.Click += new System.EventHandler(this.tStripItalic_Click);
            // 
            // tStripUnderline
            // 
            this.tStripUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tStripUnderline.Image = global::BTTH4.Properties.Resources.underline_icon;
            this.tStripUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripUnderline.Name = "tStripUnderline";
            this.tStripUnderline.Size = new System.Drawing.Size(29, 28);
            this.tStripUnderline.Text = "toolStripButton5";
            this.tStripUnderline.Click += new System.EventHandler(this.tStripUnderline_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 59);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 392);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Bai04";
            this.Text = "Soạn thảo văn bản";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai04_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem địnhDạngToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tStripNewFile;
        private System.Windows.Forms.ToolStripButton tStripSave;
        private System.Windows.Forms.ToolStripComboBox tStripFont;
        private System.Windows.Forms.ToolStripComboBox tStripFontSize;
        private System.Windows.Forms.ToolStripButton tStripBold;
        private System.Windows.Forms.ToolStripButton tStripItalic;
        private System.Windows.Forms.ToolStripButton tStripUnderline;
        private System.Windows.Forms.ToolStripMenuItem tạoVănBảnMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mởTậpTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuNộiDungVănBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}