using System;

namespace LAB1_3BAI2
{
    class Program
    {
        static void Main (string[] args)
        {
            QLTL ql = new QLTL();
            int chon;
            do
            {
                Console.WriteLine("\n--- MENU QUAN LY TAI LIEU ---");
                Console.WriteLine("1. Nhap tai lieu");
                Console.WriteLine("2. Hien thi tai lieu");
                Console.WriteLine("3. Tim kiem theo loai");
                Console.WriteLine("0. Thoat");
                Console.Write(" Nhap lua chon: ");
                chon = int.Parse(Console.ReadLine());

                switch (chon) {
                    case 1:
                        ql.NhapTaiLieu();
                        break;
                    case 2:
                        ql.HienThiTaiLieu();
                        break;
                    case 3:
                        ql.TimKiemTheoLoai();
                        break;
                    case 0:
                        Console.Write("Thoat");
                        break;
                    default:
                        Console.Write("Lua chon khong hop le.");
                        break;
                }
            } while (chon != 0);
        }
    }
}
