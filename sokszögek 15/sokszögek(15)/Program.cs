using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sokszögek_15_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Átlószámító");
            Console.WriteLine("Adja meg a szögek számát:");
            int szog = int.Parse(Console.ReadLine());

            Szog c1 = new Szog();
            c1.setSzog(szog);
            c1.Szamol();
            int atlo = c1.getAtlo();

            Console.WriteLine("A(z) {0} szöggel rendelkező alakzatnak {1} db átlója van.",szog , atlo);

            Console.ReadKey();
        }
    }
}
