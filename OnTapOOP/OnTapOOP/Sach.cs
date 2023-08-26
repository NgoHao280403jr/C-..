using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapOOP
{
    abstract class Sach
    {
        protected string maSach, tenSach, tacGia;

        public string TacGia
        {
            get { return tacGia; }
            set { tacGia = value; }
        }

        public string TenSach
        {
            get { return tenSach; }
            set { tenSach = value; }
        }

        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }
        protected int soTrang;

        public int SoTrang
        {
            get { return soTrang; }
            set { soTrang = value; }
        }
        protected double giaBan;

        public double GiaBan
        {
            get { return giaBan; }
            set { 
                if (value <=10000)
                {
                    Console.Write("Gia ban phai lon hon 10000");
                    value = 10000;
                }
                giaBan = value;
              
            }
        }
        public static double thue = 0.03;
        public Sach(string maSach,string tenSach,string tacGia,int soTrang,double giaBan)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.tacGia = tacGia;
            this.soTrang = soTrang;
            this.giaBan = giaBan;
        }
        public Sach()
        {
            maSach = "S001";
            tenSach = "Huong doi tuong";
            tacGia = "Nguyen Cuu Dam";
            soTrang = 100;
            giaBan = 40000;
        }
        abstract public double chiPhi();
        public double thueSanXuat()
        {
            return giaBan * thue;
        }
        public double tienNhuanBut()
        {
            return 0.2 * giaBan;
        }
        public double loiNhuan()
        {
            return giaBan - thueSanXuat() - chiPhi() - tienNhuanBut();
        }
        public virtual void nhap()
        {
            Console.WriteLine("moi nhap ma sach:");
            maSach = Console.ReadLine();
            Console.WriteLine("moi nhap ten sach:");
            tenSach = Console.ReadLine();
            Console.WriteLine("moi nhap ten tac gia:");
            tacGia = Console.ReadLine();
            Console.WriteLine("moi nhap so trang:");
            soTrang =int.Parse( Console.ReadLine());
            Console.WriteLine("moi nhap gia ban:");
            giaBan =double.Parse( Console.ReadLine());
        }
        public virtual void xuat()
        {
            Console.WriteLine("Ma sach:{0}\tTen Sach{1}\tTac gia:{2}\tSo trang:{3}\tGia ban:{4}\tLoi nhuan:{5}",maSach,tenSach,tacGia,soTrang,giaBan,loiNhuan());
        }
    }
}
