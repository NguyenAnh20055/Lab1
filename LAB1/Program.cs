/*
// bai1 Viết chương trình nhập vào tên và tuổi, sau đó in ra màn hình thông báo "Xin chào
[tên], bạn [tuổi] tuổi!".
using System;
using System.Text;
namespace LAB1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string ten;
            int tuoi;
            Console.Write("Nhập tên của bạn: ");
            ten = Console.ReadLine();
            Console.Write("Nhập tuổi của bạn: ");
            tuoi = int.Parse(Console.ReadLine()); //chuyển đổi (parse) một chuỗi ký tự thành số nguyên (int).
            Console.WriteLine($"Xin chào {ten}, bạn {tuoi} tuổi! ");
        }
    }
}

*/

/*
 //bai2 Viết chương trình tính diện tích của hình chữ nhật khi người dùng nhập chiều dài và
chiều rộng.

using System;
using System.Text;
namespace LAB1_1
{
    class program
    {
        public void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double chieudai, chieurong , dientich;
            Console.WriteLine(" nhập chiều dài hình chữ nhật :");
            chieudai = double.Parse(Console.ReadLine());
            Console.WriteLine(" nhập chiều rộng hình chữ nhật :");
            chieurong = double.Parse(Console.ReadLine());
            dientich = chieudai * chieurong;
            Console.WriteLine($"Diện tích hình chữ nhật là: {dientich}");
        }
    }
}*/

/*
 //bai3 Viết chương trình chuyển đổi nhiệt độ từ độ C sang độ F
using System;
using System.Text;
namespace LAB1_1
{
    class program
    {
        public void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double doC, doF;
            Console.Write("Nhập nhiệt độ (°C): ");
            doC = double.Parse(Console.ReadLine());
            doF = (doC * 9 / 5) + 32;
            Console.WriteLine($"{doC}°C tương đương {doF}°F");
        }
    }
}
*/



/*
//bai4 Viết chương trình nhập vào một số nguyên và kiểm tra xem số đó có phải là số chẵn
hay không.

using System;
using System.Text;

namespace LAB1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int songuyen;
            Console.Write("Nhập một số nguyên: ");
            songuyen = int.Parse(Console.ReadLine());
            bool laSoChan = songuyen % 2 == 0;
            if (laSoChan)
            {
                Console.WriteLine($"{songuyen} là số chẵn.");
            }
            else
            {
                Console.WriteLine($"{songuyen} là số lẻ.");
            }
        }
    }
}*/



/*
//Bài 5: Viết chương trình tính tổng và tích của hai số nhập từ bàn phím.
using System;
using System.Text;

namespace LAB1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double sothunhat, sothuhai, tong, tich;
            Console.WriteLine("Nhập số thứ nhất:");
            sothunhat = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số thứ hai:");
            sothuhai = double.Parse(Console.ReadLine());
            tong = sothunhat + sothuhai;
            tich = sothunhat * sothuhai;
            Console.WriteLine($"Tổng của {sothunhat} và {sothuhai} là: {tong}");
            Console.WriteLine($"Tích của {sothunhat} và {sothuhai} là: {tich}");
        }
    }
}
*/


/*
//Bài 6: Viết chương trình kiểm tra xem một số nhập vào có phải là số dương, số âm hay số không
using System;
using System.Text;

namespace LAB1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double so;
            Console.Write("Nhập 1 số bất kỳ: ");
            so = double.Parse(Console.ReadLine());
            if (so > 0)
            {
                Console.WriteLine($"{so} là số dương.");
            }
            else if (so < 0)
            {
                Console.WriteLine($"{so} là số âm.");
            }
            else
            {
                Console.WriteLine("Số bạn vừa nhập là số 0.");
            }
        }
    }
}
*/


/*

//Bài 7: Viết chương trình kiểm tra xem một năm nhập vào có phải là năm nhuận hay không.
//(Năm nhuận là năm chia hết cho 4, trừ các năm chia hết cho 100 nhưng không chia hết cho 400). 
using System;
using System.Text;

namespace LAB1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int nam;
            Console.Write("Nhập 1 năm bất kỳ: ");
            nam = int.Parse(Console.ReadLine());
            bool lanamnhuan = (nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0);
            if (lanamnhuan)
            {
                Console.WriteLine($"{nam} là năm nhuận.");
            }
            else
            {
                Console.WriteLine($"{nam} không phải là năm nhuận.");
            }
        }
    }
}
*/


/*
//Bài 8: Viết chương trình in ra bảng cửu chương từ 1 đến 10
using System;
using System.Text;

namespace LAB1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // in bảng cửu chương từ 1 đến 10
            Console.WriteLine("Bảng cửu chương từ 1 đến 10:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Bảng cửu chương {i}:");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                Console.WriteLine(); // Dòng trống giữa các bảng cửu chương
            }
        }
    }
}*/



/*
//Bài 9: Viết chương trình tính giai thừa của một số nguyên dương n.
using System;
using System.Text;

namespace LAB1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            long giaithua = 1;
            Console.WriteLine("Nhập một số nguyên dương n:");
            Console.Write("n = ");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Bạn chưa nhập giá trị.");
                return;
            }
            if (!int.TryParse(input, out n))
            {
                Console.WriteLine("Giá trị bạn nhập không phải là một số nguyên hợp lệ.");
                return;
            }
            if (n <= 0)
            {
                Console.WriteLine("Vui lòng nhập một số nguyên dương.");
                return;
            }
            for (int i = 1; i <= n; i++)
            {
                giaithua *= i;
            }
            Console.WriteLine($"Giai thừa của {n} là: {giaithua}");
        }
    }
}


*/

//Bài 10: Viết chương trình kiểm tra xem một số có phải là số nguyên tố hay không

using System;
using System.Text;

namespace LAB1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int so;
            bool lasonguyento= true;
            Console.Write("Nhập một số nguyên: ");
            so = int.Parse(Console.ReadLine());
            if (so < 2)
            {
                lasonguyento = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(so); i++)
                {
                    if (so % i == 0)
                    {
                        lasonguyento = false;
                        break;
                    }
                }
            }
            if (lasonguyento)
            {
                Console.WriteLine($"{so} là số nguyên tố.");
            }
            else
            {
                Console.WriteLine($"{so} không phải là số nguyên tố.");
            }
        }
    }
}
