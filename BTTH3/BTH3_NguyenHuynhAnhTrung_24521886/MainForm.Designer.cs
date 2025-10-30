namespace BTTH3 {
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
            this.bBai05 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bBai03
            // 
            this.bBai03.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBai03.Location = new System.Drawing.Point(342, 68);
            this.bBai03.Name = "bBai03";
            this.bBai03.Size = new System.Drawing.Size(97, 53);
            this.bBai03.TabIndex = 0;
            this.bBai03.Text = "Bài 03";
            this.bBai03.UseVisualStyleBackColor = true;
            this.bBai03.Click += new System.EventHandler(this.bBai03_Click);
            // 
            // bBai04
            // 
            this.bBai04.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBai04.Location = new System.Drawing.Point(482, 68);
            this.bBai04.Name = "bBai04";
            this.bBai04.Size = new System.Drawing.Size(97, 53);
            this.bBai04.TabIndex = 1;
            this.bBai04.Text = "Bài 04";
            this.bBai04.UseVisualStyleBackColor = true;
            this.bBai04.Click += new System.EventHandler(this.bBai04_Click);
            // 
            // bBai05
            // 
            this.bBai05.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBai05.Location = new System.Drawing.Point(342, 140);
            this.bBai05.Name = "bBai05";
            this.bBai05.Size = new System.Drawing.Size(97, 53);
            this.bBai05.TabIndex = 2;
            this.bBai05.Text = "Bài 05";
            this.bBai05.UseVisualStyleBackColor = true;
            this.bBai05.Click += new System.EventHandler(this.bBai05_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bBai05);
            this.Controls.Add(this.bBai04);
            this.Controls.Add(this.bBai03);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bBai03;
        private System.Windows.Forms.Button bBai04;
        private System.Windows.Forms.Button bBai05;
    }
}

