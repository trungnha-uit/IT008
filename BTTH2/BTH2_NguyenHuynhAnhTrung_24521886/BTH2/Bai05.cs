using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH2 {

    public class cKhuDat {
        private string DiaDiem;
        private long GiaBan;
        private int DienTich;

        public string GetDiaDiem { get { return DiaDiem; } }
        public long GetGiaBan { get { return GiaBan; } }
        public int GetDienTich { get { return DienTich; } }

        public virtual void Nhap() {
            Console.Write("Nhap dia diem: ");
            DiaDiem = Console.ReadLine();
            Console.Write("Nhap gia ban: ");
            GiaBan = Bai05.read_long();
            Console.Write("Nhap dien tich (Don vi: m2): ");
            DienTich = Bai05.read_int();
        }

        public virtual void Xuat() {
            Console.Write($"Dia diem: {DiaDiem,20}. Gia ban: {GiaBan,15:N0}. Dien tich: {DienTich,10}");
        }

        public virtual string GetLoai() {
            return "khu dat";
        }
    }

    public class cNhaPho : cKhuDat {
        private int NamXayDung;
        private int SoTang;

        public int GetNamXayDung { get { return NamXayDung; } }
        public int GetSoTang { get { return SoTang; } }

        public override void Nhap() {
            base.Nhap();
            Console.Write("Nhap nam xay dung: ");
            NamXayDung = Bai05.read_int();
            Console.Write("Nhap so tang: ");
            SoTang = Bai05.read_int();
        }

        public override void Xuat() {
            base.Xuat();
            Console.Write($". Nam xay dung: {GetNamXayDung,10}. So tang: {GetSoTang,8}");
        }

        public override string GetLoai() {
            return "nha pho";
        }
    }

    public class cChungCu : cKhuDat {
        private int Tang;

        public int GetTang { get{ return Tang; } }

        public override void Nhap() {
            base.Nhap();
            Console.Write("Nhap vi tri tang: ");
            Tang = Bai05.read_int();
        }

        public override void Xuat() {
            base.Xuat();
            Console.Write($". Vi tri tang: {GetTang,8}");
        }

        public override string GetLoai() {
            return "chung cu";
        }
    }

    internal class Bai05 {
        private cKhuDat[] list;
        private int listLength;

        public Bai05(int n) {
            listLength = n;
            list = new cKhuDat[n];
        }

        //Kiem tra so dau vao (int)
        public static int read_int() {
            int n;
            while (true) {
                try {
                    n = int.Parse(Console.ReadLine());
                    if(n < 0) {
                        throw new ArgumentException("Khong the nho hon 0");
                    }
                    return n;
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message + "\nNhap lai so nguyen!");
                }
            }
        }

        //Kiem tra so dau vao (int)
        public static long read_long() {
            long n;
            while (true) {
                try {
                    n = long.Parse(Console.ReadLine());
                    if (n < 0) {
                        throw new ArgumentException("Khong the nho hon 0");
                    }
                    return n;
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message + "\nNhap lai so nguyen!");
                }
            }
        }

        public void Nhap() {
            for(int i = 0; i < listLength; ++i) {
                int loai;
                cKhuDat bds = null;

                while(bds == null) {
                    Console.WriteLine($"\n--- Nhap thong tin BDS thu {i + 1} ---");
                    Console.WriteLine("1. Khu Dat");
                    Console.WriteLine("2. Nha pho");
                    Console.WriteLine("3. Chung Cu");
                    Console.Write("Chon loai: ");
                    loai = read_int();
                    bds = loai switch {
                        1 => new cKhuDat(),
                        2 => new cNhaPho(),
                        3 => new cChungCu(),
                        _ => null
                    };
                }

                bds.Nhap();
                list[i] = bds;
            }
        }

        public void XuatDS() {
            Console.WriteLine("\n----- Danh sach bat dong san -----");
            for (int i = 0; i < listLength; ++i) {
                Console.Write($"Loai: {list[i].GetLoai(),-10}");
                list[i].Xuat();
                Console.WriteLine();
            }
        }

        // Tong gia theo tung loai bat dong san
        public void TongGiaDatTheoLoai() {
            long tongGiaDat = 0;
            long tongGiaNhaPho = 0;
            long tongGiaChungCu = 0;
            for(int i = 0; i < listLength; ++i) {
                if (list[i].GetLoai() == "khu dat") {
                    tongGiaDat += list[i].GetGiaBan;
                }else if(list[i].GetLoai() == "chung cu") {
                    tongGiaChungCu += list[i].GetGiaBan;
                } else {
                    tongGiaNhaPho += list[i].GetGiaBan;
                }
            }

            Console.WriteLine("\n--- Tong gia ban ---");
            Console.WriteLine($"Khu Đat: {tongGiaDat:N0} VND");
            Console.WriteLine($"Nha Pho: {tongGiaNhaPho:N0} VND");
            Console.WriteLine($"Chung Cu: {tongGiaChungCu:N0} VND");
        }

        // Xuat danh sach co dieu kien
        public void XuatDSCoDieuKien() {
            Console.WriteLine("\n----- Danh sach bat dong san -----");
            for (int i = 0; i < listLength; ++i) {
                if ((list[i].GetLoai() == "khu dat" && list[i].GetDienTich > 100)
                   ||
                    (list[i].GetLoai() == "nha pho" && list[i].GetDienTich > 60 && ((cNhaPho)list[i]).GetNamXayDung >= 2019)) {

                    Console.Write($"Loai: {list[i].GetLoai(),-10}");
                    list[i].Xuat();
                    Console.WriteLine();
                }
            }
        }

        //  Tim kiem theo dia diem, gia, dien tich
        public void TimBDS() {
            Console.Write("\nNhap dia diem can tim (chuoi): ");
            string diaDiem = Console.ReadLine().ToLower();

            Console.Write("Nhap gia toi da (VND): ");
            long gia = read_long();
            Console.Write("Nhap dien tich toi thieu (m2): ");
            long dt = read_long();

            Console.WriteLine("\n--- Ket qua tim kiem ---");
            for (int i = 0; i < listLength; ++i) {
                if (list[i].GetDiaDiem.ToLower().Contains(diaDiem) && list[i].GetGiaBan <= gia && list[i].GetDienTich >= dt && (list[i].GetLoai() == "nha pho" || list[i].GetLoai() == "chung cu")) {
                    Console.Write($"Loai: {list[i].GetLoai(),-10}");
                    list[i].Xuat();
                    Console.WriteLine();
                }
            }
        }
        public static void Run() {
            Console.WriteLine("Bai05: Danh sach bat dong san");
            int LENGTH;
            do {
                Console.Write("\nNhap so luong bat dong san: ");
                LENGTH = read_int();
            } while (LENGTH < 1);

            Bai05 listBDS = new Bai05(LENGTH);
            listBDS.Nhap();

            int choice;
            while (true) {
                //In menu
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("1. In danh sach cac bat dong san");
                Console.WriteLine("2. Xuat tong gia tung loai");
                Console.WriteLine("3. Xuat theo dieu kien dac biet");
                Console.WriteLine("4. Tim kiem theo yeu cau");
                Console.Write("Chon chuc nang: ");

                choice = read_int();

                switch (choice) {
                    case 0:
                        Console.WriteLine("Ket thuc chuong trinh");
                        return;
                    case 1:
                        listBDS.XuatDS();
                        break;
                    case 2:
                        listBDS.TongGiaDatTheoLoai();
                        break;
                    case 3:
                        listBDS.XuatDSCoDieuKien();
                        break;
                    case 4:
                        listBDS.TimBDS();
                        break;
                    default:
                        Console.WriteLine("Khong co chuc nang nam ngoai MENU");
                        break;
                }
            }
        }
    }
}
