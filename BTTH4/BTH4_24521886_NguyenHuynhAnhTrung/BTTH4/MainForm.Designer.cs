namespace BTTH4 {
    partial class MainForm {
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
            this.bBai03 = new System.Windows.Forms.Button();
            this.bBai04 = new System.Windows.Forms.Button();
            this.bBai06 = new System.Windows.Forms.Button();
            this.bBai05 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bBai03
            // 
            this.bBai03.Location = new System.Drawing.Point(95, 66);
            this.bBai03.Name = "bBai03";
            this.bBai03.Size = new System.Drawing.Size(108, 60);
            this.bBai03.TabIndex = 0;
            this.bBai03.Text = "Bài 03";
            this.bBai03.UseVisualStyleBackColor = true;
            this.bBai03.Click += new System.EventHandler(this.bBai03_Click);
            // 
            // bBai04
            // 
            this.bBai04.Location = new System.Drawing.Point(297, 66);
            this.bBai04.Name = "bBai04";
            this.bBai04.Size = new System.Drawing.Size(108, 60);
            this.bBai04.TabIndex = 1;
            this.bBai04.Text = "Bài 04";
            this.bBai04.UseVisualStyleBackColor = true;
            this.bBai04.Click += new System.EventHandler(this.bBai04_Click);
            // 
            // bBai06
            // 
            this.bBai06.Location = new System.Drawing.Point(297, 173);
            this.bBai06.Name = "bBai06";
            this.bBai06.Size = new System.Drawing.Size(108, 60);
            this.bBai06.TabIndex = 3;
            this.bBai06.Text = "Bài 06";
            this.bBai06.UseVisualStyleBackColor = true;
            this.bBai06.Click += new System.EventHandler(this.bBai06_Click);
            // 
            // bBai05
            // 
            this.bBai05.Location = new System.Drawing.Point(95, 173);
            this.bBai05.Name = "bBai05";
            this.bBai05.Size = new System.Drawing.Size(108, 60);
            this.bBai05.TabIndex = 2;
            this.bBai05.Text = "Bài 05";
            this.bBai05.UseVisualStyleBackColor = true;
            this.bBai05.Click += new System.EventHandler(this.bBai05_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 303);
            this.Controls.Add(this.bBai05);
            this.Controls.Add(this.bBai06);
            this.Controls.Add(this.bBai04);
            this.Controls.Add(this.bBai03);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bBai03;
        private System.Windows.Forms.Button bBai04;
        private System.Windows.Forms.Button bBai06;
        private System.Windows.Forms.Button bBai05;
    }
}

