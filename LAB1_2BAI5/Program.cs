using System;
namespace LAB1_2BAI5
{
    class Program
    {
        // Hàm hoán vị 2 số nguyên
        public static void HoanVi(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int a, b;
            // Nhập giá trị từ bàn phím
            Console.Write("Nhập a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhập b: ");
            b = int.Parse(Console.ReadLine());
            // Hiển thị trước khi hoán vị
            Console.WriteLine($"Trước khi hoán vị: a = {a}, b = {b}");
            HoanVi(ref a, ref b);
            // Hiển thị sau khi hoán vị
            Console.WriteLine($"Sau khi hoán vị: a = {a}, b = {b}");
        }
    }
}