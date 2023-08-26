using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    class Time
    {
        int gio, phut, giay;

        public int Giay
        {
            get { return giay; }
            set
            {
                if (value <= 60 ||value >= 0)
                {
                    gio = value;
                }
                else
                    Console.WriteLine("Du lieu sai");
            }
        }

        public int Phut
        {
            get { return phut; }
            set
            {
                if (value <= 60 || value >= 0)
                {
                    gio = value;
                }
                else
                    Console.WriteLine("Du lieu sai");
            }
        }

        public int Gio
        {
            get { return gio; }
            set
            {
                if (value >24||value<0)
                {
                    Console.WriteLine("Du lieu sai");
                }
                else 
                    gio = value;

            }
        }
        public Time()
        {
            gio = phut = giay = 0;
        }
        public Time(int gio,int phut, int giay)
        {
            this.gio = gio;
            this.giay = giay;
            this.phut = phut;

        }
        public Time (Time time)
        {
            this.gio = time.gio;
            this.giay = time.giay;
            this.phut = time.phut;
        }
        public void Nhap()
        {
            Console.Write("Nhap gio: ");
            gio = int.Parse(Console.ReadLine());
            Console.Write("Nhap phut: ");
            phut = int.Parse(Console.ReadLine());
            Console.Write("Nhap giay: ");
            giay = int.Parse(Console.ReadLine());    
        }
        public void xuat()
        {
            Console.WriteLine("Xuat theo kieu 24h: {0}Gio {1}phut {2}giay",gio,phut,giay);
            Console.Write("Xuat theo kieu 12h:");
            if(gio>=12)
            {
                Console.Write("{0}:{1}:{2} PM", gio-12, phut, giay);
            }
            else
                Console.Write("{0}:{1}:{2} AM", gio, phut, giay);
        }
        public void ktHopLe()
        {
            for (; ; )
            {
                if (gio > 24 || gio < 0)
                {
                    Console.Write("Gio khong hop le!\n");
                    Console.Write("Moi nhap lai gio:\n ");
                    gio = int.Parse(Console.ReadLine());
                }
                else
                { Console.Write("Gio hop le!\n"); break; }
            }
            for (; ; )
            {
                if (phut > 60 || phut < 0)
                {
                    Console.Write("Phut khong hop le!\n");
                    Console.Write("Moi nhap lai phut:\n ");
                    phut = int.Parse(Console.ReadLine());
                }
                else
                { Console.Write("Phut hop le!\n"); break; }
            }
            for (; ; )
            {
                if (giay > 60 || giay < 0)
                {
                    Console.Write("Giay khong hop le!\n");
                    Console.Write("Moi nhap lai Giay: \n");
                    giay = int.Parse(Console.ReadLine());
                }
                else
                { Console.Write("Giay hop le!\n"); break; }
            }
            
        }
        public void tangGio(int soGiay)
        {
            giay = giay + soGiay;
            if(giay>60)
            {
                giay = giay - 60;
                phut = phut + 1;
            }
            if(phut>60)
            {
                phut = phut - 60;
                gio = gio + 1;
            }
            if(gio>24)
            {
                gio = gio - 24;
            }

        }
        public void tangGio(int soGiay,string kieuGio)
        {
            
            if (kieuGio == "24h")
            {
                Console.WriteLine("Xuat theo kieu 24h: {0}Gio {1}phut {2}giay", gio, phut, giay);
            }
            else if (kieuGio == "12h")
            {
                if (gio >= 12)
                {
                    Console.Write("{0}:{1}:{2} PM", gio - 12, phut, giay);
                }
                else
                    Console.Write("{0}:{1}:{2} AM", gio, phut, giay);
            }
            else
                Console.Write("Kieu gio k hop le!");
        }
        public void giamGio(int soGiay)
        {
            giay = giay - soGiay;
            if (giay < 0)
            {
                giay = giay + 60;
                phut = phut - 1;
            }
            if (phut < 0)
            {
                phut = phut + 60;
                gio = gio - 1;
            }
            if (gio < 0)
            {
                gio = gio +24;
            }

        }
        public void giamGio(int soGiay, string kieuGio)
        {

            if (kieuGio == "24h")
            {
                Console.WriteLine("Xuat theo kieu 24h: {0}Gio {1}phut {2}giay", gio, phut, giay);
            }
            else if (kieuGio == "12h")
            {
                if (gio >= 12)
                {
                    Console.Write("{0}:{1}:{2} PM", gio - 12, phut, giay);
                }
                else
                    Console.Write("{0}:{1}:{2} AM", gio, phut, giay);
            }
            else
                Console.Write("Kieu gio k hop le!");
        }
    }
}
