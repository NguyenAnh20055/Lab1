using System;

namespace LAB1_3BAI4
{
    class HoDan
    {
        public int SoThanhVien { get; set; }
        public string SoNha { get; set; }
        public List<Nguoi> ThanhVien { get; set; }

        public HoDan()
        {
            ThanhVien = new List<Nguoi>();
        }
        public void Nhap()
        {
            Console.Write("- Nhap so nha: ");
            SoNha = Console.ReadLine();
            Console.Write("- Nhap so thanh vien: ");
            SoThanhVien = int.Parse(Console.ReadLine());

            for (int i = 0; i < SoThanhVien; i++)
            {
                Console.WriteLine($"\n  Thanh vien thu {i + 1}:");
                Nguoi nguoi = new Nguoi();
                nguoi.Nhap();
                ThanhVien.Add(nguoi);
            }
        }
        public void HienThi()
        {
            Console.WriteLine($"\n> So nha: {SoNha}, So thanh vien: {SoThanhVien}");
            foreach (var tv in ThanhVien)
            {
                tv.HienThi();
            }
        }
        public bool CoThanhVienTen(string ten)
        {
            foreach (var tv in ThanhVien)
            {
                if (tv.HoTen.ToLower().Contains(ten.ToLower()))
                    return true;
            }
            return false;
        }
    }
}
