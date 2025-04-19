using System;
using System.Collections.Generic;

namespace LAB1_5PHANSO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<PhanSo> danhSach = new List<PhanSo>();

            Console.Write("Nhập số lượng phân số: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập phân số thứ {i + 1}:");
                PhanSo ps = new PhanSo();
                ps.Nhap();
                danhSach.Add(ps);
            }

            PhanSo tong = new PhanSo(0, 1);
            foreach (PhanSo ps in danhSach)
            {
                tong = PhanSo.Cong(tong, ps);
            }

            Console.WriteLine("\nTổng các phân số là:");
            tong.HienThi();
        }
    }
}

