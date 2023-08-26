using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTCuoiKy
{
    abstract public class XangDau
    {
        protected string maHang,tenHang;

        public string TenHang
        {
            get { return tenHang; }
            set { tenHang = value; }
        }

        public string MaHang
        {
            get { return maHang; }
            set { maHang = value; }
        }
        protected double donGia;

        public double DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
      
        public XangDau()
        {

        }
        public XangDau(string maHang,string tenHang,double donGia)
        {
            this.maHang = maHang;
            this.tenHang = tenHang;
            this.donGia = donGia;
        }
        abstract public double thanhTien();
        
    }
}
