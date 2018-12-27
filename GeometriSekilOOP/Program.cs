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
            Kare k = new Kare(5);
            Console.WriteLine($"Karenin Cevresi:{k.cevre} Alani:{k.alan}");
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
        int kisaKenar;
        int uzunKenar;

        public Dikdortgen()
        {

        }
        public Dikdortgen(int kisakenar, int uzunkenar)
        {

        }


        public double Cevre
        {
            get
            {
                return Cevre;
            }
            set
            {

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

        /// <summary>
        /// Karenin Çevresini Hesaplar
        /// </summary>
        public double Cevre
        {
            get
            {
                return cevre;
            }
            set
            {
                cevre = kenarUzunlugu * 4;
            }
        }


        public double Alan
        {
            get
            {
                return alan;
            }
            set
            {
                alan = kenarUzunlugu * kenarUzunlugu;
            }
        }


        public Kare(int kenar)
        {
            KenarUzunlugu = kenar;
            this.Cevre = kenar;
            this.Alan = kenar;
        }

        public Kare()
        {

        }
    }
}
