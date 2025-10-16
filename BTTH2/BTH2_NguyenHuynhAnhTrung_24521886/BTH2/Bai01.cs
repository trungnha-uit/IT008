using System;

namespace BTTH2 {
    public class Bai01 {
        private int c_Month;
        private int c_Year;

        public Bai01(int month, int year) {
            this.c_Month = month;
            this.c_Year = year;
        }

        public static void Run() {
            Console.WriteLine("Nhap thang va nam:");
            int month = input_int();
            int year = input_int();

            Bai01 cal = new Bai01(month, year);
            cal.Print_Calendar();

        }

        static private int input_int() {
            int x;
            while (true) {
                try {
                    x = int.Parse(Console.ReadLine());
                    return x;
                }
                catch {
                    Console.WriteLine("Nhap lai (so nguyen): ");
                }
            }
        }

        // Hàm in khoảng trống đầu dòng (cho ngày đầu tiên trong tháng)
        private void First_Day_Space(int space) {
            for (int i = 0; i < space; i++) {
                Console.Write("     "); // mỗi ô rộng 5 ký tự
            }
        }

        // Hàm in lịch của tháng
        public void Print_Calendar() {
            int Day_in_Month = DateTime.DaysInMonth(c_Year, c_Month);

            Console.WriteLine("\n\t==== Calendar ====");
            Console.WriteLine($"Thang {c_Month:D2}/{c_Year}");
            Console.WriteLine("  Sun  Mon  Tue  Wed  Thu  Fri  Sat");

            DateTime date = new DateTime(c_Year, c_Month, 1);
            int firstDayOfWeek = (int)date.DayOfWeek; // 0=Sun, 1=Mon,...

            // In khoảng trống cho các ngày trước ngày 1
            First_Day_Space(firstDayOfWeek);

            for (int day = 1; day <= Day_in_Month; day++) {
                Console.Write($"{day,5}"); // căn phải trong ô rộng 5 ký tự

                DateTime current = new DateTime(c_Year, c_Month, day);
                if (current.DayOfWeek == DayOfWeek.Saturday) {
                    Console.WriteLine(); // xuống dòng khi hết tuần
                }
            }

            Console.WriteLine("\n");
        }
    }
}
