namespace BTTH5 {
    partial class Bai10 {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbDCustom = new System.Windows.Forms.TextBox();
            this.lDCustom = new System.Windows.Forms.Label();
            this.cbEndCap = new System.Windows.Forms.ComboBox();
            this.lEndCap = new System.Windows.Forms.Label();
            this.cbStartCap = new System.Windows.Forms.ComboBox();
            this.lStartCap = new System.Windows.Forms.Label();
            this.cbDashCap = new System.Windows.Forms.ComboBox();
            this.lDashCap = new System.Windows.Forms.Label();
            this.cbLineJoin = new System.Windows.Forms.ComboBox();
            this.lLineJoin = new System.Windows.Forms.Label();
            this.cbWidth = new System.Windows.Forms.ComboBox();
            this.lWidth = new System.Windows.Forms.Label();
            this.cbDashStyle = new System.Windows.Forms.ComboBox();
            this.lDashStyle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.tbDCustom);
            this.panel1.Controls.Add(this.lDCustom);
            this.panel1.Controls.Add(this.cbEndCap);
            this.panel1.Controls.Add(this.lEndCap);
            this.panel1.Controls.Add(this.cbStartCap);
            this.panel1.Controls.Add(this.lStartCap);
            this.panel1.Controls.Add(this.cbDashCap);
            this.panel1.Controls.Add(this.lDashCap);
            this.panel1.Controls.Add(this.cbLineJoin);
            this.panel1.Controls.Add(this.lLineJoin);
            this.panel1.Controls.Add(this.cbWidth);
            this.panel1.Controls.Add(this.lWidth);
            this.panel1.Controls.Add(this.cbDashStyle);
            this.panel1.Controls.Add(this.lDashStyle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 586);
            this.panel1.TabIndex = 0;
            // 
            // tbDCustom
            // 
            this.tbDCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDCustom.Location = new System.Drawing.Point(128, 118);
            this.tbDCustom.Name = "tbDCustom";
            this.tbDCustom.Size = new System.Drawing.Size(177, 27);
            this.tbDCustom.TabIndex = 25;
            this.tbDCustom.Text = "Ex: 5,3,1,3";
            this.tbDCustom.TextChanged += new System.EventHandler(this.tbDCustom_TextChanged);
            // 
            // lDCustom
            // 
            this.lDCustom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lDCustom.AutoSize = true;
            this.lDCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDCustom.Location = new System.Drawing.Point(21, 121);
            this.lDCustom.Name = "lDCustom";
            this.lDCustom.Size = new System.Drawing.Size(77, 20);
            this.lDCustom.TabIndex = 24;
            this.lDCustom.Text = "Custom :";
            // 
            // cbEndCap
            // 
            this.cbEndCap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbEndCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEndCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEndCap.FormattingEnabled = true;
            this.cbEndCap.Items.AddRange(new object[] {
            "NoAnchor",
            "Flat",
            "Square",
            "Round",
            "Triangle",
            "ArrowAnchor",
            "SquareAnchor",
            "RoundAnchor",
            "DiamondAnchor",
            "Custom"});
            this.cbEndCap.Location = new System.Drawing.Point(128, 499);
            this.cbEndCap.Name = "cbEndCap";
            this.cbEndCap.Size = new System.Drawing.Size(177, 28);
            this.cbEndCap.TabIndex = 23;
            this.cbEndCap.TextChanged += new System.EventHandler(this.StartEndCap_TextChange);
            // 
            // lEndCap
            // 
            this.lEndCap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lEndCap.AutoSize = true;
            this.lEndCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEndCap.Location = new System.Drawing.Point(21, 502);
            this.lEndCap.Name = "lEndCap";
            this.lEndCap.Size = new System.Drawing.Size(83, 20);
            this.lEndCap.TabIndex = 22;
            this.lEndCap.Text = "End Cap :";
            // 
            // cbStartCap
            // 
            this.cbStartCap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbStartCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStartCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStartCap.FormattingEnabled = true;
            this.cbStartCap.Items.AddRange(new object[] {
            "NoAnchor",
            "Flat",
            "Square",
            "Round",
            "Triangle",
            "ArrowAnchor",
            "SquareAnchor",
            "RoundAnchor",
            "DiamondAnchor",
            "Custom"});
            this.cbStartCap.Location = new System.Drawing.Point(128, 425);
            this.cbStartCap.Name = "cbStartCap";
            this.cbStartCap.Size = new System.Drawing.Size(177, 28);
            this.cbStartCap.TabIndex = 21;
            this.cbStartCap.TextChanged += new System.EventHandler(this.StartEndCap_TextChange);
            // 
            // lStartCap
            // 
            this.lStartCap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lStartCap.AutoSize = true;
            this.lStartCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStartCap.Location = new System.Drawing.Point(21, 428);
            this.lStartCap.Name = "lStartCap";
            this.lStartCap.Size = new System.Drawing.Size(90, 20);
            this.lStartCap.TabIndex = 20;
            this.lStartCap.Text = "Start Cap :";
            // 
            // cbDashCap
            // 
            this.cbDashCap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDashCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDashCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDashCap.FormattingEnabled = true;
            this.cbDashCap.Items.AddRange(new object[] {
            "Round",
            "Flat",
            "Triangle"});
            this.cbDashCap.Location = new System.Drawing.Point(128, 349);
            this.cbDashCap.Name = "cbDashCap";
            this.cbDashCap.Size = new System.Drawing.Size(177, 28);
            this.cbDashCap.TabIndex = 19;
            this.cbDashCap.TextChanged += new System.EventHandler(this.cbDashCap_TextChanged);
            // 
            // lDashCap
            // 
            this.lDashCap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lDashCap.AutoSize = true;
            this.lDashCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDashCap.Location = new System.Drawing.Point(21, 352);
            this.lDashCap.Name = "lDashCap";
            this.lDashCap.Size = new System.Drawing.Size(94, 20);
            this.lDashCap.TabIndex = 18;
            this.lDashCap.Text = "Dash Cap :";
            // 
            // cbLineJoin
            // 
            this.cbLineJoin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbLineJoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLineJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLineJoin.FormattingEnabled = true;
            this.cbLineJoin.Items.AddRange(new object[] {
            "Miter",
            "MiterClipped",
            "Bevel",
            "Round"});
            this.cbLineJoin.Location = new System.Drawing.Point(128, 271);
            this.cbLineJoin.Name = "cbLineJoin";
            this.cbLineJoin.Size = new System.Drawing.Size(177, 28);
            this.cbLineJoin.TabIndex = 17;
            this.cbLineJoin.TextChanged += new System.EventHandler(this.cbLineJoin_TextChanged);
            // 
            // lLineJoin
            // 
            this.lLineJoin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lLineJoin.AutoSize = true;
            this.lLineJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLineJoin.Location = new System.Drawing.Point(21, 274);
            this.lLineJoin.Name = "lLineJoin";
            this.lLineJoin.Size = new System.Drawing.Size(87, 20);
            this.lLineJoin.TabIndex = 16;
            this.lLineJoin.Text = "Line Join :";
            // 
            // cbWidth
            // 
            this.cbWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWidth.FormattingEnabled = true;
            this.cbWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20"});
            this.cbWidth.Location = new System.Drawing.Point(128, 199);
            this.cbWidth.Name = "cbWidth";
            this.cbWidth.Size = new System.Drawing.Size(177, 28);
            this.cbWidth.TabIndex = 15;
            this.cbWidth.TextChanged += new System.EventHandler(this.cbWidth_TextChanged);
            // 
            // lWidth
            // 
            this.lWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lWidth.AutoSize = true;
            this.lWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWidth.Location = new System.Drawing.Point(21, 202);
            this.lWidth.Name = "lWidth";
            this.lWidth.Size = new System.Drawing.Size(62, 20);
            this.lWidth.TabIndex = 14;
            this.lWidth.Text = "Width :";
            // 
            // cbDashStyle
            // 
            this.cbDashStyle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDashStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDashStyle.FormattingEnabled = true;
            this.cbDashStyle.Items.AddRange(new object[] {
            "Dash",
            "DashDotDot",
            "DashDot",
            "Dot",
            "Custom",
            "Solid"});
            this.cbDashStyle.Location = new System.Drawing.Point(128, 37);
            this.cbDashStyle.Name = "cbDashStyle";
            this.cbDashStyle.Size = new System.Drawing.Size(177, 28);
            this.cbDashStyle.TabIndex = 13;
            this.cbDashStyle.TextChanged += new System.EventHandler(this.cbDashStyle_TextChanged);
            // 
            // lDashStyle
            // 
            this.lDashStyle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lDashStyle.AutoSize = true;
            this.lDashStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDashStyle.Location = new System.Drawing.Point(21, 40);
            this.lDashStyle.Name = "lDashStyle";
            this.lDashStyle.Size = new System.Drawing.Size(101, 20);
            this.lDashStyle.TabIndex = 12;
            this.lDashStyle.Text = "Dash Style :";
            // 
            // Bai10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 586);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Bai10";
            this.Text = "Bai10";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Bai10_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bai10_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Bai10_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bai10_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbEndCap;
        private System.Windows.Forms.Label lEndCap;
        private System.Windows.Forms.ComboBox cbStartCap;
        private System.Windows.Forms.Label lStartCap;
        private System.Windows.Forms.ComboBox cbDashCap;
        private System.Windows.Forms.Label lDashCap;
        private System.Windows.Forms.ComboBox cbLineJoin;
        private System.Windows.Forms.Label lLineJoin;
        private System.Windows.Forms.ComboBox cbWidth;
        private System.Windows.Forms.Label lWidth;
        private System.Windows.Forms.ComboBox cbDashStyle;
        private System.Windows.Forms.Label lDashStyle;
        private System.Windows.Forms.Label lDCustom;
        private System.Windows.Forms.TextBox tbDCustom;
    }
}