using System;
using System.Collections.Generic;

namespace LAB1_3BAI5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<KhachSan> danhSachKhach = new List<KhachSan>();
            int chon;

            do
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("1. Nhập danh sách khách trọ");
                Console.WriteLine("2. Hiển thị thông tin tất cả khách trọ");
                Console.WriteLine("3. Tìm kiếm khách theo họ tên");
                Console.WriteLine("4. Tính tiền cho khách trả phòng");
                Console.WriteLine("5. Thoát");
                Console.Write("Chọn chức năng: ");
                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        Console.Write("Nhập số lượng khách trọ: ");
                        int n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"\n>> Khách thứ {i + 1}:");
                            KhachSan ks = new KhachSan();
                            ks.Nhap();
                            danhSachKhach.Add(ks);
                        }
                        break;

                    case 2:
                        Console.WriteLine("\n== Danh sách khách trọ ==");
                        foreach (var khach in danhSachKhach)
                        {
                            khach.Xuat();
                            Console.WriteLine("----------------------------------");
                        }
                        break;

                    case 3:
                        Console.Write("Nhập họ tên khách cần tìm: ");
                        string tenTim = Console.ReadLine();
                        var timThay = false;
                        foreach (var khach in danhSachKhach)
                        {
                            if (khach.Khach.HoTen.ToLower().Contains(tenTim.ToLower()))
                            {
                                khach.Xuat();
                                Console.WriteLine("----------------------------------");
                                timThay = true;
                            }
                        }
                        if (!timThay)
                        {
                            Console.WriteLine("Không tìm thấy khách nào.");
                        }
                        break;

                    case 4:
                        Console.Write("Nhập họ tên khách cần tính tiền: ");
                        string tenTT = Console.ReadLine();
                        foreach (var khach in danhSachKhach)
                        {
                            if (khach.Khach.HoTen.ToLower().Contains(tenTT.ToLower()))
                            {
                                double tien = khach.TinhTien();
                                Console.WriteLine($"Khách {khach.Khach.HoTen} cần thanh toán: {tien} VNĐ");
                            }
                        }
                        break;

                    case 5:
                        Console.WriteLine("Chương trình kết thúc.");
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }

            } while (chon != 5);
        }
    }
}
