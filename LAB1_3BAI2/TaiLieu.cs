using System;

namespace LAB1_3BAI2
{
     class TaiLieu
    {
        public string MaTl { get; set; }
        public string TenNhaXuatBan { get; set; }
        public int SoBanPhatHanh { get; set; }
     
        public virtual void Nhap()
        {
            Console.Write("Nhap Ma tai lieu :");
            MaTl = Console.ReadLine();

            Console.Write("Nhap Ma tai lieu :");
            TenNhaXuatBan = Console.ReadLine();

            Console.Write("Nhap Ma tai lieu :");
            SoBanPhatHanh = int.Parse(Console.ReadLine());

        }
        public virtual void Xuat()
        {
            Console.WriteLine($"Ma so sach : {MaTl}, Nha xuat ban : {TenNhaXuatBan}, So ban phat hanh: {SoBanPhatHanh} ");

        }
    }
}
