using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BTTH1_BT6 {
    public class Matrix {
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
        public Matrix(int rows, int cols) {
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

        //Tim vi tri cua phan tu lon/be
        private void Find(string op, out int row, out int col) {
            int tmp = matrix[0][0];
            row = col = 0;
            switch (op) {
                case "MAX":
                    for(int i = 0; i < Size_Row; ++i) {
                        for(int j = 0; j < Size_Col; ++j) {
                            if (matrix[i][j] > tmp) {
                                tmp = matrix[i][j];
                                row = i;
                                col = j;
                            }
                        }
                    }
                    break;
                case "MIN":
                    for (int i = 0; i < Size_Row; ++i) {
                        for (int j = 0; j < Size_Col; ++j) {
                            if (matrix[i][j] < tmp) {
                                tmp = matrix[i][j];
                                row = i;
                                col = j;
                            }
                        }
                    }
                    break;
            }
        }

        //Tim phan tu lon nhat
        public int find_Max() {
            int row, col;
            this.Find("MAX", out row, out col);
            return matrix[row][col];
        }

        //Tim phan tu be nhat
        public int find_Min() {
            int row, col;
            this.Find("MIN", out row, out col);
            return matrix[row][col];
        }

        //Tong cac phan tu tren dong
        private int sum_Row(int[] array) {
            int sum = 0;
            foreach(int x in array) {
                sum += x;
            }
            return sum;
        }
        //Tim dong co tong lon nhat
        public int find_Row() {
            int res = sum_Row(matrix[0]);
            int sum = res;
            for(int i = 0; i < rows; ++i) {
                int tmp = sum_Row(matrix[i]);
                if(sum < tmp) {
                    sum = tmp;
                    res = i;
                }
            }
            return res;
        }

        //Kiem tra so nguyen to
        public bool check_Prime(int x) {
            if (x < 1)
                return false;
            if (x == 2)
                return true;
            for(int i = 2; i <= (int)Math.Sqrt(x); ++i) {
                if(x % i == 0) {
                    return false;
                }
            }
            return true;
        }
        //Tong cac so khong phai la so nguyen to
        public int sum_not_Prime() {
            int sum = 0;
            for (int i = 0; i < rows; ++i) {
                for (int j = 0; j < cols; ++j) {
                    if (!check_Prime(matrix[i][j])) {
                        sum += matrix[i][j];
                    }
                }
            }
            return sum;
        }

        //Xoa dong thu k trong ma tran
        public void delete_Row(int k) {
            if (k < 0 || k >= rows) {
                Console.WriteLine("Index out of range");
                throw new ArgumentOutOfRangeException();
            }
            this.Delete(k, -1);
        }
        //Xoa cot chua phan tu lon nhat trong ma tran
        public void delete_Col_containt_MAX() {
            int row, col;
            this.Find("MAX", out row, out col);
            this.Delete(-1, col);
        }
        //Xoa dong/cot
        public void Delete(int l_row, int l_col) {
            int newRowCount = rows - (l_row >= 0 ? 1 : 0);
            int newColCount = cols - (l_col >= 0 ? 1 : 0);

            int[][] newMatrix = new int[newRowCount][];
            int newRow = 0;

            for (int i = 0; i < rows; i++) {
                if (i == l_row)
                    continue;
                newMatrix[newRow] = new int[newColCount];
                int newCol = 0;
                for (int j = 0; j < cols; j++) {
                    if (j == l_col)
                        continue;
                    newMatrix[newRow][newCol++] = matrix[i][j];
                }
                newRow++;
            }

            rows = newRowCount;
            cols = newColCount;
            matrix = newMatrix;
        }

    }

    public class Program {
        //Kiem tra so dau vao
        public static int read_int() {
            int n;
            try {
                n = int.Parse(Console.ReadLine());
                if (n <= 0) {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                throw new Exception(e.Message);
            }
            return n;
        }
        public static void Main() {
            //Nhap so phan tu cua mang va tao mang
            Console.WriteLine("Nhap so phan tu mang MxN (M, N > 0): ");
            int m = read_int();
            int n = read_int();
            Matrix matrix = new Matrix(m, n);

            int choice;
            do {
                //In menu
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Thoat");
                Console.WriteLine("2. In ma tran");
                Console.WriteLine("3. Tim phan tu lon nhat");
                Console.WriteLine("4. Tim phan tu nho nhat");
                Console.WriteLine("5. Dong co tong lon nhat");
                Console.WriteLine("6. Tinh tong cac so khong phai la so nguyen to");
                Console.WriteLine("7. Xoa dong thu k trong ma tran");
                Console.WriteLine("8. Xoa cot chua phan tu lon nhat");
                Console.Write("Chon chuc nang: ");

                choice = read_int();

                switch (choice) {
                    case 1:
                        Console.WriteLine("Ket thuc chuong trinh");
                        break;
                    case 2:
                        Console.WriteLine("In ma tran:");
                        matrix.Print();
                        break;
                    case 3:
                        Console.WriteLine("Phan tu lon nhat la: " + matrix.find_Max());
                        break;
                    case 4:
                        Console.WriteLine("Phan tu nho nhat la: " + matrix.find_Min());
                        break;
                    case 5:
                        Console.WriteLine("Dong co tong lon nhat la: " + matrix.find_Row());
                        break;
                    case 6:
                        Console.WriteLine("Tong cac so khong la so nguyen to: " + matrix.sum_not_Prime());
                        break;
                    case 7:
                        Console.WriteLine("Xoa dong thu: ");
                        int k = int.Parse(Console.ReadLine());
                        matrix.delete_Row(k);
                        break;
                    case 8:
                        Console.WriteLine("Xoa cot chua phan tu lon nhat trong ma tran");
                        matrix.delete_Col_containt_MAX();
                        break;
                    default:
                        Console.WriteLine("Khong co chuc nang nam ngoai MENU");
                        throw new ArgumentOutOfRangeException();
                }

            } while (choice != 1);
        }
    }
}