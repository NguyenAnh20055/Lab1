using System;

namespace LAB1_3BAI5
{
     class Nguoi
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string CMND { get; set; }

        public void Nhap()
        {
            Console.Write("- Nhập họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("- Nhập năm sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("- Nhập số CMND: ");
            CMND = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Năm sinh: {NamSinh}, CMND: {CMND}");
        }
    }
}
