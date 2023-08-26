using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTCuoiKy
{
    class HoaDonKhachThanThiet: HoaDon,I_CongNo
    {
        public HoaDonKhachThanThiet(string maHang, string tenHang, double donGia)
            : base(maHang, tenHang, donGia)
        {

        }
        public HoaDonKhachThanThiet(string maHang, string tenHang, double donGia,string maSo,string tenKhach,string ngayLap,int soLuong,int loai):base(maHang, tenHang, donGia, maSo, tenKhach,ngayLap, soLuong,loai)
        {

        }
        public override double tienKhuyenMai()
        {
            if (soLuong > 60)
            {
                return thanhTien() * 0.04;
            }
            else if (soLuong <= 60 && thanhTien() >= 800000)
            {
                return thanhTien() * 0.03;
            }
            else
                return 0;
        }
        public double thanhToanTamUng()
        {
            return 0.6 * tongThanhTien();
        }
        public double laiXuatTraCham()
        {
            return 0.03 * (tongThanhTien() - thanhToanTamUng());
        }
        public override void xuat()
        {
            base.xuat();
        }
    }
}
