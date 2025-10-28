using System;

namespace BTTH2 {

    public class cCanlendar {
        private int c_Month;
        private int c_Year;

        public cCanlendar(int month, int year) {
            this.c_Month = month;
            this.c_Year = year;
        }

        // Ham in khoang trong dau dong
        private void First_Day_Space(int space) {
            for (int i = 0; i < space; i++) {
                Console.Write("     "); 
            }
        }

        // Ham in lich cua thang
        public void Print_Calendar() {
            int Day_in_Month;
            try {
                Day_in_Month = DateTime.DaysInMonth(c_Year, c_Month);
            }catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return;
            }

            Console.WriteLine("\n\t==== Calendar ====");
            Console.WriteLine($"Thang {c_Month:D2}/{c_Year:D4}");
            Console.WriteLine("  Sun  Mon  Tue  Wed  Thu  Fri  Sat");

            DateTime date = new DateTime(c_Year, c_Month, 1);
            int firstDayOfWeek = (int)date.DayOfWeek; // 0=Sun, 1=Mon,...

            // In khoang trong truoc ngay 1
            First_Day_Space(firstDayOfWeek);

            for (int day = 1; day <= Day_in_Month; day++) {
                Console.Write($"{day,5}");

                DateTime current = new DateTime(c_Year, c_Month, day);
                if (current.DayOfWeek == DayOfWeek.Saturday) {
                    Console.WriteLine(); // xuong dong khi het tuan
                }
            }

            Console.WriteLine("\n");
        }
    }
    public class Bai01 {

        public static void Run() {
            Console.WriteLine("Bai 01: Lich cua thang trong nam");
            Console.WriteLine("Nhap thang va nam:");
            int month;
            while (true) {
                month = input_int();

                if (month < 1 || month > 12) {
                    Console.WriteLine("Nhap lai thang (1 <= thang <= 12)");
                } else {
                    break;
                }
            }

            int year;
            while (true) {
                year = input_int();

                if (year <= 0) {
                    Console.WriteLine("Nhap lai nam (nam > 0)");
                } else {
                    break;
                }
            }

            cCanlendar cal = new cCanlendar(month, year);
            cal.Print_Calendar();

        }

        private static int input_int() {
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
    }
}
