﻿using System;
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
            Kare k = new Kare(3);
            Console.WriteLine($"Karenin Cevresi:{k.Cevre} Alani:{k.Alan}");


            Dikdortgen d = new Dikdortgen(3,5);
            Console.WriteLine($"Dikdortgen Cevresi:{d.Cevre} Alani:{d.Alan}");

            Daire daire = new Daire(5);
            Console.WriteLine($"Dairenin Cevresi:{daire.Cevre} Alani:{daire.Alan}");

            KarePrizma kp = new KarePrizma(5,5);
            Console.WriteLine($"KarePrizmanin Alani:{kp.Alan} Hacmi:{kp.Hacim}");

            Silindir s = new Silindir(3,3);
            Console.WriteLine($"Silindirin Alani:{s.Alan} Hacmi:{s.Hacim}");
            Console.ReadLine();
        }
    }



   
   



    

    
        
        
}
