using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CimletekOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg az összeget");
            int osszeg = int.Parse(Console.ReadLine());

            Cimlet c1= new Cimlet();
            c1.setOsszeg(osszeg);
            c1.Szamol();
            int [,] t = c1.getCimletek();

            for (int i = 0; i < t.GetLength(0); i++)
            {
                if (t[i, 1] != 0)
                Console.WriteLine("{0} Cimletből {1} darab kell", t[i, 0] , t[i, 1]);
            }

            Console.ReadKey();
        }
    }
}
