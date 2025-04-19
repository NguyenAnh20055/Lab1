using System;
namespace LAB1_2BAI6
{
    class Program
    {
        // Hàm nhập mảng
        public static void NhapMang(double[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}]: ");
                a[i] = double.Parse(Console.ReadLine());
            }
        }
        // Hàm sắp xếp mảng theo chiều tăng dần (Sắp xếp nổi bọt)
        public static void SapXepTang(double[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        // Hoán vị
                        double temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Khai báo biến n
            int n;
            Console.Write("Nhập n: ");
            n = int.Parse(Console.ReadLine());
            // Khai báo và khởi tạo mảng số thực có n phần tử
            double[] a = new double[n];
            // Gọi hàm nhập mảng
            NhapMang(a, n);
            SapXepTang(a, n);
            // Hiển thị mảng sau khi sắp xếp
            Console.WriteLine("Mảng sau khi sắp xếp theo chiều tăng dần:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"a[{i}] = {a[i]}");
            }
        }
    }
}