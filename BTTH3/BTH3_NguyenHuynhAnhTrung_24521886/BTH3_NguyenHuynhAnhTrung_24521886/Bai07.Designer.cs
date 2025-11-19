using System.Drawing;
using System.Windows.Forms;

namespace BTTH3 {
    partial class Bai07 {
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
            this.tbShow = new System.Windows.Forms.TextBox();
            this.gbChair = new System.Windows.Forms.GroupBox();
            this.bChon = new System.Windows.Forms.Button();
            this.bHuybo = new System.Windows.Forms.Button();
            this.bKetthuc = new System.Windows.Forms.Button();
            this.lThanhTien = new System.Windows.Forms.Label();
            this.tbThanhTien = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbShow
            // 
            this.tbShow.BackColor = System.Drawing.Color.White;
            this.tbShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold);
            this.tbShow.ForeColor = System.Drawing.Color.Orange;
            this.tbShow.Location = new System.Drawing.Point(-1, -2);
            this.tbShow.Name = "tbShow";
            this.tbShow.ReadOnly = true;
            this.tbShow.Size = new System.Drawing.Size(658, 61);
            this.tbShow.TabIndex = 99;
            this.tbShow.TabStop = false;
            this.tbShow.Text = "MÀN ẢNH";
            this.tbShow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbChair
            // 
            this.gbChair.Location = new System.Drawing.Point(51, 74);
            this.gbChair.Name = "gbChair";
            this.gbChair.Size = new System.Drawing.Size(548, 266);
            this.gbChair.TabIndex = 100;
            this.gbChair.TabStop = false;
            // 
            // bChon
            // 
            this.bChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bChon.Location = new System.Drawing.Point(121, 415);
            this.bChon.Name = "bChon";
            this.bChon.Size = new System.Drawing.Size(111, 47);
            this.bChon.TabIndex = 101;
            this.bChon.Text = "Chọn";
            this.bChon.UseVisualStyleBackColor = true;
            this.bChon.Click += new System.EventHandler(this.bChon_Click);
            // 
            // bHuybo
            // 
            this.bHuybo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bHuybo.Location = new System.Drawing.Point(255, 415);
            this.bHuybo.Name = "bHuybo";
            this.bHuybo.Size = new System.Drawing.Size(111, 47);
            this.bHuybo.TabIndex = 102;
            this.bHuybo.Text = "Hủy bỏ";
            this.bHuybo.UseVisualStyleBackColor = true;
            this.bHuybo.Click += new System.EventHandler(this.bHuybo_Click);
            // 
            // bKetthuc
            // 
            this.bKetthuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bKetthuc.Location = new System.Drawing.Point(384, 415);
            this.bKetthuc.Name = "bKetthuc";
            this.bKetthuc.Size = new System.Drawing.Size(111, 47);
            this.bKetthuc.TabIndex = 103;
            this.bKetthuc.Text = "Kết thúc";
            this.bKetthuc.UseVisualStyleBackColor = true;
            this.bKetthuc.Click += new System.EventHandler(this.bKetthuc_Click);
            // 
            // lThanhTien
            // 
            this.lThanhTien.AutoSize = true;
            this.lThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lThanhTien.Location = new System.Drawing.Point(46, 361);
            this.lThanhTien.Name = "lThanhTien";
            this.lThanhTien.Size = new System.Drawing.Size(119, 25);
            this.lThanhTien.TabIndex = 104;
            this.lThanhTien.Text = "Thành Tiền:";
            // 
            // tbThanhTien
            // 
            this.tbThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbThanhTien.Location = new System.Drawing.Point(175, 361);
            this.tbThanhTien.Name = "tbThanhTien";
            this.tbThanhTien.ReadOnly = true;
            this.tbThanhTien.Size = new System.Drawing.Size(350, 30);
            this.tbThanhTien.TabIndex = 105;
            this.tbThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Bai07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 474);
            this.Controls.Add(this.tbThanhTien);
            this.Controls.Add(this.lThanhTien);
            this.Controls.Add(this.bKetthuc);
            this.Controls.Add(this.bHuybo);
            this.Controls.Add(this.bChon);
            this.Controls.Add(this.gbChair);
            this.Controls.Add(this.tbShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Bai07";
            this.Text = "BÁN VÉ RẠP CHIẾU BÓNG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbShow;
        private GroupBox gbChair;
        private Button bChon;
        private Button bHuybo;
        private Button bKetthuc;
        private Label lThanhTien;
        private TextBox tbThanhTien;
    }
}