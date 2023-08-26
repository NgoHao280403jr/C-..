using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            int soGiay;
            string kieuGio;
            Time T=new Time();
            T.Nhap();
            T.ktHopLe();
            T.xuat();
            Console.Write("\nMoi nhap so Giay thay doi:");
            soGiay = int.Parse(Console.ReadLine());
            //T.tangGio(soGiay);
            //Console.Write("\nMoi nhap kieu xuat tang gio theo 12h hay 24h:");
            //kieuGio = Console.ReadLine();
            //T.tangGio(soGiay, kieuGio);
            T.giamGio(soGiay);
            Console.Write("\nMoi nhap kieu xuat giam gio theo 12h hay 24h:");
            kieuGio = Console.ReadLine();
            T.giamGio(soGiay, kieuGio);
            Console.Read();
        }
    }
}
