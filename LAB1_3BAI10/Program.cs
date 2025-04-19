using System;

namespace LAB1_3BAI10
{
    class Program
    {
        static void Main(string[] args)
        {
            VanBan vb = new VanBan();
            int luaChon;

            do
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("1. Nhập văn bản");
                Console.WriteLine("2. Đếm số từ trong văn bản");
                Console.WriteLine("3. Đếm số ký tự 'H' trong văn bản");
                Console.WriteLine("4. Chuẩn hóa văn bản");
                Console.WriteLine("5. Thoát chương trình");
                Console.Write("Chọn chức năng: ");
                luaChon = int.Parse(Console.ReadLine());

                switch (luaChon)
                {
                    case 1:
                        Console.Write("Nhập văn bản: ");
                        vb.XauKyTu = Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine($"Số từ trong văn bản: {vb.DemSoTu()}");
                        break;

                    case 3:
                        Console.WriteLine($"Số ký tự 'H' trong văn bản: {vb.DemSoKyTuH()}");
                        break;

                    case 4:
                        vb.ChuanHoaXau();
                        vb.XuatXau();
                        break;

                    case 5:
                        Console.WriteLine("Thoát chương trình.");
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }

            } while (luaChon != 5);
        }
    }
}
