using System;

namespace LAB1_3BAI13
{
    class XeMay : PTGT
    {
        public double CongSuat { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Công suất: ");
            CongSuat = double.Parse(Console.ReadLine());
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Loại: Xe máy - Công suất: {CongSuat}");
        }
    }
}
