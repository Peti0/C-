using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haromszögbeirhatokor_16_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Háromszögbe írható kör sugara:");
            Console.WriteLine("Adja meg a háromszög A oldalát.");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Adja meg a háromszög B oldalát.");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Adja meg a háromszög C oldalát.");
            int c = int.Parse(Console.ReadLine());

            Alakzat c1 = new Alakzat();
            c1.setA(a); c1.setB(b); c1.setC(c);
            double sugar = c1.getSugar();
            c1.Szamol();

            Console.WriteLine("A háromszögbe írható kör sugara: {0}", sugar);
            Console.ReadKey();
        }
    }
}
