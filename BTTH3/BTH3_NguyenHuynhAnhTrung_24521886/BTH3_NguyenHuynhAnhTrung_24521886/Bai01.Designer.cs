namespace BTTH3 {
    partial class Bai01 {
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
            this.lbEventLog = new System.Windows.Forms.ListBox();
            this.bExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbEventLog
            // 
            this.lbEventLog.FormattingEnabled = true;
            this.lbEventLog.ItemHeight = 16;
            this.lbEventLog.Location = new System.Drawing.Point(12, 12);
            this.lbEventLog.Name = "lbEventLog";
            this.lbEventLog.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbEventLog.Size = new System.Drawing.Size(535, 420);
            this.lbEventLog.TabIndex = 0;
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(611, 167);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(141, 52);
            this.bExit.TabIndex = 3;
            this.bExit.Text = "Thoát";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.lbEventLog);
            this.Name = "Bai01";
            this.Text = "Form LIFETIME";
            this.Activated += new System.EventHandler(this.Bai01_Activated);
            this.Deactivate += new System.EventHandler(this.Bai01_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai01_FormClosing);
            this.Load += new System.EventHandler(this.Bai01_Load);
            this.Shown += new System.EventHandler(this.Bai01_Shown);
            this.Click += new System.EventHandler(this.Bai01_Click);
            this.Move += new System.EventHandler(this.Bai01_Move);
            this.Resize += new System.EventHandler(this.Bai01_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbEventLog;
        private System.Windows.Forms.Button bExit;
    }
}