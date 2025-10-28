using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BTH2 {
    public class Bai02 {
        private static string rDirectory;
        public static void Run() {
            Console.WriteLine("Bai02: Terminal");
            //=====================================
            // Hướng dẫn cách sử dụng
            string longline = new String('=', 30);
            Console.WriteLine(longline);
            Console.WriteLine($"{"Huong dan",18}");
            Console.WriteLine("Nhap cd <Duong dan thu muc> : de di chuyen den thu muc can xet");
            Console.WriteLine("Nhap cd\\ : de tro lai thu muc goc");
            Console.WriteLine("Nhap dir : de in ra cac thu muc co trong thu muc goc");
            Console.WriteLine("Nhap clear : de xoa toan bo noi dung console");
            Console.WriteLine("Nhap exit : de ket thuc chuong trinh");
            Console.WriteLine("LUU Y: NHAP DUNG DINH DANG CAU LENH");
            Console.WriteLine(longline);
            //=====================================
            while (true) {
                Console.Write(string.IsNullOrEmpty(rDirectory) ? "\\>" : (rDirectory.EndsWith('\\') ? rDirectory : rDirectory + "\\") + ">");
                string tmp = Console.ReadLine()?.Trim();
                tmp = Regex.Replace(tmp, @"\\+", "\\");
                string[] paths = tmp.Split(' ');

                switch (paths[0]) {
                    case "cd":
                        if(paths.Length < 2) {
                            Console.WriteLine("Thieu duong dan");
                            break;
                        }
                        paths[1] = paths[1].TrimStart('\\');
                        check_folder_in_directory(paths[1]);
                        break;

                    case "cd\\":
                        if (!string.IsNullOrEmpty(rDirectory)) {
                            rDirectory = rDirectory.Split('\\')[0];
                        }
                        break;

                    case "dir":
                        dir_function();
                        break;

                    case "clear":
                        Console.Clear();
                        break;

                    case "exit":
                        rDirectory = "";
                        Console.WriteLine("Ket thuc chuong trinh");
                        return;

                    default:
                        Console.WriteLine("Khong co lenh nam ngoai MENU");
                        break;
                }
            }
        }

        private static bool check_exit_directory(string path) {
            return Directory.Exists(path);
        }

        private static void check_folder_in_directory(string paths) {
            if (paths.EndsWith(':')) {
                paths += "\\";
            }

            if (check_exit_directory(paths)) {
                rDirectory = Path.GetFullPath(paths).TrimEnd('\\');
            } else {
                string tmp_Path = "";
                try {
                    tmp_Path = Path.Combine(rDirectory, paths);
                }
                catch {
                    Console.WriteLine($"{rDirectory + paths} khong ton tai. Thu lai.");
                    return;
                }
                if (check_exit_directory(tmp_Path))
                    rDirectory = Path.Combine(rDirectory, paths).TrimEnd('\\');
                else
                    Console.WriteLine($"{rDirectory + paths} khong ton tai. Thu lai.");
            }
        }

        private static void dir_function() {
            if (string.IsNullOrWhiteSpace(rDirectory)) {
                Console.WriteLine("Chua chon thu muc");
                return;
            }

            DriveInfo dvInfor = new DriveInfo(Path.GetPathRoot(rDirectory));


            Console.WriteLine($" Volume in {dvInfor.Name} is {dvInfor.VolumeLabel}");
            Console.WriteLine($" Volume Serial Number is {dvInfor.DriveFormat.ToUpper()}");

            Console.WriteLine($"\n Directory of {rDirectory}");

            string[] folder = Directory.GetDirectories(rDirectory.EndsWith(":") ? rDirectory + "\\" : rDirectory);
            string[] files = Directory.GetFiles(rDirectory);

            if (folder.Length > 0 || files.Length > 0) {
                Console.WriteLine();

                foreach (string path in folder) {
                    DirectoryInfo dir_info = new DirectoryInfo(path);
                    Console.WriteLine($"{dir_info.LastWriteTime,20:MM/dd/yyyy hh:mm tt}      {"<DIR>", 15}          {dir_info.Name}");
                }

                long files_size = 0;
                foreach (string f in files) {
                    try {
                        FileInfo info = new FileInfo(f);
                        files_size += info.Length;
                        Console.WriteLine($"{info.LastWriteTime,20:MM/dd/yyyy hh:mm tt}      {info.Length,15:N0}          {info.Name}");
                    }
                    catch (Exception ex) {
                        Console.WriteLine($"Loi. Khong doc duoc file: {ex.Message}");
                    }
                }

                Console.WriteLine($"\n{files.Length,20} File(s) {files_size,20:N0} bytes");
                Console.WriteLine($"{folder.Length, 20} Dir(s) {dvInfor.TotalFreeSpace, 20:N0} bytes free");
                Console.WriteLine();

            } else {
                Console.WriteLine("Khong co gi trong thu muc");
            }
            
        }
    }
}
