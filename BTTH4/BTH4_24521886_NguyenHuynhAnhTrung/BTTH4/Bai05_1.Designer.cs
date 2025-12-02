namespace BTTH4 {
    partial class Bai05_1 {
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
            this.lMSSV = new System.Windows.Forms.Label();
            this.tbMSSV = new System.Windows.Forms.TextBox();
            this.lTenSV = new System.Windows.Forms.Label();
            this.tbTenSV = new System.Windows.Forms.TextBox();
            this.lKhoa = new System.Windows.Forms.Label();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.lDiemTB = new System.Windows.Forms.Label();
            this.tbDiemTB = new System.Windows.Forms.TextBox();
            this.bThemMoi = new System.Windows.Forms.Button();
            this.bThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lMSSV
            // 
            this.lMSSV.AutoSize = true;
            this.lMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMSSV.Location = new System.Drawing.Point(44, 68);
            this.lMSSV.Name = "lMSSV";
            this.lMSSV.Size = new System.Drawing.Size(133, 20);
            this.lMSSV.TabIndex = 0;
            this.lMSSV.Text = "Mã Số Sinh Viên";
            // 
            // tbMSSV
            // 
            this.tbMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMSSV.Location = new System.Drawing.Point(196, 61);
            this.tbMSSV.MaxLength = 20;
            this.tbMSSV.Name = "tbMSSV";
            this.tbMSSV.Size = new System.Drawing.Size(256, 27);
            this.tbMSSV.TabIndex = 1;
            // 
            // lTenSV
            // 
            this.lTenSV.AutoSize = true;
            this.lTenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTenSV.Location = new System.Drawing.Point(44, 141);
            this.lTenSV.Name = "lTenSV";
            this.lTenSV.Size = new System.Drawing.Size(113, 20);
            this.lTenSV.TabIndex = 2;
            this.lTenSV.Text = "Tên Sinh Viên";
            // 
            // tbTenSV
            // 
            this.tbTenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenSV.Location = new System.Drawing.Point(196, 134);
            this.tbTenSV.Name = "tbTenSV";
            this.tbTenSV.Size = new System.Drawing.Size(386, 27);
            this.tbTenSV.TabIndex = 3;
            // 
            // lKhoa
            // 
            this.lKhoa.AutoSize = true;
            this.lKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lKhoa.Location = new System.Drawing.Point(44, 213);
            this.lKhoa.Name = "lKhoa";
            this.lKhoa.Size = new System.Drawing.Size(47, 20);
            this.lKhoa.TabIndex = 4;
            this.lKhoa.Text = "Khoa";
            // 
            // cbKhoa
            // 
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoa.Items.AddRange(new object[] {
            "Công nghệ phần mềm",
            "Công nghệ thông tin",
            "Khoa học máy tính",
            "Hệ thống thông tin",
            "Kỹ thuật máy tính"});
            this.cbKhoa.Location = new System.Drawing.Point(196, 209);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(386, 28);
            this.cbKhoa.TabIndex = 5;
            // 
            // lDiemTB
            // 
            this.lDiemTB.AutoSize = true;
            this.lDiemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDiemTB.Location = new System.Drawing.Point(44, 273);
            this.lDiemTB.Name = "lDiemTB";
            this.lDiemTB.Size = new System.Drawing.Size(75, 20);
            this.lDiemTB.TabIndex = 6;
            this.lDiemTB.Text = "Điểm TB";
            // 
            // tbDiemTB
            // 
            this.tbDiemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiemTB.Location = new System.Drawing.Point(196, 266);
            this.tbDiemTB.Name = "tbDiemTB";
            this.tbDiemTB.Size = new System.Drawing.Size(146, 27);
            this.tbDiemTB.TabIndex = 7;
            // 
            // bThemMoi
            // 
            this.bThemMoi.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.bThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bThemMoi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bThemMoi.Location = new System.Drawing.Point(304, 347);
            this.bThemMoi.Name = "bThemMoi";
            this.bThemMoi.Size = new System.Drawing.Size(148, 40);
            this.bThemMoi.TabIndex = 8;
            this.bThemMoi.Text = "Thêm Mới";
            this.bThemMoi.UseVisualStyleBackColor = false;
            this.bThemMoi.Click += new System.EventHandler(this.bThemMoi_Click);
            // 
            // bThoat
            // 
            this.bThoat.BackColor = System.Drawing.Color.Tomato;
            this.bThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bThoat.Location = new System.Drawing.Point(463, 347);
            this.bThoat.Name = "bThoat";
            this.bThoat.Size = new System.Drawing.Size(119, 40);
            this.bThoat.TabIndex = 9;
            this.bThoat.Text = "Thoát";
            this.bThoat.UseVisualStyleBackColor = false;
            this.bThoat.Click += new System.EventHandler(this.bThoat_Click);
            // 
            // Bai05_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 405);
            this.Controls.Add(this.bThoat);
            this.Controls.Add(this.bThemMoi);
            this.Controls.Add(this.tbDiemTB);
            this.Controls.Add(this.lDiemTB);
            this.Controls.Add(this.cbKhoa);
            this.Controls.Add(this.lKhoa);
            this.Controls.Add(this.tbTenSV);
            this.Controls.Add(this.lTenSV);
            this.Controls.Add(this.tbMSSV);
            this.Controls.Add(this.lMSSV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Bai05_1";
            this.Text = "Thêm Sinh Viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lMSSV;
        private System.Windows.Forms.TextBox tbMSSV;
        private System.Windows.Forms.Label lTenSV;
        private System.Windows.Forms.TextBox tbTenSV;
        private System.Windows.Forms.Label lKhoa;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label lDiemTB;
        private System.Windows.Forms.TextBox tbDiemTB;
        private System.Windows.Forms.Button bThemMoi;
        private System.Windows.Forms.Button bThoat;
    }
}