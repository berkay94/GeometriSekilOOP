using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriSekilOOP
{
    public class Sekil
    {
        string sekilTip;
        internal double alan;
        internal double cevre;
        internal double hacim;

        public double Alan
        {
            get
            {
                return alan;
            }
            set
            {
                alan = value;
            }

        }
        public double Cevre
        {
            get
            {
                return cevre;
            }
            set
            {
                cevre = value;
            }

        }
        public double Hacim
        {
            get
            {
                return hacim;
            }
            set
            {
                hacim = value;
            }

        }
        public string SekilTip
        {
            get
            {
                return sekilTip;
            }
            set
            {
                sekilTip = value;
            }

        }
    }
}
