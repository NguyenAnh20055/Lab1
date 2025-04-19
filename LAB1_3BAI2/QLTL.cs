using System; 
namespace LAB1_3BAI2
{
     class QLTL
    {
        private List<TaiLieu> danhsach = new List<TaiLieu>();
        
        public void NhapTaiLieu()
        {
            Console.WriteLine(" Chon tai lei can them : ");
            Console.WriteLine(" 1 . Sach ");
            Console.WriteLine(" 2 . Tap Chi ");
            Console.WriteLine(" 3 . Bao ");
            Console.WriteLine("Nhap lua chon: ");
            int chon = int.Parse(Console.ReadLine());

            TaiLieu tl = null;

            switch (chon)
            {
                case 1:
                    tl = new Sach();
                    break;
                case 2:
                    tl = new TapChi();
                    break;
                case 3:
                    tl = new Bao();
                    break;
                default:
                    Console.Write("Lua chon khong hop le! ");
                    break;

            }

            tl.Nhap();
            danhsach.Add(tl);
        }
        public void HienThiTaiLieu()
        {
            Console.WriteLine("Hien Thi Danh Sach Tai Lieu :");
            foreach(var tl in danhsach)
            {
                tl.Xuat();
            }
        }
        
        public void TimKiemTheoLoai()
        {
            Console.WriteLine("\nChon loai can tim:");
            Console.WriteLine("1. Sach");
            Console.WriteLine("2. Tap chi");
            Console.WriteLine("3. Bao");
            Console.Write(" Nhap lua chon: ");
            int chon = int.Parse(Console.ReadLine());

            foreach(var tl in danhsach)
            {
                switch (chon)
                {
                    case 1:
                        if (tl is Sach)
                            tl.Xuat();
                        break;
                    case 2:
                        if (tl is TapChi)
                            tl.Xuat();
                        break;
                    case 3:
                        if (tl is Bao)
                            tl.Xuat();
                        break;
                }
            }
        }
    }
}
