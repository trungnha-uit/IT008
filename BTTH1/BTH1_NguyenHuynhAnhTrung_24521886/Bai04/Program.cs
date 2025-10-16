using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BTTH1_BT4 {
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

        //Ngay trong thang
        public static int return_day(int thang, int nam) {
            if (thang < 1 || thang > 12 || nam < 1) {
                Console.WriteLine("Khong hop le");
                throw new Exception("Thang khong hop le");
            }

            int leap = 0;
            if(thang == 2 && check_leap_year(nam) == true) {
                leap = 1;
            }

            return valid_day[thang] + leap;
        }

        public static void Main() {
            //Nhap thang nam
            while (true) {
                Console.WriteLine("Nhap thang, nam:");
                int thang = check_input();
                int nam = check_input();

                Console.WriteLine("So ngay cua thang " + thang + " la: " + return_day(thang, nam));
                Console.WriteLine("Nhap Enter de thoat chuong trinh");
            }
        }
    }
}