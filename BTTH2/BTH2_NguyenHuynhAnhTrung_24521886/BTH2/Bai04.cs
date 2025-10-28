using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH2 {

    public class cPhanSo : IComparable<cPhanSo> {
        private int tuSo, mauSo;
        public int Tu { get { return tuSo; } }
        public int Mau { get { return mauSo; } }

        public static int UCLN(int a, int b) {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (b == 0)
                return a;
            return UCLN(b, a % b);
        }

        // Constructor mac dinh
        public cPhanSo() {
            tuSo = 0;
            mauSo = 1;
        }

        // Constructor co tham so mac nhien (mau = 1)
        public cPhanSo(int tu, int mau = 1) {
            if(mau == 0) {
                throw new ArgumentException("Mau = 0 -> Loi");
            }
            int tUCLN = UCLN(tu, mau);

            if (mau < 0) {
                tu = -tu;
                mau = -mau;
            }

            this.tuSo = tu / tUCLN;
            this.mauSo = mau / tUCLN;
        }

        public void INPUT(string ps) {
            string str = ps.Replace(" ", "");
            string[] arr = str.Split('/');

            int tu = int.Parse(arr[0]);
            int mau = (arr.Length > 1) ? int.Parse(arr[1]) : 1;

            if (mau == 0)
                throw new ArgumentException("Mau = 0 -> Loi");

            int tUCLN = UCLN(tu, mau);

            if (mau < 0) {
                tu = -tu;
                mau = -mau;
            }

            tuSo = tu / tUCLN;
            mauSo = mau / tUCLN;
        }

        // In phan so ra man hinh
        public override string ToString() {
            if(tuSo == 0) {
                return "0";
            }
            if (mauSo == 1) {
                return tuSo.ToString();
            }

            string result = Tu.ToString() + "/" + Mau.ToString();
            return result;
        }

        // Overload operator +
        public static cPhanSo operator +(cPhanSo a, cPhanSo b) {
            int tu = a.Tu * b.Mau + b.Tu * a.Mau;
            int mau = a.Mau * b.Mau;
            int ucln = UCLN(tu, mau);

            return new cPhanSo(tu / ucln, mau / ucln);
        }

        // Overload operator -
        public static cPhanSo operator -(cPhanSo a, cPhanSo b) {
            int tu = a.Tu * b.Mau - b.Tu * a.Mau;
            int mau = a.Mau * b.Mau;
            int ucln = UCLN(tu, mau);

            return new cPhanSo(tu / ucln, mau / ucln);
        }

        // Overload operator *
        public static cPhanSo operator *(cPhanSo a, cPhanSo b) {
            int tu = a.Tu * b.Tu;
            int mau = a.Mau * b.Mau;
            int ucln = UCLN(tu, mau);

            return new cPhanSo(tu / ucln, mau / ucln);
        }

        // Overload operator /
        public static cPhanSo operator /(cPhanSo a, cPhanSo b) {
            if (b.Tu == 0) {
                throw new DivideByZeroException();
            }

            cPhanSo c = new cPhanSo(b.Mau, b.Tu);
            return a * c;
        }

        // Ham cua interface IComperable
        public int CompareTo(cPhanSo other) { 
            return (this.Tu * other.Mau).CompareTo(other.Tu * this.Mau);
        }
    }
    internal class Bai04 {
        cPhanSo[] list;
        int listLength;

        // Constructor
        public Bai04(int n) {
            listLength = n;
            list = new cPhanSo[n];
        }

        // Nhap danh sach phan so
        public void Nhap() {
            for (int i = 0; i < listLength; i++) {
                list[i] = new cPhanSo();
                while (true) {
                    try {
                        Console.Write($"Nhap phan so thu {i + 1} (dang a/b): ");
                        list[i].INPUT(Console.ReadLine());
                        break;
                    }
                    catch (Exception e) {
                        Console.WriteLine(e.Message + "Nhap lai.");
                    }
                }
            }
        }

        // Tim phan so lon nhat
        public cPhanSo Find_Max() {
            cPhanSo MAX = list[0];

            for(int i = 1; i < listLength; ++i) {
                if (list[i].CompareTo(MAX) > 0) {
                    MAX = list[i];
                }
            }

            return MAX;
        }

        // Sap xep lai danh sach
        public void Sort_PhanSo() {
            Array.Sort(list);
        }

        // In ra danh sach phan so
        public void Print() {
            Console.Write("Danh sach phan so: ");
            for(int i = 0; i < listLength; ++i)
                Console.Write(list[i].ToString() + " ");
            Console.WriteLine();
        }

        //Kiem tra so dau vao
        public static int read_int() {
            int n;
            while (true) {
                try {
                    n = int.Parse(Console.ReadLine());
                    return n;
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message + "\nNhap lai so nguyen!");
                }
            }
        }

        //Ham tinh toan voi phan so
        public static void Tinh_PhanSo() {
                cPhanSo a = new cPhanSo();
                cPhanSo b = new cPhanSo();

            while (true) {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("1. Nhap phan so (Neu khong nhap thi 2 phan so la 0)");
                Console.WriteLine("2. Cong 2 phan so");
                Console.WriteLine("3. Tru 2 phan so");
                Console.WriteLine("4. Nhan 2 phan so");
                Console.WriteLine("5. Chia 2 phan so");
                Console.Write("Chon chuc nang: ");

                int choice;

                choice = read_int();

                switch (choice) {
                    case 0:
                        Console.WriteLine("Thoat tinh toan 2 phan so\n");
                        return;
                    case 1:
                        try {
                            Console.WriteLine("Nhap 2 phan so");
                            a.INPUT(Console.ReadLine());
                            b.INPUT(Console.ReadLine());
                        }
                        catch (Exception e) {
                            Console.WriteLine(e.Message);
                            continue;
                        }
                        break;
                    case 2:
                    case 3:
                    case 4:
                    case 5:

                        string op = choice switch {
                            2 => "+",
                            3 => "-",
                            4 => "*",
                            _ => "/"
                        };

                        if (choice == 5 && b.Tu == 0) {
                            Console.WriteLine($"Khong the thuc hien phep {a} {op} {b}");
                            break;
                        }

                        cPhanSo result = choice switch {
                            2 => a + b,
                            3 => a - b,
                            4 => a * b,
                            _ => a / b
                        };

                        Console.WriteLine($"{a} {op} {b} = {result}");
                        break;
                    default:
                        Console.WriteLine("Khong co chuc nang khac");
                        break;
                }
            }
        }

        //Ham danh sach phan so
        public static void DS_PhanSo() {
            int LENGTH;
            do {
                Console.Write("\nNhap so luong phan so: ");
                LENGTH = read_int();
            } while (LENGTH < 1);

            Bai04 listPS = new Bai04(LENGTH);
            listPS.Nhap();
            int choice;
            while (true) {
                //In menu
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("1. In danh sach phan so");
                Console.WriteLine("2. Tim phan so lon nhat");
                Console.WriteLine("3. Sap xep lai danh sach");
                Console.Write("Chon chuc nang: ");

                choice = read_int();

                switch (choice) {
                    case 0:
                        Console.WriteLine("Ket thuc chuong trinh\n");
                        return;
                    case 1:
                        listPS.Print();
                        break;
                    case 2:
                        Console.WriteLine("Phan so lon nhat la: " + listPS.Find_Max().ToString());
                        break;
                    case 3:
                        listPS.Sort_PhanSo();
                        Console.WriteLine("Sap xep lai phan so hoan tat");
                        break;
                    default:
                        Console.WriteLine("Khong co chuc nang nam ngoai MENU");
                        break;
                }

            }
        }

        public static void Run() {
            Console.WriteLine("Bai04: Phan so");
            int choice;
            while (true) {
                Console.WriteLine("Thoat : 0 \nChon tinh toan phan so : 1 \nChon danh sach phan so : 2");
                choice = read_int();
                switch (choice) {
                    case 0:
                        return;
                    case 1:
                        Tinh_PhanSo();
                        break;
                    case 2:
                        DS_PhanSo();
                        break;
                    default:
                        Console.WriteLine("Khong co chuc nang");
                        break;
                }
            }
        }
    }
}
