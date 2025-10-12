using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH1_BT3 {
    public class Program {
        //Ngay cua cac thang trong nam bat dau tu index 1
        private static int[] valid_day = { -1, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        //Kiem tra nam nhuan
        public static bool check_leap_year(int year) {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }

        //Kiem tra so dau vao
        public static int check_input() {
            int x;
            string tmp = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(tmp)) {
                Console.WriteLine("Thoat chuong trinh");
                Environment.Exit(0);
            }
            try {
                x = int.Parse(tmp);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                throw new Exception(e.Message);
            }
            return x;
        }

        //Kiem tra thoi gian hop le
        public static bool check_valid(int ngay, int thang, int nam) {
            if (ngay < 1 || thang < 1 || thang > 12)
                return false;
            int leap = 0;
            if(thang == 2 && check_leap_year(nam) == true) {
                leap = 1;
            }
            return ngay <= (valid_day[thang] + leap);
        }

        public static void Main() {
            //Nhap ngay thang nam
            while (true) {
                Console.WriteLine("Nhap ngay, thang, nam:");
                int ngay = check_input();

                int thang = check_input();
                int nam = check_input();

                if (check_valid(ngay, thang, nam) == true) {
                    Console.WriteLine("Ngay thang nam hop le");
                } else {
                    Console.WriteLine("Ngay thang nam khong hop le");
                }
                Console.WriteLine("Nhap Enter de thoat chuong trinh");
            }
        }
    }
}