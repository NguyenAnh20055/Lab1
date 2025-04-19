using System;

namespace LAB1_3BAI3
{
    class ThiSinhKhoiA : ThiSinh
    {
        public double Toan, Ly, Hoa;

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập điểm Toán: ");
            Toan = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm Lý: ");
            Ly = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm Hóa: ");
            Hoa = double.Parse(Console.ReadLine());
        }

        public override double TongDiem()
        {
            return Toan + Ly + Hoa + UuTien;
        }

        public override void Xuat()
        {
            Console.WriteLine($"Khối A - SBD: {SoBaoDanh}, Họ tên: {HoTen}, Tổng điểm: {TongDiem()}");
        }
    }
}
