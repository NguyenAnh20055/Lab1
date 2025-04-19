using System;

namespace LAP1_3BAI14
{
     class Program
    {
        static void Main(string[] args)
        {
            PhanSo A = new PhanSo();
            PhanSo B = new PhanSo();

            Console.WriteLine("Nhập phân số A:");
            A.Nhap();
            Console.WriteLine("Nhập phân số B:");
            B.Nhap();

            int chon;
            do
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Hiển thị A và B");
                Console.WriteLine("2. Rút gọn A và B");
                Console.WriteLine("3. Cộng A + B");
                Console.WriteLine("4. Trừ A - B");
                Console.WriteLine("5. Nhân A * B");
                Console.WriteLine("6. Chia A / B");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn tác vụ: ");
                chon = int.Parse(Console.ReadLine());

                PhanSo kq;
                switch (chon)
                {
                    case 1:
                        Console.Write("Phân số A: "); A.HienThi();
                        Console.Write("Phân số B: "); B.HienThi();
                        break;

                    case 2:
                        A.RutGon();
                        B.RutGon();
                        Console.Write("A sau rút gọn: "); A.HienThi();
                        Console.Write("B sau rút gọn: "); B.HienThi();
                        break;

                    case 3:
                        kq = A.Cong(B);
                        kq.RutGon();
                        Console.Write("A + B = "); kq.HienThi();
                        break;

                    case 4:
                        kq = A.Tru(B);
                        kq.RutGon();
                        Console.Write("A - B = "); kq.HienThi();
                        break;

                    case 5:
                        kq = A.Nhan(B);
                        kq.RutGon();
                        Console.Write("A * B = "); kq.HienThi();
                        break;

                    case 6:
                        kq = A.Chia(B);
                        kq.RutGon();
                        Console.Write("A / B = "); kq.HienThi();
                        break;

                    case 0:
                        Console.WriteLine("Thoát chương trình.");
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            } while (chon != 0);
        }
    }
}
