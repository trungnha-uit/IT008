namespace BTTH5 {
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
            this.tbShow = new System.Windows.Forms.TextBox();
            this.lSize = new System.Windows.Forms.Label();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.lColor = new System.Windows.Forms.Label();
            this.bColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cbFont = new System.Windows.Forms.ComboBox();
            this.lFont = new System.Windows.Forms.Label();
            this.checkBBold = new System.Windows.Forms.CheckBox();
            this.checkBItalic = new System.Windows.Forms.CheckBox();
            this.checkBUnderline = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbRight = new System.Windows.Forms.RadioButton();
            this.rbCenter = new System.Windows.Forms.RadioButton();
            this.rbLeft = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbShow
            // 
            this.tbShow.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbShow.Location = new System.Drawing.Point(360, 401);
            this.tbShow.Name = "tbShow";
            this.tbShow.ReadOnly = true;
            this.tbShow.Size = new System.Drawing.Size(62, 22);
            this.tbShow.TabIndex = 0;
            this.tbShow.TabStop = false;
            this.tbShow.Text = "Hello";
            this.tbShow.FontChanged += new System.EventHandler(this.tbShow_FontChanged);
            // 
            // lSize
            // 
            this.lSize.AutoSize = true;
            this.lSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSize.Location = new System.Drawing.Point(538, 104);
            this.lSize.Name = "lSize";
            this.lSize.Size = new System.Drawing.Size(51, 25);
            this.lSize.TabIndex = 1;
            this.lSize.Text = "Size";
            // 
            // cbSize
            // 
            this.cbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
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
            this.cbSize.Location = new System.Drawing.Point(613, 101);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(123, 33);
            this.cbSize.TabIndex = 1;
            this.cbSize.Text = "8";
            this.cbSize.TextChanged += new System.EventHandler(this.cbSize_TextChange);
            // 
            // lColor
            // 
            this.lColor.AutoSize = true;
            this.lColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lColor.Location = new System.Drawing.Point(530, 171);
            this.lColor.Name = "lColor";
            this.lColor.Size = new System.Drawing.Size(59, 25);
            this.lColor.TabIndex = 3;
            this.lColor.Text = "Color";
            // 
            // bColor
            // 
            this.bColor.Location = new System.Drawing.Point(613, 163);
            this.bColor.Name = "bColor";
            this.bColor.Size = new System.Drawing.Size(54, 33);
            this.bColor.TabIndex = 2;
            this.bColor.UseVisualStyleBackColor = true;
            this.bColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbFont
            // 
            this.cbFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFont.FormattingEnabled = true;
            this.cbFont.Location = new System.Drawing.Point(108, 42);
            this.cbFont.Name = "cbFont";
            this.cbFont.Size = new System.Drawing.Size(269, 33);
            this.cbFont.TabIndex = 0;
            this.cbFont.SelectedIndexChanged += new System.EventHandler(this.cbFont_SelectedIndexChanged);
            // 
            // lFont
            // 
            this.lFont.AutoSize = true;
            this.lFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFont.Location = new System.Drawing.Point(33, 45);
            this.lFont.Name = "lFont";
            this.lFont.Size = new System.Drawing.Size(51, 25);
            this.lFont.TabIndex = 5;
            this.lFont.Text = "Font";
            // 
            // checkBBold
            // 
            this.checkBBold.AutoSize = true;
            this.checkBBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBBold.Location = new System.Drawing.Point(38, 100);
            this.checkBBold.Name = "checkBBold";
            this.checkBBold.Size = new System.Drawing.Size(58, 40);
            this.checkBBold.TabIndex = 6;
            this.checkBBold.Text = "B";
            this.checkBBold.UseVisualStyleBackColor = true;
            this.checkBBold.CheckedChanged += new System.EventHandler(this.checkBBold_CheckedChanged);
            // 
            // checkBItalic
            // 
            this.checkBItalic.AutoSize = true;
            this.checkBItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBItalic.Location = new System.Drawing.Point(121, 100);
            this.checkBItalic.Name = "checkBItalic";
            this.checkBItalic.Size = new System.Drawing.Size(45, 40);
            this.checkBItalic.TabIndex = 7;
            this.checkBItalic.Text = "I";
            this.checkBItalic.UseVisualStyleBackColor = true;
            this.checkBItalic.CheckedChanged += new System.EventHandler(this.checkBItalic_CheckedChanged);
            // 
            // checkBUnderline
            // 
            this.checkBUnderline.AutoSize = true;
            this.checkBUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBUnderline.Location = new System.Drawing.Point(189, 100);
            this.checkBUnderline.Name = "checkBUnderline";
            this.checkBUnderline.Size = new System.Drawing.Size(59, 40);
            this.checkBUnderline.TabIndex = 8;
            this.checkBUnderline.Text = "U";
            this.checkBUnderline.UseVisualStyleBackColor = true;
            this.checkBUnderline.CheckedChanged += new System.EventHandler(this.checkBUnderline_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbRight);
            this.groupBox1.Controls.Add(this.rbCenter);
            this.groupBox1.Controls.Add(this.rbLeft);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 106);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Align Text";
            // 
            // rbRight
            // 
            this.rbRight.AutoSize = true;
            this.rbRight.Location = new System.Drawing.Point(259, 49);
            this.rbRight.Name = "rbRight";
            this.rbRight.Size = new System.Drawing.Size(69, 24);
            this.rbRight.TabIndex = 2;
            this.rbRight.Text = "Right";
            this.rbRight.UseVisualStyleBackColor = true;
            this.rbRight.CheckedChanged += new System.EventHandler(this.rbRight_CheckedChanged);
            // 
            // rbCenter
            // 
            this.rbCenter.AutoSize = true;
            this.rbCenter.Location = new System.Drawing.Point(130, 49);
            this.rbCenter.Name = "rbCenter";
            this.rbCenter.Size = new System.Drawing.Size(80, 24);
            this.rbCenter.TabIndex = 1;
            this.rbCenter.Text = "Center";
            this.rbCenter.UseVisualStyleBackColor = true;
            this.rbCenter.CheckedChanged += new System.EventHandler(this.rbCenter_CheckedChanged);
            // 
            // rbLeft
            // 
            this.rbLeft.AutoSize = true;
            this.rbLeft.Checked = true;
            this.rbLeft.Location = new System.Drawing.Point(17, 49);
            this.rbLeft.Name = "rbLeft";
            this.rbLeft.Size = new System.Drawing.Size(59, 24);
            this.rbLeft.TabIndex = 0;
            this.rbLeft.TabStop = true;
            this.rbLeft.Text = "Left";
            this.rbLeft.UseVisualStyleBackColor = true;
            this.rbLeft.CheckedChanged += new System.EventHandler(this.rbLeft_CheckedChanged);
            // 
            // Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBUnderline);
            this.Controls.Add(this.checkBItalic);
            this.Controls.Add(this.checkBBold);
            this.Controls.Add(this.cbFont);
            this.Controls.Add(this.lFont);
            this.Controls.Add(this.bColor);
            this.Controls.Add(this.lColor);
            this.Controls.Add(this.cbSize);
            this.Controls.Add(this.lSize);
            this.Controls.Add(this.tbShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Bai04";
            this.Text = "Bai04";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbShow;
        private System.Windows.Forms.Label lSize;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.Label lColor;
        private System.Windows.Forms.Button bColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox cbFont;
        private System.Windows.Forms.Label lFont;
        private System.Windows.Forms.CheckBox checkBBold;
        private System.Windows.Forms.CheckBox checkBItalic;
        private System.Windows.Forms.CheckBox checkBUnderline;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbRight;
        private System.Windows.Forms.RadioButton rbCenter;
        private System.Windows.Forms.RadioButton rbLeft;
    }
}