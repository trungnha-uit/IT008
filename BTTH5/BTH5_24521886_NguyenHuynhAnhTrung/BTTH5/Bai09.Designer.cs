namespace BTTH5 {
    partial class Bai09 {
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSweepAngle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbStartAngle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Circle",
            "Square",
            "Rectangle",
            "Ellipse",
            "Pie",
            "Filled Circle",
            "Filled Square",
            "Filled Rectangle",
            "Filled Ellipse",
            "Filled Pie"});
            this.comboBox1.Location = new System.Drawing.Point(22, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 30);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbStartAngle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbSweepAngle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 96);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // tbSweepAngle
            // 
            this.tbSweepAngle.Location = new System.Drawing.Point(136, 49);
            this.tbSweepAngle.Name = "tbSweepAngle";
            this.tbSweepAngle.Size = new System.Drawing.Size(75, 22);
            this.tbSweepAngle.TabIndex = 1;
            this.tbSweepAngle.Text = "90";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sweep Angle:";
            // 
            // tbStartAngle
            // 
            this.tbStartAngle.Location = new System.Drawing.Point(136, 21);
            this.tbStartAngle.Name = "tbStartAngle";
            this.tbStartAngle.Size = new System.Drawing.Size(75, 22);
            this.tbStartAngle.TabIndex = 3;
            this.tbStartAngle.Text = "90";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start Angle:";
            // 
            // Bai09
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.DoubleBuffered = true;
            this.Name = "Bai09";
            this.Text = "ComboBoxTest";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Bai09_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bai09_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Bai09_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bai09_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSweepAngle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbStartAngle;
        private System.Windows.Forms.Label label2;
    }
}