using System;

namespace LAB1_3BAI4
{
     class Nguoi
    {
        public string CMND { get; set; }
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public int NamSinh { get; set; }
        public string NgheNghiep { get; set; }

        public void Nhap()
        {
            Console.Write("- Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("- Nhap so CMND: ");
            CMND = Console.ReadLine();
            Console.Write("- Nhap tuoi: ");
            Tuoi = int.Parse(Console.ReadLine());
            Console.Write("- Nhap nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("- Nhap nghe nghiep: ");
            NgheNghiep = Console.ReadLine();
        }

        public void HienThi()
        {
            Console.WriteLine($"  Ho ten: {HoTen}, CMND: {CMND}, Tuoi: {Tuoi}, Nam sinh: {NamSinh}, Nghe nghiep: {NgheNghiep}");
        }
    }
}
