using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH2 {

    public class cMaTran {
        const int MAX = 101;
        const int MIN = -100;
        private int rows, cols;
        public int Size_Row {
            get { return rows; }
        }
        public int Size_Col {
            get { return cols; }
        }

        private int[][] matrix;

        //Constructor co tham so tao ma tran ngau nhien
        public cMaTran(int rows, int cols) {
            this.rows = rows;
            this.cols = cols;

            Random rand = new Random();
            matrix = new int[rows][];

            for (int i = 0; i < rows; ++i) {
                matrix[i] = new int[cols];
                for (int j = 0; j < cols; ++j) {
                    matrix[i][j] = rand.Next(MIN, MAX);
                }
            }
        }

        //Nhap ma tran
        public void Input() {
            for (int i = 0; i < rows; ++i) {
                for (int j = 0; j < cols; ++j) {
                    Console.WriteLine($"Nhap phan tu thu matrix[{i + 1}][{j + 1}]");
                    try {
                        matrix[i][j] = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e) {
                        Console.WriteLine(e.Message + ". Nhap lai");
                        j--;
                    }
                }
            }
        }

        //In ma tran
        public void Print() {
            const int cellWidth = 5;
            Console.WriteLine("\t======= MATRIX =======");
            Console.Write("+");
            for (int j = 0; j < cols; j++) {
                Console.Write(new string('-', cellWidth));
            }
            Console.WriteLine("+");

            for (int i = 0; i < rows; i++) {
                Console.Write("|");
                for (int j = 0; j < cols; j++) {
                    Console.Write($"{matrix[i][j],cellWidth}");
                }
                Console.WriteLine("|");
            }

            Console.Write("+");
            for (int j = 0; j < cols; j++) {
                Console.Write(new string('-', cellWidth));
            }
            Console.WriteLine("+");
        }

        // Tim kiem mot phan tu trong ma tran
        public (int, int) findX(int num) {
            for (int i = 0; i < rows; ++i) {
                for (int j = 0; j < cols; ++j) {
                    if (num == matrix[i][j]) {
                        return (i, j);
                    }
                }
            }

            return (-1, -1);
        }

        //Kiem tra so nguyen to
        public bool check_Prime(int x) {
            if (x < 1)
                return false;
            if (x == 2)
                return true;
            for (int i = 2; i <= (int)Math.Sqrt(x); ++i) {
                if (x % i == 0) {
                    return false;
                }
            }
            return true;
        }
        // In ra cac phan tu la so nguyen to
        public string string_PrimeNumber() {
            string result = "";
            foreach (int[] array in matrix) {
                foreach (int x in array) {
                    if (check_Prime(x)) {
                        result = result + x.ToString() + ", ";
                    }
                }
            }
            if (!string.IsNullOrEmpty(result)) {
                result = result.Trim();
                result = result.Substring(0, result.Length - 1) + ".";
            }
            return result;
        }

        // Tim dong co nhieu so nguyen to nhat
        public int findRow_MaxTotalPrime() {
            int row = -1;
            int MAX = 0;
            for (int i = 0; i < rows; ++i) {
                int count = 0;
                for (int j = 0; j < cols; ++j) {
                    if (check_Prime(matrix[i][j])) {
                        count++;
                    }
                }
                if (count > MAX) {
                    MAX = count;
                    row = i;
                }
            }

            return row;
        }
    }
    internal class Bai03 {

        //Kiem tra so dau vao
        public static int read_int() {
            int n;
            while (true) {
                try {
                    n = int.Parse(Console.ReadLine());
                    return n;
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message + "\nNhap lai (so nguyen)!");
                }
            }
        }
        public static void Run() {
            Console.WriteLine("Bai03: Ma tran");
            //Nhap so phan tu cua mang va tao mang
            int m, n;
            do {
                Console.WriteLine("Nhap so phan tu mang MxN (M, N > 0): ");
                m = read_int();
                n = read_int();
            } while (m < 1 || n < 1);
            cMaTran matrix = new cMaTran(m, n);

            int isRandom = 0;
            do {
                Console.WriteLine("Nhap ma tran ngau nhien ? ( 1 : co ) : ( 2 : khong )");
                isRandom = read_int();
            } while (isRandom < 1 && isRandom > 2);
            if(isRandom == 2) {
                matrix.Input();
            }


            int choice;
            while(true) {
                //In menu
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("1. In ma tran");
                Console.WriteLine("2. Tim kiem mot phan tu trong ma tran");
                Console.WriteLine("3. Xuat cac phan tu la so nguyen to");
                Console.WriteLine("4. Cho biet dong co nhieu so nguyen to nhat");
                Console.Write("Chon chuc nang: ");

                choice = read_int();

                switch (choice) {
                    case 0:
                        Console.WriteLine("Ket thuc chuong trinh");
                        return;
                    case 1:
                        Console.WriteLine("In ma tran:");
                        matrix.Print();
                        break;
                    case 2:
                        int x;
                        try {
                            Console.Write("Tim phan tu: ");
                            x = int.Parse(Console.ReadLine());
                            (int X_row, int X_col) = matrix.findX(x);
                            if (X_row == -1) {
                                Console.WriteLine($"Phan tu {x} khong co trong ma tran");
                            } else
                                Console.WriteLine($"Phan tu {x} o dong thu {X_row + 1}, cot thu {X_col + 1}");
                        }
                        catch (Exception e) { 
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 3:
                        string listPrime = matrix.string_PrimeNumber();
                        if (string.IsNullOrEmpty(listPrime))
                            Console.WriteLine("Khong co so nguyen to nao trong ma tran");
                        else
                            Console.WriteLine("Danh sach cac so nguyen to: " + listPrime); 
                        break;
                    case 4:
                        int row = matrix.findRow_MaxTotalPrime();
                        if (row == -1)
                            Console.WriteLine("Khong co so nguyen to nao trong ma tran");
                        else
                            Console.WriteLine("Dong co nhieu so nguyen to nhat la: " + (row + 1).ToString());
                        break;
                    default:
                        Console.WriteLine("Khong co chuc nang nam ngoai MENU");
                        break;
                }

            }
        }
    }
}

