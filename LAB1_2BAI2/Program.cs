using System;
namespace LAB1_2BAI2
{
    class Program
    {
        // Hàm nhập mảng
        public static void NhapMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        // Hàm kiểm tra số nguyên tố
        public static bool LaSoNguyenTo(int x)
        {
            if (x < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }
        // Hàm hiển thị chỉ số và giá trị các phần tử là số nguyên tố
        public static void HienThiSoNguyenTo(int[] a, int n)
        {
            Console.WriteLine("Các phần tử là số nguyên tố trong mảng:");
            for (int i = 0; i < n; i++)
            {
                if (LaSoNguyenTo(a[i]))
                {
                    Console.WriteLine($"a[{i}] = {a[i]}");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n;
            Console.Write("Nhập n: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            NhapMang(a, n);
            HienThiSoNguyenTo(a, n);
        }
    }
}