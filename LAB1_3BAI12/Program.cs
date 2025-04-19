using System;

namespace LAB1_3BAI13
{
    class Program
    {
        static void Main(string[] args)
        {
            QLPTGT ql = new QLPTGT();
            while (true)
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Nhập đăng ký phương tiện");
                Console.WriteLine("2. Hiển thị tất cả phương tiện");
                Console.WriteLine("3. Tìm phương tiện theo màu");
                Console.WriteLine("4. Tìm phương tiện theo năm sản xuất");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn: ");
                int chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1: ql.NhapPT(); break;
                    case 2: ql.HienThiTatCa(); break;
                    case 3: ql.TimTheoMau(); break;
                    case 4: ql.TimTheoNam(); break;
                    case 0: return;
                    default: Console.WriteLine("Chọn sai!"); break;
                }
            }
        }
    }
}