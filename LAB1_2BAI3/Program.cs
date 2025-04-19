using System;
namespace LAB1_2BAI3
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
        // Hàm đếm số âm
        public static int DemSoAm(int[] a, int n)
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] < 0)
                    dem++;
            }
            return dem;
        }
        // Hàm đếm số dương
        public static int DemSoDuong(int[] a, int n)
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] > 0)
                    dem++;
            }
            return dem;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n;
            Console.Write("Nhập n: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            NhapMang(a, n);
            Console.WriteLine($"Số lượng số âm = {DemSoAm(a, n)}");
            Console.WriteLine($"Số lượng số dương = {DemSoDuong(a, n)}");
        }
    }
}