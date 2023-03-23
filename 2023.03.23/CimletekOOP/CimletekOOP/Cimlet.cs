
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CimletekOOP
{
    internal class Cimlet
    {
        private int osszeg;

        private int[,] cimletek =  {{20000,0},
                                    {10000,0 },
                                    {5000,0 },
                                    {2000,0 },
                                    {1000,0 },
                                    {500,0 },
                                    {200,0 },
                                    {100,0},
                                    {50,0 },
                                    {20,0 },
                                    {10,0 },
                                    {5,0 }};
        public Cimlet() { }
        
        public void setOsszeg(int p) 
        {
         this.osszeg = kerekit(p);
        }

        private int kerekit(int p)
        {
            if (p % 5 < 3)
            {
                p = p - p%5;
            }
            else p = p - p%5 + 5;

            return p;
        }




        public Cimlet(int osszeg)
        {
            this.osszeg = kerekit(osszeg);
            
        }
        
        public void Szamol() 
        {
            for (int i = 0; i < this.cimletek.GetLength(0); i++)
            {
                if (this.osszeg >= this.cimletek[i,0])
                {
                    this.cimletek[i, 1] = this.osszeg / this.cimletek[i, 0];
                    this.osszeg = this.osszeg % this.cimletek[i, 0];
                }
            }
        }
        
        public int[,] getCimletek() 
        {
            return cimletek;
        }
    }
}
