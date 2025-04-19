using System;

namespace LAB1_5PHANSO
{
    class PhanSo
    {
        public int Tu { get; set; }
        public int Mau { get; set; }

        public PhanSo()
        {
            Tu = 0;
            Mau = 1;
        }

        public PhanSo(int tu, int mau)
        {
            Tu = tu;
            Mau = (mau == 0) ? 1 : mau;
        }

        public void Nhap()
        {
            Console.Write("Nhập tử số: ");
            Tu = int.Parse(Console.ReadLine());

            Console.Write("Nhập mẫu số: ");
            Mau = int.Parse(Console.ReadLine());

            if (Mau == 0)
            {
                Console.WriteLine("Mẫu không được bằng 0. Đặt lại mẫu = 1.");
                Mau = 1;
            }
        }
        public void RutGon()
        {
            int ucln = UCLN(Math.Abs(Tu), Math.Abs(Mau));
            Tu /= ucln;
            Mau /= ucln;

            if (Mau < 0)
            {
                Tu = -Tu;
                Mau = -Mau;
            }
        }
        private int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
        public static PhanSo Cong(PhanSo a, PhanSo b)
        {
            int tuMoi = a.Tu * b.Mau + b.Tu * a.Mau;
            int mauMoi = a.Mau * b.Mau;
            PhanSo tong = new PhanSo(tuMoi, mauMoi);
            tong.RutGon();
            return tong;
        }
        public void HienThi()
        {
            Console.WriteLine($"{Tu}/{Mau}");
        }
    }
}

