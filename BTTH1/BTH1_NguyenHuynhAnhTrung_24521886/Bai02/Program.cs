using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH1_BT2 {
    public class Program {
        //Kiem tra so dau vao
        public static int check_input() {
            int x;
            try {
                x = int.Parse(Console.ReadLine());
                if (x != -1 && x <= 0)
                    throw new ArgumentOutOfRangeException("Phai la so duong");
            }catch(Exception e) {
                Console.WriteLine(e.Message);
                throw new Exception(e.Message);
            }
            return x;
        }

        //Kiem tra so nguyen to
        public static bool check_Prime(int x) {
            if(x == 2) {
                return true;
            }
            for(int i = 2; i <= (int)Math.Sqrt(x); ++i) {
                if(x % i == 0) {
                    return false;
                }
            }
            return true;
        }

        //Tong cac so nguyen to nho hon n
        public static int sum_Prime(int n) {
            int sum = 0;
            for (int i = 2; i < n; ++i) {
                if (check_Prime(i) == true) {
                    sum += i;
                }
            }
            return sum;
        }

        public static void Main() {
            //Nhap so nguyen duong n
            int n;
            do {
                Console.WriteLine("Nhap mot so nguyen duong:");
                n = check_input();
                if (n == -1)
                    break;

                Console.WriteLine("Nhap -1 de thoat.");
                Console.WriteLine("Tong cac so nguyen to nho hon n la: " + sum_Prime(n));
            } while (true);
        }
    }
}