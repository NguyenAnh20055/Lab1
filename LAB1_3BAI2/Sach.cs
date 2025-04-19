using System;

namespace LAB1_3BAI2
{
    class Sach : TaiLieu
    {
        public string TenTacGia { get; set; }
        public int SoTrang { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Tac gia: ");
            TenTacGia = Console.ReadLine();

            Console.Write(" So trang : ");
            SoTrang = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Sach - Ten tac gia : {TenTacGia}, So trang: {SoTrang}");
        }
    }
}
