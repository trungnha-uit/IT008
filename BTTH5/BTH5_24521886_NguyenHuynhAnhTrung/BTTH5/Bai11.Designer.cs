namespace BTTH5 {
    partial class Bai11 {
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
            this.gbBrushes = new System.Windows.Forms.GroupBox();
            this.rbLinearGradientBrush = new System.Windows.Forms.RadioButton();
            this.rbTextureBrush = new System.Windows.Forms.RadioButton();
            this.rbHatchBrush = new System.Windows.Forms.RadioButton();
            this.rbSolidBrush = new System.Windows.Forms.RadioButton();
            this.gbPen = new System.Windows.Forms.GroupBox();
            this.bPenColor = new System.Windows.Forms.Button();
            this.tbWidthPen = new System.Windows.Forms.TextBox();
            this.lWidthPen = new System.Windows.Forms.Label();
            this.gbShapes = new System.Windows.Forms.GroupBox();
            this.rbEllipse = new System.Windows.Forms.RadioButton();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.gbBrushes.SuspendLayout();
            this.gbPen.SuspendLayout();
            this.gbShapes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.gbBrushes);
            this.panel1.Controls.Add(this.gbPen);
            this.panel1.Controls.Add(this.gbShapes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 651);
            this.panel1.TabIndex = 0;
            // 
            // gbBrushes
            // 
            this.gbBrushes.Controls.Add(this.rbLinearGradientBrush);
            this.gbBrushes.Controls.Add(this.rbTextureBrush);
            this.gbBrushes.Controls.Add(this.rbHatchBrush);
            this.gbBrushes.Controls.Add(this.rbSolidBrush);
            this.gbBrushes.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbBrushes.Location = new System.Drawing.Point(9, 364);
            this.gbBrushes.Name = "gbBrushes";
            this.gbBrushes.Size = new System.Drawing.Size(242, 252);
            this.gbBrushes.TabIndex = 4;
            this.gbBrushes.TabStop = false;
            this.gbBrushes.Text = "Brushes";
            // 
            // rbLinearGradientBrush
            // 
            this.rbLinearGradientBrush.AutoSize = true;
            this.rbLinearGradientBrush.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLinearGradientBrush.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbLinearGradientBrush.Location = new System.Drawing.Point(21, 197);
            this.rbLinearGradientBrush.Name = "rbLinearGradientBrush";
            this.rbLinearGradientBrush.Size = new System.Drawing.Size(197, 26);
            this.rbLinearGradientBrush.TabIndex = 3;
            this.rbLinearGradientBrush.TabStop = true;
            this.rbLinearGradientBrush.Text = "LinearGradientBrush";
            this.rbLinearGradientBrush.UseVisualStyleBackColor = true;
            this.rbLinearGradientBrush.CheckedChanged += new System.EventHandler(this.rbLinearGradientBrush_CheckedChanged);
            // 
            // rbTextureBrush
            // 
            this.rbTextureBrush.AutoSize = true;
            this.rbTextureBrush.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTextureBrush.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbTextureBrush.Location = new System.Drawing.Point(21, 142);
            this.rbTextureBrush.Name = "rbTextureBrush";
            this.rbTextureBrush.Size = new System.Drawing.Size(140, 26);
            this.rbTextureBrush.TabIndex = 2;
            this.rbTextureBrush.TabStop = true;
            this.rbTextureBrush.Text = "TextureBrush";
            this.rbTextureBrush.UseVisualStyleBackColor = true;
            this.rbTextureBrush.CheckedChanged += new System.EventHandler(this.rbTextureBrush_CheckedChanged);
            // 
            // rbHatchBrush
            // 
            this.rbHatchBrush.AutoSize = true;
            this.rbHatchBrush.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHatchBrush.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbHatchBrush.Location = new System.Drawing.Point(21, 89);
            this.rbHatchBrush.Name = "rbHatchBrush";
            this.rbHatchBrush.Size = new System.Drawing.Size(125, 26);
            this.rbHatchBrush.TabIndex = 1;
            this.rbHatchBrush.TabStop = true;
            this.rbHatchBrush.Text = "HatchBrush";
            this.rbHatchBrush.UseVisualStyleBackColor = true;
            this.rbHatchBrush.CheckedChanged += new System.EventHandler(this.rbHatchBrush_CheckedChanged);
            // 
            // rbSolidBrush
            // 
            this.rbSolidBrush.AutoSize = true;
            this.rbSolidBrush.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSolidBrush.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbSolidBrush.Location = new System.Drawing.Point(21, 40);
            this.rbSolidBrush.Name = "rbSolidBrush";
            this.rbSolidBrush.Size = new System.Drawing.Size(118, 26);
            this.rbSolidBrush.TabIndex = 0;
            this.rbSolidBrush.TabStop = true;
            this.rbSolidBrush.Text = "SolidBrush";
            this.rbSolidBrush.UseVisualStyleBackColor = true;
            this.rbSolidBrush.CheckedChanged += new System.EventHandler(this.rbSolidBrush_CheckedChanged);
            // 
            // gbPen
            // 
            this.gbPen.Controls.Add(this.bPenColor);
            this.gbPen.Controls.Add(this.tbWidthPen);
            this.gbPen.Controls.Add(this.lWidthPen);
            this.gbPen.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbPen.Location = new System.Drawing.Point(12, 211);
            this.gbPen.Name = "gbPen";
            this.gbPen.Size = new System.Drawing.Size(239, 117);
            this.gbPen.TabIndex = 3;
            this.gbPen.TabStop = false;
            this.gbPen.Text = "Pen";
            // 
            // bPenColor
            // 
            this.bPenColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPenColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bPenColor.Location = new System.Drawing.Point(55, 69);
            this.bPenColor.Name = "bPenColor";
            this.bPenColor.Size = new System.Drawing.Size(106, 27);
            this.bPenColor.TabIndex = 2;
            this.bPenColor.Text = "Color...";
            this.bPenColor.UseVisualStyleBackColor = true;
            this.bPenColor.Click += new System.EventHandler(this.bPenColor_Click);
            // 
            // tbWidthPen
            // 
            this.tbWidthPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWidthPen.Location = new System.Drawing.Point(99, 25);
            this.tbWidthPen.Name = "tbWidthPen";
            this.tbWidthPen.Size = new System.Drawing.Size(85, 27);
            this.tbWidthPen.TabIndex = 1;
            this.tbWidthPen.Text = "1";
            this.tbWidthPen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbWidthPen.TextChanged += new System.EventHandler(this.tbWidthPen_TextChanged);
            // 
            // lWidthPen
            // 
            this.lWidthPen.AutoSize = true;
            this.lWidthPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWidthPen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lWidthPen.Location = new System.Drawing.Point(17, 28);
            this.lWidthPen.Name = "lWidthPen";
            this.lWidthPen.Size = new System.Drawing.Size(57, 20);
            this.lWidthPen.TabIndex = 0;
            this.lWidthPen.Text = "Width:";
            // 
            // gbShapes
            // 
            this.gbShapes.Controls.Add(this.rbEllipse);
            this.gbShapes.Controls.Add(this.rbRectangle);
            this.gbShapes.Controls.Add(this.rbLine);
            this.gbShapes.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbShapes.Location = new System.Drawing.Point(12, 29);
            this.gbShapes.Name = "gbShapes";
            this.gbShapes.Size = new System.Drawing.Size(239, 145);
            this.gbShapes.TabIndex = 2;
            this.gbShapes.TabStop = false;
            this.gbShapes.Text = "Shapes";
            // 
            // rbEllipse
            // 
            this.rbEllipse.AutoSize = true;
            this.rbEllipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEllipse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbEllipse.Location = new System.Drawing.Point(18, 94);
            this.rbEllipse.Name = "rbEllipse";
            this.rbEllipse.Size = new System.Drawing.Size(84, 26);
            this.rbEllipse.TabIndex = 3;
            this.rbEllipse.TabStop = true;
            this.rbEllipse.Text = "Ellipse";
            this.rbEllipse.UseVisualStyleBackColor = true;
            this.rbEllipse.CheckedChanged += new System.EventHandler(this.rbEllipse_CheckedChanged);
            // 
            // rbRectangle
            // 
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRectangle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbRectangle.Location = new System.Drawing.Point(18, 62);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(112, 26);
            this.rbRectangle.TabIndex = 2;
            this.rbRectangle.TabStop = true;
            this.rbRectangle.Text = "Rectangle";
            this.rbRectangle.UseVisualStyleBackColor = true;
            this.rbRectangle.CheckedChanged += new System.EventHandler(this.rbRectangle_CheckedChanged);
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbLine.Location = new System.Drawing.Point(18, 30);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(65, 26);
            this.rbLine.TabIndex = 1;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "Line";
            this.rbLine.UseVisualStyleBackColor = true;
            this.rbLine.CheckedChanged += new System.EventHandler(this.rbLine_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Bai11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 651);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Bai11";
            this.Text = "Bai11";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Bai11_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bai11_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Bai11_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bai11_MouseUp);
            this.Resize += new System.EventHandler(this.Bai11_Resize);
            this.panel1.ResumeLayout(false);
            this.gbBrushes.ResumeLayout(false);
            this.gbBrushes.PerformLayout();
            this.gbPen.ResumeLayout(false);
            this.gbPen.PerformLayout();
            this.gbShapes.ResumeLayout(false);
            this.gbShapes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbBrushes;
        private System.Windows.Forms.RadioButton rbLinearGradientBrush;
        private System.Windows.Forms.RadioButton rbTextureBrush;
        private System.Windows.Forms.RadioButton rbHatchBrush;
        private System.Windows.Forms.RadioButton rbSolidBrush;
        private System.Windows.Forms.GroupBox gbPen;
        private System.Windows.Forms.Button bPenColor;
        private System.Windows.Forms.TextBox tbWidthPen;
        private System.Windows.Forms.Label lWidthPen;
        private System.Windows.Forms.GroupBox gbShapes;
        private System.Windows.Forms.RadioButton rbEllipse;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}