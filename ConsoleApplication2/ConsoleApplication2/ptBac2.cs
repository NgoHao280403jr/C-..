using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
   
        public class ptBac2
        {
    
        private int a, b, c;
        public void phuongTrinhBac2(int A,int B,int C)
        {
            a = A;
            b = B;
            c = C;
        }
        public int A1
        {
            get { return a; }
            set { a = value; }
        }
        public int B1
        {
            get { return b; }
            set { b = value; }
        }
        public int C1
        {
            get { return c; }
            set { c = value; }
        }
        public void soNghiem()
        {
            int denTa=b*b-4*a*c;
            if(denTa==0)
            {
                Console.Write("PT co 1 nghiem kep");
            }
            else if(denTa>0)
            {
                Console.Write("PT co 2 nghiem");
            }
            else Console.Write("PT khong co nghiem");
                
        }
    }
    
}
