using System;
using System.Collections.Generic;

namespace LAB1_3BAI9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BienLai> danhSachBienLai = new List<BienLai>();
            int luaChon;

            do
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("1. Nhập thông tin biên lai");
                Console.WriteLine("2. Hiển thị thông tin các biên lai");
                Console.WriteLine("3. Thoát chương trình");
                Console.Write("Chọn chức năng: ");
                luaChon = int.Parse(Console.ReadLine());

                switch (luaChon)
                {
                    case 1:
                        Console.Write("- Nhập số lượng hộ dân: ");
                        int n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"\n>> Hộ dân thứ {i + 1}");
                            BienLai bl = new BienLai();
                            bl.Nhap();
                            danhSachBienLai.Add(bl);
                        }
                        break;

                    case 2:
                        Console.WriteLine("\nDanh sách biên lai:");
                        foreach (var bienLai in danhSachBienLai)
                        {
                            bienLai.Xuat();
                        }
                        break;

                    case 3:
                        Console.WriteLine("Thoát chương trình.");
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }

            } while (luaChon != 3);
        }
    }
}
