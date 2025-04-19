using System;

namespace LAP1_3BAI14
{
    class PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }

        public PhanSo()
        {
            TuSo = 0;
            MauSo = 1;
        }

        public PhanSo(int tu, int mau)
        {
            TuSo = tu;
            MauSo = (mau == 0) ? 1 : mau;
        }

        public void Nhap()
        {
            Console.Write("Tử số: ");
            TuSo = int.Parse(Console.ReadLine());
            Console.Write("Mẫu số: ");
            MauSo = int.Parse(Console.ReadLine());
            if (MauSo == 0)
            {
                Console.WriteLine("Mẫu số không được bằng 0. Gán mẫu số = 1.");
                MauSo = 1;
            }
        }

        public void HienThi()
        {
            Console.WriteLine($"{TuSo}/{MauSo}");
        }

        private int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public void RutGon()
        {
            int ucln = UCLN(TuSo, MauSo);
            TuSo /= ucln;
            MauSo /= ucln;
            if (MauSo < 0)
            {
                TuSo = -TuSo;
                MauSo = -MauSo;
            }
        }

        public PhanSo Cong(PhanSo p)
        {
            int tu = TuSo * p.MauSo + p.TuSo * MauSo;
            int mau = MauSo * p.MauSo;
            return new PhanSo(tu, mau);
        }

        public PhanSo Tru(PhanSo p)
        {
            int tu = TuSo * p.MauSo - p.TuSo * MauSo;
            int mau = MauSo * p.MauSo;
            return new PhanSo(tu, mau);
        }

        public PhanSo Nhan(PhanSo p)
        {
            return new PhanSo(TuSo * p.TuSo, MauSo * p.MauSo);
        }

        public PhanSo Chia(PhanSo p)
        {
            return new PhanSo(TuSo * p.MauSo, MauSo * p.TuSo);
        }
    }
}
