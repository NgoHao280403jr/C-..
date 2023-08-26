using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class HCN
    {
        float chieuDai, chieuRong;

        public float ChieuRong
        {
            get { return chieuRong; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Du lieu sai");
                    chieuRong = 0;
                }
                else chieuRong = value;
            }
        }

        public float ChieuDai
        {
            get { return chieuDai; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Du lieu sai");
                    chieuDai = 0;
                }
                else chieuDai = value;
            }
        }
        public HCN()
        {
            chieuDai = chieuRong = 0;
        }
        public HCN(float chieuDai,float chieuRong)
        {
            this.chieuDai = chieuDai;
            this.chieuRong = chieuRong;
        }
        public HCN(HCN hcn)
        {
            this.chieuDai = hcn.chieuDai;
            this.chieuRong = hcn.chieuRong;
        }
        public void Nhap()
        {
            Console.Write("Nhap chieu dai: ");
            chieuDai = float.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            chieuRong = float.Parse(Console.ReadLine());
        }
        public float tinhChuVi()
        {
            return (chieuDai + chieuRong) * 2;
        }
        public float tinhDienTich()
        {
            return chieuDai * chieuRong;
        }
        static float squareRoot(float number)
        {
            float temp;
            float sr = number / 2;

            do
            {
                temp = sr;
                sr = (temp + (number / temp)) / 2;
            } while ((temp - sr) != 0);
            return sr;
        }
        public float duongCheo()
        {
            float duongCheo = (chieuDai * chieuDai + chieuRong * chieuRong);
            return squareRoot(duongCheo);
        }
        public void changeSize(float tx,float ty,int kieu)
        {
           
            if(kieu==1)
            {
                chieuDai = chieuDai + tx;
                chieuRong = chieuRong + ty;
            }
            else
            {
                chieuDai = chieuDai - tx;
                chieuRong = chieuRong - ty;
            }
        }
        public void changeSize(HCN a, int kieu)
        {
            Console.Write("Nhap chieu rong thay doi: ");
            a.ChieuDai = float.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong thay doi: ");
            a.ChieuRong = float.Parse(Console.ReadLine());
            if (kieu == 1)
            {
                chieuDai = chieuDai + a.chieuDai;
                chieuRong = chieuRong + a.chieuRong;
            }
            else
            {
                chieuDai = chieuDai - a.chieuDai;
                chieuRong = chieuRong - a.chieuRong;
            }
        }
    }
}
