using System;

namespace LAB1_3BAI10
{
     class VanBan
    {
        public string XauKyTu { get; set; }
        // Hàm tạo không có đối số
        public VanBan()
        {
            XauKyTu = string.Empty;
        }
        // Hàm tạo có đối số
        public VanBan(string st)
        {
            XauKyTu = st;
        }
        // Phương thức đếm số từ trong xâu
        public int DemSoTu()
        {
            if (string.IsNullOrWhiteSpace(XauKyTu))
                return 0;
            string[] tu = XauKyTu.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return tu.Length;
        }
        // Phương thức đếm số ký tự 'H' 
        public int DemSoKyTuH()
        {
            int dem = 0;
            foreach (char c in XauKyTu.ToLower())
            {
                if (c == 'h')
                    dem++;
            }
            return dem;
        }

        // Phương thức chuẩn hoá xâu
        public void ChuanHoaXau()
        {
            XauKyTu = XauKyTu.Trim(); // Xoá khoảng trắng ở đầu và cuối
            while (XauKyTu.Contains("  ")) // Xoá các khoảng trắng liền nhau ở giữa
            {
                XauKyTu = XauKyTu.Replace("  ", " ");
            }
        }
        public void XuatXau()
        {
            Console.WriteLine("Xâu văn bản: " + XauKyTu);
        }
    }
}
