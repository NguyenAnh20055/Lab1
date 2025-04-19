using System;

namespace LAB1_3BAI3
{
    class TuyenSinh
    {
        private List<ThiSinh> danhSachThiSinh = new List<ThiSinh>();

        public void NhapThiSinh()
        {
            Console.Write("Nhập số lượng thí sinh: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"-- Nhập thông tin thí sinh thứ {i + 1} --");
                Console.WriteLine("1. Khối A\n2. Khối B\n3. Khối C");
                Console.Write("Chọn khối: ");
                int loai = int.Parse(Console.ReadLine());

                ThiSinh ts;
                switch (loai)
                {
                    case 1:
                        ts = new ThiSinhKhoiA();
                        break;
                    case 2:
                        ts = new ThiSinhKhoiB();
                        break;
                    case 3:
                        ts = new ThiSinhKhoiC();
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ, bỏ qua...");
                        continue;
                }

                ts.Nhap();
                danhSachThiSinh.Add(ts);
            }
        }

        public void HienThiTrungTuyen()
        {
            Console.WriteLine("\n-- Danh sách thí sinh trúng tuyển --");
            foreach (var ts in danhSachThiSinh)
            {
                if ((ts is ThiSinhKhoiA && ts.TongDiem() >= 15) ||
                    (ts is ThiSinhKhoiB && ts.TongDiem() >= 16) ||
                    (ts is ThiSinhKhoiC && ts.TongDiem() >= 13.5))
                {
                    ts.Xuat();
                }
            }
        }

        public void TimKiemTheoSBD()
        {
            Console.Write("\nNhập số báo danh cần tìm: ");
            string sbd = Console.ReadLine();
            foreach (var ts in danhSachThiSinh)
            {
                if (ts.SoBaoDanh.Equals(sbd, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("-- Thông tin thí sinh tìm được --");
                    ts.Xuat();
                    return;
                }
            }
            Console.WriteLine("Không tìm thấy thí sinh!");
        }
    }
}
