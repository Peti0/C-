using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sokszögek_15_
{
    internal class Szog
    {
        private int szog;
        private int atlo;
       

        public Szog() { }

        public void setSzog(int szog) { this.szog = szog; }

        public void Szamol() 
        {
            this.atlo = this.szog * (this.szog-3) / 2;
        }
        public int getAtlo() { return this.atlo; }  
    }
}
