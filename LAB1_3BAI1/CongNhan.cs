using System;

namespace LAB1_3BAI1
{
    class CongNhan : CanBo
    {
        public int Bac { get; set; } //bậc 1-7

        public override void Nhap()
        {
            base.Nhap();
            Console.Write(" Nhap bac cua cong nhan(1-7) :");
            Bac = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($" Loai: Cong nhan ,Bac : {Bac}/7");
            Console.WriteLine("------------------------------------");

        }
    }
    
}
