using System; 

namespace LAB1_3BAI5
{
    class KhachSan
    {
        public Nguoi Khach { get; set; }
        public int SoNgayTro { get; set; }
        public string LoaiPhong { get; set; }
        public double GiaPhong { get; set; }

        public KhachSan()
        {
            Khach = new Nguoi();
        }

        public void Nhap()
        {
            Console.WriteLine("== Nhập thông tin khách thuê phòng ==");
            Khach.Nhap();
            Console.Write("- Nhập số ngày trọ: ");
            SoNgayTro = int.Parse(Console.ReadLine());
            Console.Write("- Nhập loại phòng: ");
            LoaiPhong = Console.ReadLine();
            Console.Write("- Nhập giá phòng mỗi ngày: ");
            GiaPhong = double.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("== Thông tin khách trọ ==");
            Khach.Xuat();
            Console.WriteLine($"Số ngày trọ: {SoNgayTro}, Loại phòng: {LoaiPhong}, Giá phòng/ngày: {GiaPhong} VNĐ");
        }

        public double TinhTien()
        {
            return SoNgayTro * GiaPhong;
        }
    }
}
