using System;

namespace LAB1_3BAI1
{
    class QLCB
    {
        private List<CanBo> DanhSach = new List<CanBo>();
        public void ThemCanBo()
        {
            Console.WriteLine("\n Chon loai can bo muon them: ");
            Console.WriteLine(" 1.Cong nhan ");
            Console.WriteLine(" 2.Ky su ");
            Console.WriteLine(" 3.Nhan vien ");
            Console.WriteLine(" Nhap lua chon:  ");
            int chon = int.Parse(Console.ReadLine());

            CanBo cb = null;

            switch (chon)
            {
                case 1:
                    {
                        cb = new CongNhan();
                        break;
                    }
                case 2:
                    {
                        cb = new KySu();
                        break;
                    }
                case 3:
                    {
                        cb = new NhanVien();
                        break;
                    }
                default:
                    Console.WriteLine("Lua chon khong hop le.");
                    return;
            }
            cb.Nhap();
            DanhSach.Add(cb);
        }

        public void TimKiemTheoTen()
        {
            Console.WriteLine(" Nhap ten can tim: ");
            string ten = Console.ReadLine().ToLower();//chuyển chuỗi nhập vào thành chữ thường để việc so sánh sau này không phân biệt hoa thường.
            bool timThay = false; //kdl có 2 giá trị true /false

            foreach (var cb in DanhSach)
            {
                if (cb.HoTen.ToLower().Contains(ten))//.Contains(ten): kiểm tra xem chuỗi ten (tên người dùng nhập vào) có nằm trong họ tên hay không
                {                    
                    cb.Xuat();
                    timThay = true;
                }
            }
            if (!timThay)
            {
                Console.WriteLine("Khong tim thay can bo.");
            }
        }

        public void HienThiDanhSach()
        {
            if (DanhSach.Count == 0)
            {
                Console.WriteLine("Danh sach rong.");
                return;
            } 
                Console.WriteLine("\nDanh sach can bo :");
                foreach (var cb in DanhSach)
                {
                    cb.Xuat();
                }
        }
    }
}

