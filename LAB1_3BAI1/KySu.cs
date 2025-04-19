using System;

namespace LAB1_3BAI1
{
    class KySu : CanBo
    {
        public string NganhDT { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write(" Nhap nganh dao tao :");
            NganhDT = Console.ReadLine();

        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Loai : Ky su thuoc nganh dao tao : {NganhDT}");
            Console.WriteLine("---------------------------------------------------");

        }
    }
}
