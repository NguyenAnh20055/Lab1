using System;

namespace LAB1_3BAI7
{
    class Nguoi
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string QueQuan { get; set; }
        public string CMND { get; set; }

        public void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap que quan: ");
            QueQuan = Console.ReadLine();
            Console.Write("Nhap so CMND: ");
            CMND = Console.ReadLine();
        }

        public void HienThi()
        {
            Console.WriteLine($"Ho ten: {HoTen}, Nam sinh: {NamSinh}, Que quan: {QueQuan}, CMND: {CMND}");
        }
    }
}
