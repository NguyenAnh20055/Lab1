using System;

namespace LAB1_3BAI6
{
    class HSHocSinh
    {
        public string Lop { get; set; }
        public string KhoaHoc { get; set; }
        public string KyHoc { get; set; }
        public Nguoi ThongTinCaNhan { get; set; }

        public HSHocSinh()
        {
            ThongTinCaNhan = new Nguoi();
        }

        public void Nhap()
        {
            ThongTinCaNhan.Nhap();
            Console.Write("Nhap lop: ");
            Lop = Console.ReadLine();
            Console.Write("Nhap khoa hoc: ");
            KhoaHoc = Console.ReadLine();
            Console.Write("Nhap ky hoc: ");
            KyHoc = Console.ReadLine();
        }

        public void Xuat()
        {
            ThongTinCaNhan.Xuat();
            Console.WriteLine($"Lop: {Lop} | Khoa hoc: {KhoaHoc} | Ky hoc: {KyHoc}");
        }
    }
}
