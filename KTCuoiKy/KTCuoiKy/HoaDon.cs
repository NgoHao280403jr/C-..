using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTCuoiKy
{
    abstract public class HoaDon:XangDau
    {
        protected string ngayLap, matHang,maSo,tenKhach;

        public string TenKhach
        {
          get { return tenKhach; }
          set { tenKhach = value; }
        }

        public string MaSo
        {
          get { return maSo; }
          set { maSo = value; }
        }

        public string MatHang
        {
            get { return matHang; }
            set { matHang = value; }
        }

        public string NgayLap
        {
            get { return ngayLap; }
            set { ngayLap = value; }
        }
        protected int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        int loai;

        public int Loai
        {
            get { return loai; }
            set { loai = value; }
        }
        public HoaDon(string maHang,string tenHang,double donGia):base(maHang,tenHang,donGia)
        {

        }

        public HoaDon(string maHang, string tenHang, double donGia, string maSo, string tenKhach, string ngayLap, int soLuong,int loai)
            : base(maHang, tenHang, donGia)
        {
            this.maSo = maSo;
            this.tenKhach = tenKhach;
            this.ngayLap = ngayLap;
            this.soLuong = soLuong;
            this.loai = loai;
        }
        
        public override double thanhTien()
        {
            return soLuong * DonGia;
        }
        abstract public double tienKhuyenMai();
        public double tongThanhTien()
        {
            return thanhTien() - tienKhuyenMai();
        }
        public virtual void xuat()
        {
            Console.WriteLine("Ma so:{0}\tTen khach:{1}\tNgayLap:{2}\tMa hang:{3}\tTen hang{4}\tDon gia:{5}\tSo luong{6}\tTong thanh tien:{7}",maSo,tenKhach,ngayLap,maHang,tenHang,donGia,soLuong,tongThanhTien());
        }
    }
}
