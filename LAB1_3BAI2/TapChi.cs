using System;

namespace LAB1_3BAI2
{
    class TapChi : TaiLieu
    {
        public  int SoPhatHanh { get; set; }
        public int ThangPhatHanh { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("So phat hanh:");
            SoPhatHanh = int.Parse(Console.ReadLine());

            Console.Write("Thang phat hanh: ");
            ThangPhatHanh = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Tap chi - So phat hanh: {SoPhatHanh}, Thang phat hanh : {ThangPhatHanh}");
        }
    }
}
