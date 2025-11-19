using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH3 {
    public partial class Bai07 : Form {

        private Button[] bChair = new Button[15];
        public Bai07() {
            InitializeComponent();

            Initialize_matrixChair();
        }

        // Khoi tao ma tran cac ghe (0: Ghe chua ban, 1: Ghe dang chon, 2: Ghe da ban)
        private void Initialize_matrixChair() {
            int loc_X = 19;
            int loc_Y = 19;

            for(int i = 0; i < 15; ++i) {
                bChair[i] = new Button();
                bChair[i].Text = (i + 1).ToString();
                bChair[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                bChair[i].Size = new System.Drawing.Size(70, 50);
                bChair[i].Location = new Point(loc_X, loc_Y);
                bChair[i].Click += new EventHandler(bChair_Click);
                bChair[i].BackColor = Color.White;

                gbChair.Controls.Add(bChair[i]);

                loc_X += 75;
                if ((i + 1) % 5 == 0) {
                    loc_Y += 65;
                    loc_X = 19;
                }
            }
        }

        private void bChair_Click(object sender, EventArgs e) {
            if (!check_ConGhe()) {
                MessageBox.Show("Đã hết ghế. Vui lòng đến vào hôm sau.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Button bChair = (Button)sender;

            if(bChair.BackColor == Color.White) {
                bChair.BackColor = Color.Blue;
            } else if(bChair.BackColor == Color.Blue) {
                bChair.BackColor = Color.White;
            }else if(bChair.BackColor == Color.Yellow) {
                MessageBox.Show("Vé ở ghế này đã được bán! \nVui lòng chọn ghế khác.", "Thông Báo");
            }
        }

        private void bHuybo_Click(object sender, EventArgs e) {
            foreach (Button b in bChair) {
                if(b.BackColor == Color.Blue)
                    b.BackColor = Color.White;
            }

            this.tbThanhTien.Text = "0";
        }

        private void bKetthuc_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void bChon_Click(object sender, EventArgs e) {
            int sum = 0;

            for(int i = 0; i < 15; ++i) {
                if (bChair[i].BackColor == Color.Blue) {
                    bChair[i].BackColor = Color.Yellow;

                    if (i < 5)
                        sum += 8000;
                    else if (i < 10)
                        sum += 6500;
                    else
                        sum += 5000;
                }
            }

            tbThanhTien.Text = sum.ToString();
        }

        private bool check_ConGhe() {
            for (int i = 0; i < 15; ++i) {
                if (bChair[i].BackColor == Color.White)
                    return true;
            }

            return false;
        }
    }
}
