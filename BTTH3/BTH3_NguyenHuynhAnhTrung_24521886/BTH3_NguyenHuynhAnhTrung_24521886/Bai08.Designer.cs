using System;

namespace BTTH3 {
    partial class Bai08 {
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
            this.lShow = new System.Windows.Forms.Label();
            this.lSoTaiKhoan = new System.Windows.Forms.Label();
            this.tbSoTaiKhoan = new System.Windows.Forms.TextBox();
            this.tbTenKhachHang = new System.Windows.Forms.TextBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbSoTien = new System.Windows.Forms.TextBox();
            this.lTenKhachHang = new System.Windows.Forms.Label();
            this.lDiaChi = new System.Windows.Forms.Label();
            this.lSoTien = new System.Windows.Forms.Label();
            this.bAddUpdate = new System.Windows.Forms.Button();
            this.bDel = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.lSum = new System.Windows.Forms.Label();
            this.tbSumTien = new System.Windows.Forms.TextBox();
            this.lvKhachHang = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lShow
            // 
            this.lShow.AutoSize = true;
            this.lShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShow.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lShow.Location = new System.Drawing.Point(92, 9);
            this.lShow.Name = "lShow";
            this.lShow.Size = new System.Drawing.Size(763, 54);
            this.lShow.TabIndex = 0;
            this.lShow.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            // 
            // lSoTaiKhoan
            // 
            this.lSoTaiKhoan.AutoSize = true;
            this.lSoTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSoTaiKhoan.Location = new System.Drawing.Point(163, 87);
            this.lSoTaiKhoan.Name = "lSoTaiKhoan";
            this.lSoTaiKhoan.Size = new System.Drawing.Size(110, 22);
            this.lSoTaiKhoan.TabIndex = 1;
            this.lSoTaiKhoan.Text = "Số tài khoản";
            // 
            // tbSoTaiKhoan
            // 
            this.tbSoTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoTaiKhoan.Location = new System.Drawing.Point(291, 81);
            this.tbSoTaiKhoan.Name = "tbSoTaiKhoan";
            this.tbSoTaiKhoan.Size = new System.Drawing.Size(529, 28);
            this.tbSoTaiKhoan.TabIndex = 2;
            // 
            // tbTenKhachHang
            // 
            this.tbTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenKhachHang.Location = new System.Drawing.Point(291, 124);
            this.tbTenKhachHang.Name = "tbTenKhachHang";
            this.tbTenKhachHang.Size = new System.Drawing.Size(529, 28);
            this.tbTenKhachHang.TabIndex = 3;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiaChi.Location = new System.Drawing.Point(291, 169);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(529, 28);
            this.tbDiaChi.TabIndex = 4;
            // 
            // tbSoTien
            // 
            this.tbSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoTien.Location = new System.Drawing.Point(291, 213);
            this.tbSoTien.Name = "tbSoTien";
            this.tbSoTien.Size = new System.Drawing.Size(529, 28);
            this.tbSoTien.TabIndex = 5;
            // 
            // lTenKhachHang
            // 
            this.lTenKhachHang.AutoSize = true;
            this.lTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTenKhachHang.Location = new System.Drawing.Point(133, 124);
            this.lTenKhachHang.Name = "lTenKhachHang";
            this.lTenKhachHang.Size = new System.Drawing.Size(140, 22);
            this.lTenKhachHang.TabIndex = 6;
            this.lTenKhachHang.Text = "Tên khách hàng";
            // 
            // lDiaChi
            // 
            this.lDiaChi.AutoSize = true;
            this.lDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDiaChi.Location = new System.Drawing.Point(110, 169);
            this.lDiaChi.Name = "lDiaChi";
            this.lDiaChi.Size = new System.Drawing.Size(163, 22);
            this.lDiaChi.TabIndex = 7;
            this.lDiaChi.Text = "Địa chỉ khách hàng";
            // 
            // lSoTien
            // 
            this.lSoTien.AutoSize = true;
            this.lSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSoTien.Location = new System.Drawing.Point(83, 216);
            this.lSoTien.Name = "lSoTien";
            this.lSoTien.Size = new System.Drawing.Size(190, 22);
            this.lSoTien.TabIndex = 8;
            this.lSoTien.Text = "Số tiền trong tài khoản";
            // 
            // bAddUpdate
            // 
            this.bAddUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddUpdate.Location = new System.Drawing.Point(335, 269);
            this.bAddUpdate.Name = "bAddUpdate";
            this.bAddUpdate.Size = new System.Drawing.Size(181, 31);
            this.bAddUpdate.TabIndex = 9;
            this.bAddUpdate.Text = "Thêm / Cập nhật";
            this.bAddUpdate.UseVisualStyleBackColor = true;
            this.bAddUpdate.Click += new System.EventHandler(this.bAddUpdate_Click);
            // 
            // bDel
            // 
            this.bDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDel.Location = new System.Drawing.Point(533, 269);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(116, 31);
            this.bDel.TabIndex = 10;
            this.bDel.Text = "Xóa";
            this.bDel.UseVisualStyleBackColor = true;
            this.bDel.Click += new System.EventHandler(this.bDel_Click);
            // 
            // bExit
            // 
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.Location = new System.Drawing.Point(680, 269);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(121, 31);
            this.bExit.TabIndex = 11;
            this.bExit.Text = "Thoát";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // lSum
            // 
            this.lSum.AutoSize = true;
            this.lSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSum.Location = new System.Drawing.Point(372, 651);
            this.lSum.Name = "lSum";
            this.lSum.Size = new System.Drawing.Size(96, 22);
            this.lSum.TabIndex = 12;
            this.lSum.Text = "Tổng tiền: ";
            // 
            // tbSumTien
            // 
            this.tbSumTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSumTien.Location = new System.Drawing.Point(489, 648);
            this.tbSumTien.Name = "tbSumTien";
            this.tbSumTien.ReadOnly = true;
            this.tbSumTien.Size = new System.Drawing.Size(462, 28);
            this.tbSumTien.TabIndex = 13;
            // 
            // lvKhachHang
            // 
            this.lvKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvKhachHang.FullRowSelect = true;
            this.lvKhachHang.GridLines = true;
            this.lvKhachHang.HideSelection = false;
            this.lvKhachHang.Location = new System.Drawing.Point(29, 306);
            this.lvKhachHang.Columns.Add("STT", 50);
            this.lvKhachHang.Columns.Add("Mã tài khoản", 100);
            this.lvKhachHang.Columns.Add("Tên khách hàng", 220);
            this.lvKhachHang.Columns.Add("Địa chỉ", 212);
            this.lvKhachHang.Columns.Add("Số tiền", 110);
            this.lvKhachHang.Name = "lvKhachHang";
            this.lvKhachHang.Size = new System.Drawing.Size(922, 336);
            this.lvKhachHang.TabIndex = 14;
            this.lvKhachHang.UseCompatibleStateImageBehavior = false;
            this.lvKhachHang.View = System.Windows.Forms.View.Details;
            this.lvKhachHang.SelectedIndexChanged += lvKhachHang_SelectedIndexChanged;
            // 
            // Bai08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 688);
            this.Controls.Add(this.lvKhachHang);
            this.Controls.Add(this.tbSumTien);
            this.Controls.Add(this.lSum);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bDel);
            this.Controls.Add(this.bAddUpdate);
            this.Controls.Add(this.lSoTien);
            this.Controls.Add(this.lDiaChi);
            this.Controls.Add(this.lTenKhachHang);
            this.Controls.Add(this.tbSoTien);
            this.Controls.Add(this.tbDiaChi);
            this.Controls.Add(this.tbTenKhachHang);
            this.Controls.Add(this.tbSoTaiKhoan);
            this.Controls.Add(this.lSoTaiKhoan);
            this.Controls.Add(this.lShow);
            this.Name = "Bai08";
            this.Text = "Quản Lý Tài Khoản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lShow;
        private System.Windows.Forms.Label lSoTaiKhoan;
        private System.Windows.Forms.TextBox tbSoTaiKhoan;
        private System.Windows.Forms.TextBox tbTenKhachHang;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbSoTien;
        private System.Windows.Forms.Label lTenKhachHang;
        private System.Windows.Forms.Label lDiaChi;
        private System.Windows.Forms.Label lSoTien;
        private System.Windows.Forms.Button bAddUpdate;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Label lSum;
        private System.Windows.Forms.TextBox tbSumTien;
        private System.Windows.Forms.ListView lvKhachHang;
    }
}
