using System;

namespace LAB1_3BAI1
{
    class Program
    {
        static void Main(string[] args)
        {
            QLCB qlcb = new QLCB();
            int chon;

            do
            {
                Console.WriteLine("\n--- MENU QUAN LY CAN BO ---");
                Console.WriteLine("1. Them can bo");
                Console.WriteLine("2. Tim kiem theo ho ten");
                Console.WriteLine("3. Hien thi danh sach");
                Console.WriteLine("0. Thoat");
                Console.Write("- Nhap lua chon: ");
                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        qlcb.ThemCanBo();
                        break;
                    case 2:
                        qlcb.TimKiemTheoTen();
                        break;
                    case 3:
                        qlcb.HienThiDanhSach();
                        break;
                    case 0:
                        Console.WriteLine("Thoat chuong trinh.");
                        break;
                    default:
                        Console.WriteLine("Lua cjpn sai!");
                        break;
                } 
            } while (chon != 0);
        }
    }
}
