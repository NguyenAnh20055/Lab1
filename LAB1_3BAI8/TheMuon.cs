using System;

namespace LAB1_3BAI8
{
    class TheMuon
    {
        public string SoPhieuMuon { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime HanTra { get; set; }
        public string SoHieuSach { get; set; }
        public SinhVien SV { get; set; }

        public void Nhap()
        {
            SV = new SinhVien();
            Console.WriteLine("== Nhập thông tin sinh viên ==");
            SV.Nhap();

            Console.Write("Nhập số phiếu mượn: ");
            SoPhieuMuon = Console.ReadLine();
            Console.Write("Nhập ngày mượn (yyyy-mm-dd): ");
            NgayMuon = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhập hạn trả (yyyy-mm-dd): ");
            HanTra = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhập số hiệu sách: ");
            SoHieuSach = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.WriteLine($"== Thẻ mượn - Số phiếu: {SoPhieuMuon} ==");
            SV.Xuat();
            Console.WriteLine($"Ngày mượn: {NgayMuon.ToShortDateString()}, Hạn trả: {HanTra.ToShortDateString()}, Số hiệu sách: {SoHieuSach}");
        }
    }
}
