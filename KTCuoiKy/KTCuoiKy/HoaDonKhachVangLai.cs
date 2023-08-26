using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTCuoiKy
{
    class HoaDonKhachVangLai:HoaDon
    {
        public HoaDonKhachVangLai(string maHang, string tenHang, double donGia)
            : base(maHang, tenHang, donGia)
        {

        }
        public HoaDonKhachVangLai(string maHang, string tenHang, double donGia, string maSo, string tenKhach, string ngayLap, int soLuong,int loai)
            : base(maHang, tenHang, donGia,maSo, tenKhach, ngayLap, soLuong,loai)
        {

        }
        public override double tienKhuyenMai()
        {
            if (thanhTien() > 1000000)
                return thanhTien() * 0.03;
            return 0;
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Tien khuyen mai:{0}", tienKhuyenMai());
        }
    }
}
