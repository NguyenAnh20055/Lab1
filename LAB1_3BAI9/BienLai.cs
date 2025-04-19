using System;

namespace LAB1_3BAI9
{
    internal class BienLai
    {
        public KhachHang khachHang { get; set; }
        public int ChiSoCu { get; set; }
        public int ChiSoMoi { get; set; }
        public double TienPhaiTra { get; set; }

        public BienLai()
        {
            khachHang = new KhachHang();
        }

        public void Nhap()
        {
            Console.WriteLine("Nhập thông tin khách hàng:");
            khachHang.Nhap();
            Console.Write("- Nhập chỉ số cũ: ");
            ChiSoCu = int.Parse(Console.ReadLine());
            Console.Write("- Nhập chỉ số mới: ");
            ChiSoMoi = int.Parse(Console.ReadLine());
            TinhTien();
        }

        public void Xuat()
        {
            khachHang.Xuat();
            Console.WriteLine($"Chỉ số cũ: {ChiSoCu} | Chỉ số mới: {ChiSoMoi} | Tiền phải trả: {TienPhaiTra} VND");
            Console.WriteLine("---------------------------------------------------");
        }

        public void TinhTien()
        {
            int soDien = ChiSoMoi - ChiSoCu;
            if (soDien <= 50)
                TienPhaiTra = soDien * 1250;
            else if (soDien < 100)
                TienPhaiTra = soDien * 1500;
            else
                TienPhaiTra = soDien * 2000;
        }
    }
}
