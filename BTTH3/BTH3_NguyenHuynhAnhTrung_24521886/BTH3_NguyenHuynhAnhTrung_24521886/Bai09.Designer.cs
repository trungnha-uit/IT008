using System.Windows.Forms;

namespace BTTH3 {
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
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.colMssv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChuyenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.cbChuyenNganh = new System.Windows.Forms.ComboBox();
            this.lbMonThamGia = new System.Windows.Forms.ListBox();
            this.bXoaMonHoc = new System.Windows.Forms.Button();
            this.bChonMonHoc = new System.Windows.Forms.Button();
            this.lbMonHoc = new System.Windows.Forms.ListBox();
            this.bXoa = new System.Windows.Forms.Button();
            this.bLuu = new System.Windows.Forms.Button();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.tbMssv = new System.Windows.Forms.TextBox();
            this.lMonThamGia = new System.Windows.Forms.Label();
            this.lGioiTinh = new System.Windows.Forms.Label();
            this.lChuyenNganh = new System.Windows.Forms.Label();
            this.lHoTen = new System.Windows.Forms.Label();
            this.lMssv = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.gbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMssv,
            this.colHoTen,
            this.colChuyenNganh,
            this.colGioiTinh,
            this.colSoMon});
            this.dgvSinhVien.Location = new System.Drawing.Point(12, 412);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.RowTemplate.Height = 24;
            this.dgvSinhVien.Size = new System.Drawing.Size(970, 227);
            this.dgvSinhVien.TabIndex = 0;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);
            // 
            // colMssv
            // 
            this.colMssv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colMssv.HeaderText = "MSSV";
            this.colMssv.MinimumWidth = 6;
            this.colMssv.Name = "colMssv";
            this.colMssv.Width = 100;
            // 
            // colHoTen
            // 
            this.colHoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colHoTen.HeaderText = "Họ Tên";
            this.colHoTen.MinimumWidth = 6;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Width = 200;
            // 
            // colChuyenNganh
            // 
            this.colChuyenNganh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colChuyenNganh.HeaderText = "Chuyên Ngành";
            this.colChuyenNganh.MinimumWidth = 6;
            this.colChuyenNganh.Name = "colChuyenNganh";
            this.colChuyenNganh.Width = 175;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colGioiTinh.HeaderText = "Giới Tính";
            this.colGioiTinh.MinimumWidth = 6;
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Width = 75;
            // 
            // colMonThamGia
            // 
            this.colSoMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSoMon.HeaderText = "Môn Tham Gia";
            this.colSoMon.MinimumWidth = 6;
            this.colSoMon.Name = "colSoMon";
            this.colSoMon.Width = 125;
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.rbNu);
            this.gbThongTin.Controls.Add(this.rbNam);
            this.gbThongTin.Controls.Add(this.cbChuyenNganh);
            this.gbThongTin.Controls.Add(this.lbMonThamGia);
            this.gbThongTin.Controls.Add(this.bXoaMonHoc);
            this.gbThongTin.Controls.Add(this.bChonMonHoc);
            this.gbThongTin.Controls.Add(this.lbMonHoc);
            this.gbThongTin.Controls.Add(this.bXoa);
            this.gbThongTin.Controls.Add(this.bLuu);
            this.gbThongTin.Controls.Add(this.tbHoTen);
            this.gbThongTin.Controls.Add(this.tbMssv);
            this.gbThongTin.Controls.Add(this.lMonThamGia);
            this.gbThongTin.Controls.Add(this.lGioiTinh);
            this.gbThongTin.Controls.Add(this.lChuyenNganh);
            this.gbThongTin.Controls.Add(this.lHoTen);
            this.gbThongTin.Controls.Add(this.lMssv);
            this.gbThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTin.Location = new System.Drawing.Point(12, 13);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(970, 382);
            this.gbThongTin.TabIndex = 1;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tinh sinh viên";
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(438, 139);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(48, 22);
            this.rbNu.TabIndex = 18;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(350, 139);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(61, 22);
            this.rbNam.TabIndex = 17;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // cbChuyenNganh
            // 
            this.cbChuyenNganh.FormattingEnabled = true;
            this.cbChuyenNganh.Items.AddRange(new object[] {
            "An Toàn Thông Tin",
            "Hệ Thống Thông Tin",
            "Trí Tuệ Nhân Tạo",
            "Kỹ Thuật Phần Mềm",
            "Truyền Thông Đa Phương Tiện",
            "Công Nghệ Thông Tin",
            "Khoa Học Máy Tính",
            "Khoa Học Dữ Liệu",
            "Kỹ Thuật Máy Tính",
            "Thiết Kế Vi Mạch"});
            this.cbChuyenNganh.Location = new System.Drawing.Point(350, 94);
            this.cbChuyenNganh.Name = "cbChuyenNganh";
            this.cbChuyenNganh.Size = new System.Drawing.Size(347, 26);
            this.cbChuyenNganh.TabIndex = 16;
            this.cbChuyenNganh.SelectedIndexChanged += new System.EventHandler(this.cbChuyenNganh_SelectedIndexChanged);
            // 
            // lbMonThamGia
            // 
            this.lbMonThamGia.FormattingEnabled = true;
            this.lbMonThamGia.ItemHeight = 18;
            this.lbMonThamGia.Location = new System.Drawing.Point(561, 211);
            this.lbMonThamGia.Name = "lbMonThamGia";
            this.lbMonThamGia.Size = new System.Drawing.Size(286, 112);
            this.lbMonThamGia.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbMonThamGia.TabIndex = 15;
            // 
            // bXoaMonHoc
            // 
            this.bXoaMonHoc.Location = new System.Drawing.Point(492, 267);
            this.bXoaMonHoc.Name = "bXoaMonHoc";
            this.bXoaMonHoc.Size = new System.Drawing.Size(63, 37);
            this.bXoaMonHoc.TabIndex = 14;
            this.bXoaMonHoc.Text = "<";
            this.bXoaMonHoc.UseVisualStyleBackColor = true;
            this.bXoaMonHoc.Click += new System.EventHandler(this.bXoaMonHoc_Click);
            // 
            // bChonMonHoc
            // 
            this.bChonMonHoc.Location = new System.Drawing.Point(492, 225);
            this.bChonMonHoc.Name = "bChonMonHoc";
            this.bChonMonHoc.Size = new System.Drawing.Size(63, 37);
            this.bChonMonHoc.TabIndex = 13;
            this.bChonMonHoc.Text = ">";
            this.bChonMonHoc.UseVisualStyleBackColor = true;
            this.bChonMonHoc.Click += new System.EventHandler(this.bChonMonHoc_Click);
            // 
            // lbMonHoc
            // 
            this.lbMonHoc.FormattingEnabled = true;
            this.lbMonHoc.ItemHeight = 18;
            this.lbMonHoc.Items.AddRange(new object[] {
            "Nhập Môn Lập Trình",
            "Giải Tích",
            "Đại Số Tuyến Tính",
            "Anh Văn",
            "Cơ Sở Dữ Liệu ",
            "Triết Học",
            "Tư Tưởng Hồ Chí Minh",
            "DSA",
            "OOP"});
            this.lbMonHoc.Location = new System.Drawing.Point(200, 211);
            this.lbMonHoc.Name = "lbMonHoc";
            this.lbMonHoc.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbMonHoc.Size = new System.Drawing.Size(286, 112);
            this.lbMonHoc.TabIndex = 12;
            // 
            // bXoa
            // 
            this.bXoa.Location = new System.Drawing.Point(561, 337);
            this.bXoa.Name = "bXoa";
            this.bXoa.Size = new System.Drawing.Size(121, 30);
            this.bXoa.TabIndex = 11;
            this.bXoa.Text = "Xóa Chọn";
            this.bXoa.UseVisualStyleBackColor = true;
            this.bXoa.Click += new System.EventHandler(this.bXoa_Click);
            // 
            // bLuu
            // 
            this.bLuu.Location = new System.Drawing.Point(336, 337);
            this.bLuu.Name = "bLuu";
            this.bLuu.Size = new System.Drawing.Size(150, 30);
            this.bLuu.TabIndex = 10;
            this.bLuu.Text = "Lưu Thông Tin";
            this.bLuu.UseVisualStyleBackColor = true;
            this.bLuu.Click += new System.EventHandler(this.bLuu_Click);
            // 
            // tbHoTen
            // 
            this.tbHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHoTen.Location = new System.Drawing.Point(350, 57);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(347, 24);
            this.tbHoTen.TabIndex = 6;
            // 
            // tbMssv
            // 
            this.tbMssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMssv.Location = new System.Drawing.Point(350, 17);
            this.tbMssv.Name = "tbMssv";
            this.tbMssv.Size = new System.Drawing.Size(205, 24);
            this.tbMssv.TabIndex = 5;
            // 
            // lMonThamGia
            // 
            this.lMonThamGia.AutoSize = true;
            this.lMonThamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMonThamGia.Location = new System.Drawing.Point(197, 177);
            this.lMonThamGia.Name = "lMonThamGia";
            this.lMonThamGia.Size = new System.Drawing.Size(210, 18);
            this.lMonThamGia.TabIndex = 4;
            this.lMonThamGia.Text = "Chọn Các Môn Học Tham Gia";
            // 
            // lGioiTinh
            // 
            this.lGioiTinh.AutoSize = true;
            this.lGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGioiTinh.Location = new System.Drawing.Point(197, 139);
            this.lGioiTinh.Name = "lGioiTinh";
            this.lGioiTinh.Size = new System.Drawing.Size(67, 18);
            this.lGioiTinh.TabIndex = 3;
            this.lGioiTinh.Text = "Giới Tính";
            // 
            // lChuyenNganh
            // 
            this.lChuyenNganh.AutoSize = true;
            this.lChuyenNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lChuyenNganh.Location = new System.Drawing.Point(197, 97);
            this.lChuyenNganh.Name = "lChuyenNganh";
            this.lChuyenNganh.Size = new System.Drawing.Size(105, 18);
            this.lChuyenNganh.TabIndex = 2;
            this.lChuyenNganh.Text = "Chuyên Ngành";
            // 
            // lHoTen
            // 
            this.lHoTen.AutoSize = true;
            this.lHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHoTen.Location = new System.Drawing.Point(197, 60);
            this.lHoTen.Name = "lHoTen";
            this.lHoTen.Size = new System.Drawing.Size(57, 18);
            this.lHoTen.TabIndex = 1;
            this.lHoTen.Text = "Họ Tên";
            // 
            // lMssv
            // 
            this.lMssv.AutoSize = true;
            this.lMssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMssv.Location = new System.Drawing.Point(197, 20);
            this.lMssv.Name = "lMssv";
            this.lMssv.Size = new System.Drawing.Size(94, 18);
            this.lMssv.TabIndex = 0;
            this.lMssv.Text = "Mã Sinh Viên";
            // 
            // Bai09
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 651);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.dgvSinhVien);
            this.Name = "Bai09";
            this.Text = "Nhập Liệu Sinh Viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMssv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChuyenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoMon;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Label lMssv;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button bLuu;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.TextBox tbMssv;
        private System.Windows.Forms.Label lMonThamGia;
        private System.Windows.Forms.Label lGioiTinh;
        private System.Windows.Forms.Label lChuyenNganh;
        private System.Windows.Forms.Label lHoTen;
        private System.Windows.Forms.ListBox lbMonThamGia;
        private System.Windows.Forms.Button bXoaMonHoc;
        private System.Windows.Forms.Button bChonMonHoc;
        private System.Windows.Forms.ListBox lbMonHoc;
        private System.Windows.Forms.Button bXoa;
        private System.Windows.Forms.ComboBox cbChuyenNganh;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
    }
}