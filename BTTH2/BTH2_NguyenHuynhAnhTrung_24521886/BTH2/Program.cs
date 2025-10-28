using BTTH2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH2 {
    public class Program {

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
        public static void Main() {
            while (true) {
                Console.WriteLine("\nChon so thu tu cua bai de chay");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("1. Lich cua thang trong nam");
                Console.WriteLine("2. Terminal");
                Console.WriteLine("3. Ma tran");
                Console.WriteLine("4. Phan so");
                Console.WriteLine("5. Danh sach bat dong san");

                int choice = read_int();
                Console.WriteLine();
                switch (choice) {
                    case 0:
                        Console.WriteLine("Thoat");
                        return;
                    case 1:
                        Bai01.Run();
                        break;
                    case 2:
                        Bai02.Run();
                        break;
                    case 3:
                        Bai03.Run();
                        break;
                    case 4:
                        Bai04.Run();
                        break;
                    case 5:
                        Bai05.Run();
                        break;
                    default:
                        Console.WriteLine("Khong co bai nao khac");
                        break;
                }
            }
        }
    }
}
