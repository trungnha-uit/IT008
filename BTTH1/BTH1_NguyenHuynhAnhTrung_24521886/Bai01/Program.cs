using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH1_BT1 {
    class RandomArray {
        const int MIN = -100;
        const int MAX = 100;
        private int[] array;
        private int n;
        public int Lenght {
            get { return n; }
        }

        //Contructor co tham so dau vao la so phan tu mang
        public RandomArray(int n) {
            this.n = n;
            array = new int[n];
            Random rand = new Random();
            for(int i = 0; i < n; ++i) {
                array[i] = rand.Next(MIN, MAX);
            }
        }

        //Tong cac so le trong mang
        public int sum_Odds() {
            int sum = 0;
            for(int i = 0; i < n; ++i) {
                if (array[i] % 2 != 0) {
                    sum += array[i];
                }
            }
            return sum;
        }

        // Kiem tra la so nguyen to
        public static bool check_Prime(int n) {
            if (n <= 1)
                return false;
            if (n == 2)
                return true;
            for(int i = 2; i <= (int)Math.Sqrt(n); ++i) {
                if(n % i == 0) {
                    return false;
                }
            }
            return true;
        }
        // Dem so nguyen to trong mang
        public int count_Prime() {
            int count = 0;
            for(int i = 0; i < n; ++i) {
                if (check_Prime(array[i]) == true) {
                    count++;
                }
            }
            return count;
        }

        //Kiem tra la so chinh phuong
        public static bool check_Square(int n) {
            if (n < 0)
                return false;
            int square = (int)Math.Sqrt(n);
            return (square * square == n);
        }
        //Tim so chinh phuong nho nhat
        public int find_min_Square() {
            int min_square = -1;
            for(int i = 0; i < n; ++i) {
                if ((check_Square(array[i]) == true) && (min_square == -1 || array[i] < min_square)) {
                    min_square = array[i];
                }
            }
            return min_square;
        }

        //In mang
        public void Print() {
            for(int i = 0; i < n; ++i) {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }

    public class Program {
        //Kiem tra so dau vao
        public static int read_int() {
            int n;
            try {
                n = int.Parse(Console.ReadLine());
                if(n <= 0) {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch(Exception e) { 
                Console.WriteLine(e.Message);
                throw new Exception(e.Message);
            }
            return n;
        }
        public static void Main() {
            //Nhap so phan tu cua mang va tao mang
            Console.WriteLine("Nhap so phan tu mang (n > 0): ");
            int n = read_int();
            RandomArray rArray = new RandomArray(n);

            int choice;
            do {
                //In menu
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Thoat");
                Console.WriteLine("2. In mang");
                Console.WriteLine("3. Tinh tong cac so le");
                Console.WriteLine("4. Dem so nguyen to");
                Console.WriteLine("5. Tim so chinh phuong nho nhat");
                Console.Write("Chon chuc nang: ");

                choice = read_int();

                switch (choice) {
                    case 1:
                        Console.WriteLine("Ket thuc chuong trinh");
                        break;
                    case 2:
                        Console.WriteLine("Mang cac so nguyen:");
                        rArray.Print();
                        break;
                    case 3:
                        Console.WriteLine("Tong cac so le la: " + rArray.sum_Odds());
                        break;
                    case 4:
                        Console.WriteLine("So nguyen to trong mang la: " + rArray.count_Prime());
                        break;
                    case 5:
                        Console.WriteLine("So chinh phuong nho nhat la: " + rArray.find_min_Square());
                        break;
                    default:
                        Console.WriteLine("Khong co chuc nang nam ngoai MENU");
                        throw new ArgumentOutOfRangeException();
                }

            } while (choice != 1);
        }
    }
}
