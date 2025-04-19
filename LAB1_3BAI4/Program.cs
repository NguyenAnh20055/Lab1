using System;

namespace LAB1_3BAI4
{
    class Program
    {
        static void Main(string[] args)
        {
            KhuPho khuPho = new KhuPho();
            int luaChon;

            do
            {
                Console.WriteLine("\n===== MENU CHUONG TRINH =====");
                Console.WriteLine("1. Nhap danh sach ho dan");
                Console.WriteLine("2. Hien thi thong tin cac ho dan");
                Console.WriteLine("3. Tim kiem ho dan theo ho ten");
                Console.WriteLine("4. Tim kiem ho dan theo so nha");
                Console.WriteLine("5. Thoat");
                Console.Write("- Moi ban chon: ");
                luaChon = int.Parse(Console.ReadLine());

                switch (luaChon)
                {
                    case 1:
                        khuPho.NhapDanhSach();
                        break;
                    case 2:
                        khuPho.HienThiTatCa();
                        break;
                    case 3:
                        Console.Write("- Nhap ho ten can tim: ");
                        string ten = Console.ReadLine();
                        khuPho.TimTheoTen(ten);
                        break;
                    case 4:
                        Console.Write("- Nhap so nha can tim: ");
                        string soNha = Console.ReadLine();
                        khuPho.TimTheoSoNha(soNha);
                        break;
                    case 5:
                        Console.WriteLine("Dang thoat chuong trinh...");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }
            } while (luaChon != 5);
        }
    }
}
