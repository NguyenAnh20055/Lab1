using System;

namespace LAB1_3BAI11
{
    class SoPhuc
    {
        public double PhanThuc { get; set; } // Phần thực
        public double PhanAo { get; set; }   // Phần ảo
        // Hàm tạo không có đối số
        public SoPhuc()
        {
            PhanThuc = 0;
            PhanAo = 0;
        }
        // Hàm tạo có đối số
        public SoPhuc(double a, double b)
        {
            PhanThuc = a;
            PhanAo = b;
        }
        // Phương thức nhập một số phức
        public void Nhap()
        {
            Console.Write("Nhập phần thực: ");
            PhanThuc = double.Parse(Console.ReadLine());
            Console.Write("Nhập phần ảo: ");
            PhanAo = double.Parse(Console.ReadLine());
        }
        // Phương thức hiển thị số phức
        public void HienThi()
        {
            string phanAoStr = PhanAo >= 0 ? $" + {PhanAo}i" : $" - {Math.Abs(PhanAo)}i";
            Console.WriteLine($"{PhanThuc}{phanAoStr}");
        }
        // Phương thức cộng hai số phức
        public SoPhuc Cộng(SoPhuc sp)
        {
            return new SoPhuc(PhanThuc + sp.PhanThuc, PhanAo + sp.PhanAo);
        }
        // Phương thức nhân hai số phức
        public SoPhuc Nhan(SoPhuc sp)
        {
            double a = PhanThuc * sp.PhanThuc - PhanAo * sp.PhanAo;
            double b = PhanThuc * sp.PhanAo + PhanAo * sp.PhanThuc;
            return new SoPhuc(a, b);
        }
        // Phương thức chia hai số phức
        public SoPhuc Chia(SoPhuc sp)
        {
            double mau = sp.PhanThuc * sp.PhanThuc + sp.PhanAo * sp.PhanAo;
            double a = (PhanThuc * sp.PhanThuc + PhanAo * sp.PhanAo) / mau;
            double b = (PhanAo * sp.PhanThuc - PhanThuc * sp.PhanAo) / mau;
            return new SoPhuc(a, b);
        }
    }
}
