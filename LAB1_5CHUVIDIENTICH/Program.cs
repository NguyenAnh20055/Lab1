using System;
using System.Collections.Generic;
using HinhHoc;

namespace LAB1_5CHUVIDIENTICH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Hinh> danhSach = new List<Hinh>();
            bool tiepTuc = true;

            while (tiepTuc)
            {
                Console.WriteLine("\nChọn loại hình:");
                Console.WriteLine("1. Hình tròn");
                Console.WriteLine("2. Hình vuông");
                Console.WriteLine("3. Hình chữ nhật");
                Console.WriteLine("4. Hình tam giác");
                Console.WriteLine("0. Thoát và tính tổng");
                Console.Write("Lựa chọn: ");
                int chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        Console.Write("Nhập bán kính: ");
                        double r = double.Parse(Console.ReadLine());
                        danhSach.Add(new HinhTron(r));
                        break;

                    case 2:
                        Console.Write("Nhập cạnh: ");
                        double canh = double.Parse(Console.ReadLine());
                        danhSach.Add(new HinhVuong(canh));
                        break;

                    case 3:
                        Console.Write("Nhập chiều dài: ");
                        double dai = double.Parse(Console.ReadLine());
                        Console.Write("Nhập chiều rộng: ");
                        double rong = double.Parse(Console.ReadLine());
                        danhSach.Add(new HinhChuNhat(dai, rong));
                        break;

                    case 4:
                        Console.Write("Nhập cạnh a: ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Nhập cạnh b: ");
                        double b = double.Parse(Console.ReadLine());
                        Console.Write("Nhập cạnh c: ");
                        double c = double.Parse(Console.ReadLine());
                        if (a + b > c && a + c > b && b + c > a)
                        {
                            danhSach.Add(new HinhTamGiac(a, b, c));
                        }
                        else
                        {
                            Console.WriteLine("Không tạo thành tam giác hợp lệ.");
                        }
                        break;

                    case 0:
                        tiepTuc = false;
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }
            }

            // Tính tổng chu vi và diện tích
            double tongChuVi = 0;
            double tongDienTich = 0;

            foreach (Hinh h in danhSach)
            {
                tongChuVi += h.TinhChuVi();
                tongDienTich += h.TinhDienTich();
            }

            Console.WriteLine($"\nTổng chu vi các hình: {tongChuVi:F2}");
            Console.WriteLine($"Tổng diện tích các hình: {tongDienTich:F2}");
        }
    }
}

