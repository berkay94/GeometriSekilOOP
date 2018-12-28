using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriSekilOOP
{
    public class Silindir:Sekil
    {
        int h;
        int r;

        public int R
        {
            get
            {
                return r;

            }
            set
            {
                r = value;
            }
        }
        public int H
        {
            get
            {
                return h;

                
            }
            set
            {
                h = value;
            }
        }

        public Silindir()
        {
                
        }
        public Silindir(int yrcp,int yksklk)
        {
            R = yrcp;
            H = yksklk;
            Hacim = Math.PI * (R * R) * H;
            Alan = 2 * Math.PI * R * (R + H);
        }
    }
}
