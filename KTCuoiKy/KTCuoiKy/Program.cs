using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTCuoiKy
{
    class Program
    {
        static void Main(string[] args)
        {
            ListHoaDon lhd = new ListHoaDon();
            lhd.nhap("D:/hao/code 2013/C#/KTCuoiKy/KTCuoiKy/DSHoaDon.xml");
            lhd.xuatList();
            Console.WriteLine("Cau3 ================================================\nXuat hoa don khach vang lai:");
            
            lhd.xuatds2();
            Console.WriteLine("Cau4================================================\nTong tien cac don hang:{0}",lhd.tongTien());
            
            Console.WriteLine("Cau5================================================\nXuat don hang co tong thanh tien lon nhat:");
            lhd.xuatThanhTienMax();
            Console.WriteLine("Cau6================================================\n");
            lhd.demHoaDon();
            Console.WriteLine("Cau7================================================\nXuat don hang co tong tam ung cua khach hang Tran Van B:{0}", lhd.TongThanhToanTamUng());
            Console.WriteLine("Cau8================================================\nsap xep danh sach:");
            lhd.xapSep();
            lhd.xuatList();
            Console.ReadLine();

        }
    }
}
