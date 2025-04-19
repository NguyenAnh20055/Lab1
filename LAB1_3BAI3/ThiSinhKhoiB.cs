using System;

namespace LAB1_3BAI3
{
    class ThiSinhKhoiB : ThiSinh
    {
        public double Toan, Hoa, Sinh;

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập điểm Toán: ");
            Toan = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm Hóa: ");
            Hoa = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm Sinh: ");
            Sinh = double.Parse(Console.ReadLine());
        }

        public override double TongDiem()
        {
            return Toan + Hoa + Sinh + UuTien;
        }

        public override void Xuat()
        {
            Console.WriteLine($"Khối B - SBD: {SoBaoDanh}, Họ tên: {HoTen}, Tổng điểm: {TongDiem()}");
        }
    }
}
