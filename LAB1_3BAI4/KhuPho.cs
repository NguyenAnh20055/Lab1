using System;

namespace LAB1_3BAI4
{
    class KhuPho
    {
        private List<HoDan> danhSachHoDan;

        public KhuPho()
        {
            danhSachHoDan = new List<HoDan>();
        }

        public void NhapDanhSach()
        {
            Console.Write("- Nhap so ho dan trong khu pho: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhap thong tin ho dan thu {i + 1}:");
                HoDan hoDan = new HoDan();
                hoDan.Nhap();
                danhSachHoDan.Add(hoDan);
            }
        }

        public void HienThiTatCa()
        {
            Console.WriteLine("\n=== Danh sach cac ho dan trong khu pho ===");
            foreach (var ho in danhSachHoDan)
            {
                ho.HienThi();
            }
        }

        public void TimTheoTen(string ten)
        {
            Console.WriteLine($"\n>>> Ket qua tim theo ho ten '{ten}':");
            bool timThay = false;
            foreach (var ho in danhSachHoDan)
            {
                if (ho.CoThanhVienTen(ten))
                {
                    ho.HienThi();
                    timThay = true;
                }
            }
            if (!timThay)
                Console.WriteLine("Khong tim thay ho dan nao co ten trung khop.");
        }

        public void TimTheoSoNha(string soNha)
        {
            Console.WriteLine($"\n>>> Ket qua tim theo so nha '{soNha}':");
            bool timThay = false;
            foreach (var ho in danhSachHoDan)
            {
                if (ho.SoNha == soNha)
                {
                    ho.HienThi();
                    timThay = true;
                }
            }
            if (!timThay)
                Console.WriteLine("Khong tim thay ho dan nao co so nha nay.");
        }
    }
}
