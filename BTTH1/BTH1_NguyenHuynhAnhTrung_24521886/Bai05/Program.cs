using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH1_BT5 { 
    class Program {
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
                Environment.Exit(1);
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
            if (ngay < 1 || thang < 1 || thang > 12 || nam < 1)
                return false;
            int leap = 0;
            if (thang == 2 && check_leap_year(nam) == true) {
                leap = 1;
            }
            return ngay <= (valid_day[thang] + leap);
        }

        //Tinh tong so ngay
        private static int total_day(int ngay, int thang, int nam) {
            if (check_valid(ngay, thang, nam) == false) {
                Console.WriteLine("Khong hop le");
                Environment.Exit(1);
            }

            int total = 0;
            for(int i = 1; i < nam; ++i) {
                if (check_leap_year(i)) {
                    total++;
                }
                total += 365;
            }
            for (int i = 1; i < thang; ++i) {
                if(i == 2 && check_leap_year(nam) == true)
                    total++;
                total += valid_day[i];
            }
            return total + ngay;
        }

        //Tra ve ngay trong tuan
        private static string return_ngay(int ngay, int thang, int nam) {
            int thu = (total_day(ngay, thang, nam) - 1) % 7;
            switch (thu) {
                case 0:
                    return ("Thu hai");
                case 1:
                    return ("Thu ba");
                case 2:
                    return ("Thu tu");
                case 3:
                    return ("Thu nam");
                case 4:
                    return ("Thu sau");
                case 5:
                    return ("Thu bay");
                default:
                    return ("Chu nhat");
            }
        }

        public static void Main() {
            //Nhap ngay thang nam
            while (true) {
                Console.WriteLine("Nhap ngay, thang, nam:");
                int ngay = check_input();
                int thang = check_input();
                int nam = check_input();

                Console.WriteLine("{0}/{1}/{2} la thu: {3}", ngay, thang, nam, return_ngay(ngay, thang, nam));
                Console.WriteLine("Nhap Enter de thoat chuong trinh");
            }
        }
    }
}
