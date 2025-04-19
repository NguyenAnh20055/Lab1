using System;

namespace LAB1_3BAI13
{
     class OTo : PTGT
    {
        public int SoChoNgoi { get; set; }
        public string KieuDongCo { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Số chỗ ngồi: ");
            SoChoNgoi = int.Parse(Console.ReadLine());
            Console.Write("Kiểu động cơ: ");
            KieuDongCo = Console.ReadLine();
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Loại: Ô tô - Số chỗ: {SoChoNgoi}, Động cơ: {KieuDongCo}");
        }
    }
}
