using System;

namespace LAB1_3BAI9
{
    class KhachHang
    {
        public string HoTen { get; set; }
        public string SoNha { get; set; }
        public string MaCongTo { get; set; }

        public void Nhap()
        {
            Console.Write("- Nhập họ tên chủ hộ: ");
            HoTen = Console.ReadLine();
            Console.Write("- Nhập số nhà: ");
            SoNha = Console.ReadLine();
            Console.Write("- Nhập mã công tơ: ");
            MaCongTo = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.WriteLine($"Họ tên: {HoTen} | Số nhà: {SoNha} | Mã công tơ: {MaCongTo}");
        }
    }
}
