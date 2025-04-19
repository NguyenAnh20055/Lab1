using System;

namespace LAB1_3BAI1
{
     class NhanVien : CanBo
    {
        public string CongViec { get; set; }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("- Nhap cong viec: ");
            CongViec = Console.ReadLine();
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Loai: Nhan vien, Cong viec: {CongViec}");
            Console.WriteLine("-----------------------------------");
        }
    }
}
