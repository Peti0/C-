using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haromszögbeirhatokor_16_
{
    internal class Alakzat
    {
        private int a;
        private int b;
        private int c;
        private double terulet;
        private int kerulets;
        private double sugar;
        public Alakzat() { }

        public void setA(int A) { this.a = A; }
        public void setB(int B) { this.b = B; }
        public void setC(int B) { this.c = B; }  
        public void setTerulet(int Terulet) { this.terulet = Terulet; }
        public void setKerulets(int KeruletS) { this.kerulets = KeruletS; }
        public void setSugar(int sugar) { this.sugar = sugar; }

        public void Szamol()
        {
            this.kerulets = (this.a + this.b + this.c) / 2;

            this.terulet = this.kerulets * (this.kerulets - this.a) * (this.kerulets - this.b) * (this.kerulets - this.c);

            this.terulet = Math.Sqrt(this.terulet);

            this.sugar = 2 * this.terulet / (this.a + this.b + this.c);
        }

        public double getSugar() { return this.sugar; }
    }
}
