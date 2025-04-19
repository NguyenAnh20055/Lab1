using System;

namespace LAB1_3BAI2
{
    class Bao : TaiLieu
    {
        public DateTime NgayPhatHanh { get; set; }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Ngay phat hanh : ");
            NgayPhatHanh = DateTime.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($" Bao - Ngay Phat hanh: {NgayPhatHanh.ToString("dd/MM/yyyy")}");
        }

    }
}
