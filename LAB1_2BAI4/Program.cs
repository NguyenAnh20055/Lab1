using System;
namespace LAB1_2BAI4
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
        // Hàm tìm số lớn thứ hai trong mảng
        public static int TimSoLonThuHai(int[] a, int n)
        {
            int max1 = int.MinValue;
            int max2 = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                if (a[i] > max1)
                {
                    max2 = max1;
                    max1 = a[i];
                }
                else if (a[i] > max2 && a[i] != max1)
                {
                    max2 = a[i];
                }
            }
            return (max2 == int.MinValue) ? -1 : max2; // Trả về -1 nếu không có số lớn thứ hai
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n;
            Console.Write("Nhập n: ");
            n = int.Parse(Console.ReadLine());
            if (n < 2)
            {
                Console.WriteLine("Cần ít nhất 2 phần tử để tìm số lớn thứ hai.");
                return;
            }
            int[] a = new int[n];
            // Gọi hàm nhập mảng
            NhapMang(a, n);
            // Gọi hàm tìm số lớn thứ hai và hiển thị kết quả
            int soLonThuHai = TimSoLonThuHai(a, n);
            if (soLonThuHai == -1)
                Console.WriteLine("Không tồn tại số lớn thứ hai trong mảng.");
            else
                Console.WriteLine($"Số lớn thứ hai trong mảng là: {soLonThuHai}");
        }
    }
}
