using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriSekilOOP
{
    public class Dikdortgen : Sekil
    {
        int _kisaKenar;
        int _uzunKenar;

        public Dikdortgen()
        {

        }
        public Dikdortgen(int kskenar, int uznkenar)
        {
            _kisaKenar = kskenar;
            _uzunKenar = uznkenar;
            Alan = _kisaKenar * _uzunKenar;
            Cevre = ((2 * _kisaKenar) + (2 * _uzunKenar));
        }


        public int KisaKenar
        {
            get
            {
                return _kisaKenar;
            }
            set
            {
                _kisaKenar = value;
            }
        }
        public int UzunKenar
        {
            get
            {
                return _uzunKenar;
            }
            set
            {
                _uzunKenar = value;
            }
        }

    }
}
