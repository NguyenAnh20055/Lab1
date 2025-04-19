using System;

namespace LAB1_3BAI13
{
     class PTGT
    {
        public string HangSanXuat { get; set; }
        public int NamSanXuat { get; set; }
        public double GiaBan { get; set; }
        public string Mau { get; set; }

        public virtual void Nhap()
        {
            Console.Write("Hãng sản xuất: ");
            HangSanXuat = Console.ReadLine();
            Console.Write("Năm sản xuất: ");
            NamSanXuat = int.Parse(Console.ReadLine());
            Console.Write("Giá bán: ");
            GiaBan = double.Parse(Console.ReadLine());
            Console.Write("Màu: ");
            Mau = Console.ReadLine();
        }

        public virtual void HienThi()
        {
            Console.WriteLine($"Hãng: {HangSanXuat}, Năm: {NamSanXuat}, Giá: {GiaBan}, Màu: {Mau}");
        }
    }
}
