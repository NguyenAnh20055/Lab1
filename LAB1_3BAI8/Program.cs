using System;
using System.Collections.Generic;

namespace LAB1_3BAI8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TheMuon> danhSach = new List<TheMuon>();
            int luaChon;

            do
            {
                Console.WriteLine("\n=== MENU ===");
                Console.WriteLine("1. Nhập danh sách thẻ mượn");
                Console.WriteLine("2. Hiển thị tất cả thông tin thẻ mượn");
                Console.WriteLine("3. Tìm kiếm theo mã số sinh viên");
                Console.WriteLine("4. Hiển thị sinh viên đến hạn trả sách");
                Console.WriteLine("5. Thoát");
                Console.Write("Chọn: ");
                luaChon = int.Parse(Console.ReadLine());

                switch (luaChon)
                {
                    case 1:
                        Console.Write("Nhập số lượng thẻ mượn: ");
                        int n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"\nNhập thông tin thẻ mượn thứ {i + 1}:");
                            TheMuon tm = new TheMuon();
                            tm.Nhap();
                            danhSach.Add(tm);
                        }
                        break;

                    case 2:
                        Console.WriteLine("\n== Danh sách thẻ mượn ==");
                        foreach (var tm in danhSach)
                        {
                            tm.Xuat();
                            Console.WriteLine();
                        }
                        break;

                    case 3:
                        Console.Write("Nhập mã số sinh viên cần tìm: ");
                        string maTim = Console.ReadLine();
                        foreach (var tm in danhSach)
                        {
                            if (tm.SV.MaSV == maTim)
                            {
                                tm.Xuat();
                                Console.WriteLine();
                            }
                        }
                        break;

                    case 4:
                        DateTime ngayHienTai = DateTime.Today;
                        Console.WriteLine($"\n== Sinh viên đến hạn trả sách trước ngày {ngayHienTai.ToShortDateString()} ==");
                        foreach (var tm in danhSach)
                        {
                            if (tm.HanTra < ngayHienTai)
                            {
                                tm.Xuat();
                                Console.WriteLine();
                            }
                        }
                        break;

                    case 5:
                        Console.WriteLine("Đã thoát chương trình.");
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            } while (luaChon != 5);
        }
    }
}
