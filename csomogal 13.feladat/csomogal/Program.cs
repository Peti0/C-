﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csomogal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg a dinnyék átmérojet ");
            int atmero = int.Parse(Console.ReadLine());
            Console.WriteLine("Adja meg a dinnyék darabját");
            int darab = int.Parse(Console.ReadLine());

            Dinnye c1= new Dinnye();
            c1.setAtmero(atmero);
            c1.setDarab(darab);
            c1.Szamol();
            double eredmeny = c1.getAnyag();
           
            Console.WriteLine("A dinnyék becsomagalásához {0} cm kell", eredmeny);

            Console.ReadKey();  
        }
    }
}
