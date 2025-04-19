using System;

namespace LAB1_3BAI13
{
     class XeTai : PTGT
    {
        public double TrongTai { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Trọng tải: ");
            TrongTai = double.Parse(Console.ReadLine());
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Loại: Xe tải - Trọng tải: {TrongTai}");
        }
    }
}
