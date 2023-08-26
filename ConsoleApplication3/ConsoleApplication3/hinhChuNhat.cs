using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class hinhChuNhat
    {
        private float chieuDai;
        private float chieuRong;
        public void chunhat(float x,float y)
        {
            chieuDai = x;
            chieuRong = y;
        }
        public float X
        {
            get { return chieuDai; }
            set { chieuDai = value; }
        }
        public float Y
        {
            get { return chieuRong; }
            set { chieuRong = value; }
        }
        public float CV()
        {
            return (chieuDai+chieuRong)*2;
        }
        public float DT()
        {
            return chieuDai*chieuRong;
        }
    }
}
