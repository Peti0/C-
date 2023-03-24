using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace csomogal
{
    internal class Dinnye
    {
        private int darab;
        private int atmero;
        private double anyag;
        
        public Dinnye() { }

        public void setDarab(int d)
        {
            this.darab = d;
        }

        public void setAtmero(int a)
        {
            this.atmero = a;
        }




        public void Szamol()
        {
            this.anyag =this.darab * (this.atmero * Math.PI + 60);
        }

        public double getAnyag() { return this.anyag; }
    }
}
