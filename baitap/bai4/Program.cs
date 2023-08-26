using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            float tx, ty;
            int kieu,kieu1;
            HCN hinhChuNhat=new HCN();
            hinhChuNhat.Nhap();
            Console.WriteLine("Chieu dai cua hinh chu nhat la:{0}\nChieu rong cua hinh chu nhat la:{1}", hinhChuNhat.ChieuDai, hinhChuNhat.ChieuRong);
            Console.WriteLine("Dien tich hinh chu nhat la:{0}", hinhChuNhat.tinhDienTich());
            Console.WriteLine("Chu vi hinh chu nhat la:{0}", hinhChuNhat.tinhChuVi());
            Console.WriteLine("Duong cheo hinh chu nhat la:{0}", hinhChuNhat.duongCheo());
            Console.Write("Nhap chieu dai thay doi: ");
            tx = float.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong thay doi: ");
            ty = float.Parse(Console.ReadLine());
            Console.Write("Nhap kieu: ");
            kieu = int.Parse(Console.ReadLine());
            hinhChuNhat.changeSize(tx,ty,kieu);
            Console.WriteLine("Chieu dai cua hinh chu nhat la:{0}\nChieu rong cua hinh chu nhat la:{1}", hinhChuNhat.ChieuDai, hinhChuNhat.ChieuRong);
            
            //overload
            Console.Write("Nhap kieu: ");
            kieu1 = int.Parse(Console.ReadLine());
            hinhChuNhat.changeSize(hinhChuNhat, kieu1);
            Console.WriteLine("Chieu dai cua hinh chu nhat la:{0}\nChieu rong cua hinh chu nhat la:{1}", hinhChuNhat.ChieuDai, hinhChuNhat.ChieuRong);
            Console.ReadLine();
        }

    }
}
