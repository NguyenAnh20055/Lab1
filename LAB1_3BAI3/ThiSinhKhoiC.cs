using System;

namespace LAB1_3BAI3
{
    class ThiSinhKhoiC : ThiSinh
    {
        public double Van, Su, Dia;

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập điểm Văn: ");
            Van = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm Sử: ");
            Su = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm Địa: ");
            Dia = double.Parse(Console.ReadLine());
        }

        public override double TongDiem()
        {
            return Van + Su + Dia + UuTien;
        }

        public override void Xuat()
        {
            Console.WriteLine($"Khối C - SBD: {SoBaoDanh}, Họ tên: {HoTen}, Tổng điểm: {TongDiem()}");
        }
    }
}
