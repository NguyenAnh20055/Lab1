using System;

namespace LAB1_3BAI3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            TuyenSinh tuyenSinh = new TuyenSinh();
            int chon;

            do
            {
                Console.WriteLine("\n------ MENU ------");
                Console.WriteLine("1. Nhập thông tin thí sinh");
                Console.WriteLine("2. Hiển thị thí sinh trúng tuyển");
                Console.WriteLine("3. Tìm kiếm thí sinh theo SBD");
                Console.WriteLine("4. Thoát");
                Console.Write("Chọn: ");
                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        tuyenSinh.NhapThiSinh();
                        break;
                    case 2:
                        tuyenSinh.HienThiTrungTuyen();
                        break;
                    case 3:
                        tuyenSinh.TimKiemTheoSBD();
                        break;
                    case 4:
                        Console.WriteLine("Kết thúc chương trình.");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }

            } while (chon != 4);
        }
    }
}
