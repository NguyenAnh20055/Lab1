using System;

namespace LAB1_3BAI13
{
    internal class QLPTGT
    {
        private List<PTGT> dsPT = new List<PTGT>();

        public void NhapPT()
        {
            Console.WriteLine("Chọn loại phương tiện (1. Ô tô | 2. Xe máy | 3. Xe tải): ");
            int loai = int.Parse(Console.ReadLine());
            PTGT pt;
            switch (loai)
            {
                case 1: pt = new OTo(); break;
                case 2: pt = new XeMay(); break;
                case 3: pt = new XeTai(); break;
                default: Console.WriteLine("Không hợp lệ!"); return;
            }
            pt.Nhap();
            dsPT.Add(pt);
        }

        public void HienThiTatCa()
        {
            foreach (var pt in dsPT)
            {
                pt.HienThi();
                Console.WriteLine("------------------------------------");
            }
        }

        public void TimTheoMau()
        {
            Console.Write("Nhập màu cần tìm: ");
            string mau = Console.ReadLine().ToLower();
            foreach (var pt in dsPT)
            {
                if (pt.Mau.ToLower() == mau)
                    pt.HienThi();
            }
        }

        public void TimTheoNam()
        {
            Console.Write("Nhập năm sản xuất cần tìm: ");
            int nam = int.Parse(Console.ReadLine());
            foreach (var pt in dsPT)
            {
                if (pt.NamSanXuat == nam)
                    pt.HienThi();
            }
        }
    }
}
