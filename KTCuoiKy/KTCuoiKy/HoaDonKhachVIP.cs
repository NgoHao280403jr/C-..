using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTCuoiKy
{
    class HoaDonKhachVIP:HoaDon,I_CongNo
    {
        public HoaDonKhachVIP(string maHang,string tenHang,double donGia):base(maHang, tenHang, donGia)
        {

        }
        public HoaDonKhachVIP(string maHang,string tenHang,double donGia,string maSo,string tenKhach,string ngayLap,int soLuong,int loai):base(maHang, tenHang, donGia,  maSo, tenKhach,ngayLap, soLuong,loai)
        {

        }
        public override double tienKhuyenMai()
        {
            if (soLuong > 50)
            {
                return thanhTien() * 0.05;
            }
            else if (soLuong <= 50 && thanhTien() >= 600000)
            {
                return thanhTien() * 0.04;
            }
            else if (soLuong < 10)
            {
                return 0;
            }
            else
                return thanhTien() * 0.01;
        }
        public double thanhToanTamUng()
        {
            return 0.4 * tongThanhTien();
        }
        public double laiXuatTraCham()
        {
            return 0.02 * (tongThanhTien() - thanhToanTamUng());
        }
    }
}
