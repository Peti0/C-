using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponthatarok
{ 
    struct PontAdat
    {
        public string pont;
    }
    internal class Program
    {
        private int pontok;
        private static string[] jegyek = { "elégtelen", "elégséges", "közepes", "jó", "jeles" };
        private int pont = 0;

        public PontHat(int[] k)
        {
            this.pontok = k;
        }


        public PontAdat GetOsztalyzat()
        {
            return jegyek[jegy - 1];
        }
        public void szamitas()
        {
            setPontAdat();
        }
        public void setPontAdat()
        {
            if (this.pont >= 0 && this.pont < 50) this.pontok = 1;
            else if (this.pont >= 50 && this.pont < 65) this.pontok = 2;
            else if (this.pont >= 65 && this.pont < 80) this.pontok = 3;
            else if (this.pont >= 80 && this.pont < 90) this.pontok = 4;
            else if (this.pont >= 90 && this.pont < 65) this.pontok = 5;
            else this.pontok = 0;

        }
        static void Main(string[] args)
        {
        }
    }
}
