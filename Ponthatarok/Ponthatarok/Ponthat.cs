using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponthatarok
{
    internal class PontHat
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem a pontszámot:");
            int pont = int.Parse(Console.ReadLine());

            if (pont > 0 && pont < 100)
            {
                PontHat p1 = new PontHat(pont);
                p1.szamitas();
                Console.WriteLine("A kapott eredmény{0}", pont);
            }
            else Console.WriteLine("Rossz adat");
                Console.ReadKey();
            
        }
    }
}
