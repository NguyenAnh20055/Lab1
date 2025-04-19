using System;

namespace LAB1_3BAI11
{
    class Program
    {
        static void Main(string[] args)
        {
            SoPhuc A = new SoPhuc();
            SoPhuc B = new SoPhuc();

            Console.WriteLine("Nhập vào số phức A:");
            A.Nhap();
            Console.WriteLine("Nhập vào số phức B:");
            B.Nhap();

            int luaChon;
            do
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("1. Tính tổng hai số phức");
                Console.WriteLine("2. Tính hiệu hai số phức");
                Console.WriteLine("3. Tính tích hai số phức");
                Console.WriteLine("4. Tính thương hai số phức");
                Console.WriteLine("5. Thoát chương trình");
                Console.Write("Chọn chức năng: ");
                luaChon = int.Parse(Console.ReadLine());

                SoPhuc KQ;
                switch (luaChon)
                {
                    case 1:
                        KQ = A.Cộng(B);
                        Console.WriteLine("Tổng hai số phức A và B là: ");
                        KQ.HienThi();
                        break;

                    case 2:
                        KQ = A.Cộng(new SoPhuc(-B.PhanThuc, -B.PhanAo));
                        Console.WriteLine("Hiệu hai số phức A và B là: ");
                        KQ.HienThi();
                        break;

                    case 3:
                        KQ = A.Nhan(B);
                        Console.WriteLine("Tích hai số phức A và B là: ");
                        KQ.HienThi();
                        break;

                    case 4:
                        KQ = A.Chia(B);
                        Console.WriteLine("Thương hai số phức A và B là: ");
                        KQ.HienThi();
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
