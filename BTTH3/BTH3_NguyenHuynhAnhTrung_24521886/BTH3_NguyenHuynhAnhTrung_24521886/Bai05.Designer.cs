namespace BTTH3 {
    partial class Bai05 {
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
            this.components = new System.ComponentModel.Container();
            this.lNumber1 = new System.Windows.Forms.Label();
            this.lNumber2 = new System.Windows.Forms.Label();
            this.tbNumber1 = new System.Windows.Forms.TextBox();
            this.tbNumber2 = new System.Windows.Forms.TextBox();
            this.bPlus = new System.Windows.Forms.Button();
            this.bSub = new System.Windows.Forms.Button();
            this.bMul = new System.Windows.Forms.Button();
            this.bDiv = new System.Windows.Forms.Button();
            this.lAnswer = new System.Windows.Forms.Label();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbCal = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbCal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lNumber1
            // 
            this.lNumber1.AutoSize = true;
            this.lNumber1.Location = new System.Drawing.Point(101, 56);
            this.lNumber1.Name = "lNumber1";
            this.lNumber1.Size = new System.Drawing.Size(65, 16);
            this.lNumber1.TabIndex = 0;
            this.lNumber1.Text = "Number 1";
            // 
            // lNumber2
            // 
            this.lNumber2.AutoSize = true;
            this.lNumber2.Location = new System.Drawing.Point(101, 100);
            this.lNumber2.Name = "lNumber2";
            this.lNumber2.Size = new System.Drawing.Size(65, 16);
            this.lNumber2.TabIndex = 1;
            this.lNumber2.Text = "Number 2";
            // 
            // tbNumber1
            // 
            this.tbNumber1.Location = new System.Drawing.Point(207, 53);
            this.tbNumber1.Name = "tbNumber1";
            this.tbNumber1.Size = new System.Drawing.Size(306, 22);
            this.tbNumber1.TabIndex = 2;
            this.tbNumber1.TextChanged += new System.EventHandler(this.tbNumber1_TextChanged);
            // 
            // tbNumber2
            // 
            this.tbNumber2.Location = new System.Drawing.Point(207, 94);
            this.tbNumber2.Name = "tbNumber2";
            this.tbNumber2.Size = new System.Drawing.Size(306, 22);
            this.tbNumber2.TabIndex = 3;
            this.tbNumber2.TextChanged += new System.EventHandler(this.tbNumber2_TextChanged);
            // 
            // bPlus
            // 
            this.bPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPlus.Location = new System.Drawing.Point(20, 14);
            this.bPlus.Name = "bPlus";
            this.bPlus.Size = new System.Drawing.Size(51, 47);
            this.bPlus.TabIndex = 4;
            this.bPlus.Text = "+";
            this.bPlus.UseVisualStyleBackColor = true;
            this.bPlus.Click += new System.EventHandler(this.bPlus_Click);
            // 
            // bSub
            // 
            this.bSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSub.Location = new System.Drawing.Point(111, 14);
            this.bSub.Name = "bSub";
            this.bSub.Size = new System.Drawing.Size(51, 47);
            this.bSub.TabIndex = 5;
            this.bSub.Text = "-";
            this.bSub.UseVisualStyleBackColor = true;
            this.bSub.Click += new System.EventHandler(this.bSub_Click);
            // 
            // bMul
            // 
            this.bMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMul.Location = new System.Drawing.Point(231, 14);
            this.bMul.Name = "bMul";
            this.bMul.Size = new System.Drawing.Size(51, 47);
            this.bMul.TabIndex = 6;
            this.bMul.Text = "x";
            this.bMul.UseVisualStyleBackColor = true;
            this.bMul.Click += new System.EventHandler(this.bMul_Click);
            // 
            // bDiv
            // 
            this.bDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDiv.Location = new System.Drawing.Point(358, 14);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(51, 47);
            this.bDiv.TabIndex = 7;
            this.bDiv.Text = "/";
            this.bDiv.UseVisualStyleBackColor = true;
            this.bDiv.Click += new System.EventHandler(this.bDiv_Click);
            // 
            // lAnswer
            // 
            this.lAnswer.AutoSize = true;
            this.lAnswer.Location = new System.Drawing.Point(101, 337);
            this.lAnswer.Name = "lAnswer";
            this.lAnswer.Size = new System.Drawing.Size(51, 16);
            this.lAnswer.TabIndex = 8;
            this.lAnswer.Text = "Answer";
            // 
            // tbAnswer
            // 
            this.tbAnswer.Location = new System.Drawing.Point(207, 331);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.ReadOnly = true;
            this.tbAnswer.Size = new System.Drawing.Size(306, 22);
            this.tbAnswer.TabIndex = 9;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gbCal
            // 
            this.gbCal.Controls.Add(this.bDiv);
            this.gbCal.Controls.Add(this.bMul);
            this.gbCal.Controls.Add(this.bSub);
            this.gbCal.Controls.Add(this.bPlus);
            this.gbCal.Location = new System.Drawing.Point(73, 162);
            this.gbCal.Name = "gbCal";
            this.gbCal.Size = new System.Drawing.Size(439, 77);
            this.gbCal.TabIndex = 10;
            this.gbCal.TabStop = false;
            // 
            // Bai05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbCal);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.lAnswer);
            this.Controls.Add(this.tbNumber2);
            this.Controls.Add(this.tbNumber1);
            this.Controls.Add(this.lNumber2);
            this.Controls.Add(this.lNumber1);
            this.Name = "Bai05";
            this.Text = "Simple Calculator";
            this.Load += new System.EventHandler(this.Bai05_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbCal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNumber1;
        private System.Windows.Forms.Label lNumber2;
        private System.Windows.Forms.TextBox tbNumber1;
        private System.Windows.Forms.TextBox tbNumber2;
        private System.Windows.Forms.Button bPlus;
        private System.Windows.Forms.Button bSub;
        private System.Windows.Forms.Button bMul;
        private System.Windows.Forms.Button bDiv;
        private System.Windows.Forms.Label lAnswer;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gbCal;
    }
}