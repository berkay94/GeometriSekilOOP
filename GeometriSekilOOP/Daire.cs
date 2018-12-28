using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriSekilOOP
{
    public class Daire : Sekil
    {
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

        public Daire(int yrcp)
        {
            R = yrcp;

            Alan = R * R * Math.PI;
            Cevre = 2 * R * Math.PI;
        }
        public Daire()
        {

        }
    }
}
