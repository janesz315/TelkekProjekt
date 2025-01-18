using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelkekProjekt
{
    internal class Téglalap : Telek
    {
        private double a;
        private double b;

        public Téglalap(string helyrajziSzám, bool vanKözmű, bool vanSzomszéd, double a, double b) : base(helyrajziSzám, vanKözmű, vanSzomszéd)
        {
            this.a = a;
            this.b = b;
        }

        public override void InformációKözlő()
        {
            Console.WriteLine("A név: {0}, közmű: {1}, a ={2}, b= {3}, K={4}, T= {5}, a végső ár: {6} Ft.", helyrajziSzám, vanKözmű ? "Van" : "Nincs", a, b, KerületSzamol(), TerületSzamol(), ÁratSzámol());
        }

        public override double KerítésHosszSzámláló()
        {
            if (vanSzomszéd)
            {
                return a + (2 * b);
            }
            else
            {
                return KerületSzamol();
            }
        }

        public override double KerületSzamol()
        {
            return 2 * (a + b);
        }

        public override double TerületSzamol()
        {
            return a * b;
        }

        public override double ÁratSzámol()
        {
            return TerületSzamol() * NégyzetméterÁrSzámol();
        }
    }
}
