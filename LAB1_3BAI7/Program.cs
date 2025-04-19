using System;
using System.Collections.Generic;

namespace LAB1_3BAI7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CBGV> danhSachCBGV = new List<CBGV>();
            int chon;

            do
            {
                Console.WriteLine("\n----- MENU QUAN LY CBGV -----");
                Console.WriteLine("1. Nhap danh sach can bo giao vien");
                Console.WriteLine("2. Hien thi danh sach can bo giao vien");
                Console.WriteLine("3. Tim theo que quan");
                Console.WriteLine("4. Hien thi CBGV co luong thuc linh > 5tr");
                Console.WriteLine("5. Thoat");
                Console.Write("Nhap lua chon: ");
                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        Console.Write("Nhap so luong CBGV: ");
                        int n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"\nNhap thong tin CBGV thu {i + 1}:");
                            CBGV cb = new CBGV();
                            cb.Nhap();
                            danhSachCBGV.Add(cb);
                        }
                        break;

                    case 2:
                        Console.WriteLine("\n--- Danh sach CBGV ---");
                        foreach (var cb in danhSachCBGV)
                        {
                            cb.HienThi();
                        }
                        break;

                    case 3:
                        Console.Write("Nhap que quan can tim: ");
                        string que = Console.ReadLine();
                        Console.WriteLine($"\nCBGV co que quan '{que}':");
                        foreach (var cb in danhSachCBGV)
                        {
                            if (cb.ThongTinCaNhan.QueQuan.ToLower() == que.ToLower())
                            {
                                cb.HienThi();
                            }
                        }
                        break;

                    case 4:
                        Console.WriteLine("\nCBGV co luong > 5tr:");
                        foreach (var cb in danhSachCBGV)
                        {
                            if (cb.LuongThucLinh > 5000000)
                            {
                                cb.HienThi();
                            }
                        }
                        break;

                    case 5:
                        Console.WriteLine("Thoat chuong trinh.");
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }

            } while (chon != 5);
        }
    }
}
