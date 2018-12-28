using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriSekilOOP
{
    /// <summary>
    /// Kare sınıfları metodları
    /// </summary>
    public class Kare : Sekil
    {
        int kenarUzunlugu;
        public int KenarUzunlugu
        {
            get
            {
                return kenarUzunlugu;
            }
            set
            {
                if (value > 0)
                    kenarUzunlugu = value;
                else
                    Console.WriteLine("Kenar Uzunlugu 0 dan buyuk olmali");
            }
        }

        public Kare(int kenar)
        {
            KenarUzunlugu = kenar;
            Alan = kenarUzunlugu * kenarUzunlugu;
            Cevre = 4 * KenarUzunlugu;
        }

        public Kare()
        {

        }
    }
}
