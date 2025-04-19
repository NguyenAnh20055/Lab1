using System;

namespace LAB1_3BAI8
{
    class SinhVien
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string Lop { get; set; }
        public string MaSV { get; set; }

        public void Nhap()
        {
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập năm sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhập lớp: ");
            Lop = Console.ReadLine();
            Console.Write("Nhập mã số sinh viên: ");
            MaSV = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Năm sinh: {NamSinh}, Lớp: {Lop}, Mã SV: {MaSV}");
        }
    }
}
