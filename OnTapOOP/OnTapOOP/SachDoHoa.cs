using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapOOP
{
    class SachDoHoa:Sach,I_Phi
    {
        int soHinhVe;
        bool mausach;

        public bool Mausach
        {
            get { return mausach; }
            set { mausach = value; }
        }
        public int SoHinhVe
        {
            get { return soHinhVe; }
            set { soHinhVe = value; }
        }
        public override double chiPhi()
        {
            if(mausach== true)
            {
                return soHinhVe * 2000;
            }
            return soHinhVe * 1200;
        }
        public override void nhap()
        {
            base.nhap();
            Console.Write("nhap so hinh ve");
            soHinhVe = int.Parse(Console.ReadLine());
            Console.Write("nhap mau hinh ve(1:co mau,2:khong mau)");
            int a = int.Parse(Console.ReadLine());
            if (a == 1)
            {
                mausach = true;
            }
            else
            mausach = false;
        }
        public double phiBaoBia()
        {
            return 50000;
        }
        public double phiUopSach()
        {
            return soTrang * 200;
        }
        
        public override void xuat()
        {
            base.xuat();
            Console.Write("So hinh ve:{0}\tPhi bao bia:{1}\tPhi uop sach{2}",soHinhVe,phiBaoBia(),phiUopSach());
            if(mausach==true)
            {
                Console.Write(" sach co mau ");
            }
            else
                Console.Write(" sach khong co mau ");

        }
    }
}
