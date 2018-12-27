using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriSekilOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kare k = new Kare(3);
            //Console.WriteLine($"Karenin Cevresi:{k.Cevre} Alani:{k.Alan}");


            Dikdortgen d = new Dikdortgen(3,5);
            Console.WriteLine($"Dikdortgen Cevresi:{d.Cevre} Alani:{d.Alan}");

            Daire daire = new Daire(5);
            Console.WriteLine($"Dairenin Cevresi:{daire.Cevre} Alani:{daire.Alan}");

            KarePrizma kp = new KarePrizma(5,5);
            Console.WriteLine($"KarePrizmanin Alani:{kp.Alan} Hacmi:{kp.Hacim}");

            Console.ReadLine();
        }
    }



    public class Sekil
    {
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
    }
    public class Dikdortgen : Sekil
    {
        int _kisaKenar;
        int _uzunKenar;

        public Dikdortgen()
        {

        }
        public Dikdortgen(int kskenar,int uznkenar)
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

    public class Daire:Sekil
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
