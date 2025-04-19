using System;
using System.Collections.Generic;

namespace LAB1_3BAI6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<HSHocSinh> danhSachHocSinh = new List<HSHocSinh>();
            int chon;

            do
            {
                Console.WriteLine("\n==== MENU QUAN LY HOC SINH ====");
                Console.WriteLine("1. Nhap danh sach hoc sinh");
                Console.WriteLine("2. Hien thi hoc sinh nu va sinh nam 1985");
                Console.WriteLine("3. Tim kiem hoc sinh theo que quan");
                Console.WriteLine("4. Thoat");
                Console.Write("Chon chuc nang: ");
                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        Console.Write("Nhap so luong hoc sinh: ");
                        int n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"\nNhap hoc sinh thu {i + 1}:");
                            HSHocSinh hs = new HSHocSinh();
                            hs.Nhap();
                            danhSachHocSinh.Add(hs);
                        }
                        break;

                    case 2:
                        Console.WriteLine("\n== Danh sach hoc sinh nu va sinh nam 1985 ==");
                        foreach (var hs in danhSachHocSinh)
                        {
                            if (hs.ThongTinCaNhan.GioiTinh.ToLower() == "nu" && hs.ThongTinCaNhan.NamSinh == 1985)
                            {
                                hs.Xuat();
                            }
                        }
                        break;

                    case 3:
                        Console.Write("Nhap que quan can tim: ");
                        string que = Console.ReadLine().ToLower();
                        Console.WriteLine($"\n== Danh sach hoc sinh co que quan '{que}' ==");
                        foreach (var hs in danhSachHocSinh)
                        {
                            if (hs.ThongTinCaNhan.QueQuan.ToLower().Contains(que))
                            {
                                hs.Xuat();
                            }
                        }
                        break;

                    case 4:
                        Console.WriteLine("Thoat chuong trinh.");
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }

            } while (chon != 4);
        }
    }
}
