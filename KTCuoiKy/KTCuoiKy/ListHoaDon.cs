using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace KTCuoiKy
{
    class ListHoaDon
    {

        List<HoaDon> DS = new List<HoaDon>();
        public void nhap(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);
            XmlNodeList nodelistA = read.SelectNodes("/DSHD/HoaDon");
            foreach (XmlNode hoaDonNode in nodelistA)
            {
                HoaDon HD;
                int loai = Int32.Parse(hoaDonNode.SelectSingleNode("Loai").InnerText);
                string ms = hoaDonNode.SelectSingleNode("MS").InnerText;
                string khach = hoaDonNode.SelectSingleNode("Khach").InnerText;
                string ngayLap = hoaDonNode.SelectSingleNode("NgayLap").InnerText;
                string mahang = hoaDonNode.SelectSingleNode("Hang/MH").InnerText;
                string tenHang = hoaDonNode.SelectSingleNode("Hang/TenHang").InnerText;
                double gia = Double.Parse(hoaDonNode.SelectSingleNode("Hang/Gia").InnerText);
                int soLuong = Int32.Parse(hoaDonNode.SelectSingleNode("SoLuong").InnerText);
                if (loai == 1)
                {

                    HD = new HoaDonKhachVIP(mahang, tenHang, gia, ms, khach, ngayLap, soLuong,loai);

                }
                else if (loai == 2)
                {
                    HD = new HoaDonKhachVangLai(mahang, tenHang, gia, ms, khach, ngayLap, soLuong,loai);

                }
                else
                {
                    HD = new HoaDonKhachThanThiet(mahang, tenHang, gia, ms, khach, ngayLap, soLuong,loai);

                }


                DS.Add(HD);
            }
        }
        public void xuatList()
        {
            foreach (HoaDon hd in DS)
            {

                hd.xuat();
                Console.WriteLine();
            }
        }
        
        public double tongTien()
        {
            double tong = 0;
            foreach(HoaDon hd in DS)
            {
                tong = tong + hd.tongThanhTien();
            }
            return tong;
        }
        public void xapSep()
        {

            DS = DS.OrderBy(h => h.tongThanhTien()).ThenByDescending(h => h.MaSo).ToList();
        }
        public void xuatds2()
        {
            foreach(HoaDon hd in DS)
            {
                if(hd.Loai==2)
                {
                    hd.xuat();
                }
            }
        }
        public void xuatThanhTienMax()
        {
            // Sắp xếp danh sách hóa đơn theo số lượng giảm dần
            DS = DS.OrderByDescending(h => h.tongThanhTien()).ToList();

            // Lấy hóa đơn có số lượng nhiều nhất (phần tử đầu tiên trong danh sách)
            HoaDon hoaDonNhieuNhat = DS.FirstOrDefault();
            if(hoaDonNhieuNhat!=null)
            {
                Console.WriteLine("Loai: " + hoaDonNhieuNhat.Loai);
                Console.WriteLine("MS: " + hoaDonNhieuNhat.MaSo);
                Console.WriteLine("Khach: " + hoaDonNhieuNhat.TenKhach);
                Console.WriteLine("NgayLap: " + hoaDonNhieuNhat.NgayLap);
                Console.WriteLine("MaHang: " + hoaDonNhieuNhat.MaHang);
                Console.WriteLine("TenHang: " + hoaDonNhieuNhat.TenHang);
                Console.WriteLine("Gia: " + hoaDonNhieuNhat.DonGia);
                Console.WriteLine("SoLuong: " + hoaDonNhieuNhat.SoLuong);
                Console.WriteLine(": " + hoaDonNhieuNhat.tongThanhTien());
                
            }
        }
        public void demHoaDon()
        {
            int dem = 0;
            int dem1 = 0;
            foreach (HoaDon hd in DS)
            {
                if (hd.Loai == 1)
                {
                    dem++;
                }
            }
            foreach (HoaDon hd in DS)
            {
                if (hd.Loai == 3)
                {
                    dem1++;
                }
            }
            Console.WriteLine("So hoa don khach hang Vip la:{0}", dem1);
            Console.WriteLine("So hoa don khach hang than thiet la:{0}", dem);
        }
        public double TongThanhToanTamUng()
        {
            double tong = 0;
            foreach (HoaDon hd in DS)
            {
                if(hd.TenKhach=="Tran Van B")
                { 
                    if (hd is I_CongNo)
                    {
                        I_CongNo t = (I_CongNo)hd;
                        tong = tong + t.thanhToanTamUng();
                    }
                }
            }
            return tong;
        }
    }
}
