using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            hinhChuNhat cn = new hinhChuNhat();
            cn.chunhat(7, 8);
            float a=cn.CV();
            float b = cn.DT();
            Console.WriteLine("chu vi hinh chu nhat la:{0}",a);
            Console.WriteLine("dien tich hinh chu nhat la:{0}", b);
            Console.ReadLine();
        }
    }
}
