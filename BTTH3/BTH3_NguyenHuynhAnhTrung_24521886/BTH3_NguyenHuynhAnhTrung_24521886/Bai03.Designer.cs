namespace BTTH3 {
    partial class Bai03 {
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
            this.bChangeColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bChangeColor
            // 
            this.bChangeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bChangeColor.Location = new System.Drawing.Point(327, 148);
            this.bChangeColor.Name = "bChangeColor";
            this.bChangeColor.Size = new System.Drawing.Size(136, 72);
            this.bChangeColor.TabIndex = 0;
            this.bChangeColor.Text = "Change Color";
            this.bChangeColor.UseVisualStyleBackColor = true;
            this.bChangeColor.Click += new System.EventHandler(this.bChangeColor_Click);
            // 
            // Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bChangeColor);
            this.Name = "Bai03";
            this.Text = "Button Change Color";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bChangeColor;
    }
}