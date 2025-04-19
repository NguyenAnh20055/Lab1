using System;

namespace LAB1_3BAI3
{
    abstract class ThiSinh
    {
        public string SoBaoDanh { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public int UuTien { get; set; }

        public ThiSinh() { }

        public ThiSinh(string soBaoDanh, string hoTen, string diaChi, int uuTien)
        {
            SoBaoDanh = soBaoDanh;
            HoTen = hoTen;
            DiaChi = diaChi;
            UuTien = uuTien;
        }

        public virtual void Nhap()
        {
            Console.Write("Nhập số báo danh: ");
            SoBaoDanh = Console.ReadLine();
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập địa chỉ: ");
            DiaChi = Console.ReadLine();
            Console.Write("Nhập ưu tiên: ");
            UuTien = int.Parse(Console.ReadLine());
        }

        public abstract double TongDiem();
        public abstract void Xuat();
    }
}
