using System;

namespace LAB1_3BAI1
{
    class CanBo
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }

        public virtual void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhap nam sinh : ");
            NamSinh = int.Parse(Console.ReadLine());

            Console.Write("Nhap gioi tinh: ");
            GioiTinh = Console.ReadLine();

            Console.Write("Nhap dia chi : ");
            DiaChi = Console.ReadLine();
        }
        public virtual void Xuat()
        {
            Console.WriteLine($"Ho ten :{HoTen}, Nam sinh :{NamSinh} , Gioi tinh : {GioiTinh}, Dia chi :{DiaChi}");
        }
    


    }
}
