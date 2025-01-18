using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelkekProjekt
{
    internal class Háromszög : Telek
    {
        private double a;
        private double b;
        private double c;
        public Háromszög(string helyrajziSzám, bool vanKözmű, bool vanSzomszéd, double a, double b, double c) : base(helyrajziSzám, vanKözmű, vanSzomszéd)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override void InformációKözlő()
        {
            Console.WriteLine("A név: {0}, közmű: {1}, a ={2}, b= {3}, c = {4}, K={5}, T= {6}, a végső ár: {7} Ft", helyrajziSzám, vanKözmű ? "Van" : "Nincs", a, b, c, KerületSzamol(), TerületSzamol(), ÁratSzámol());

        }

        public override double KerítésHosszSzámláló()
        {
            if (vanSzomszéd)
            {
                return a + c;
            }
            else
            {
                return KerületSzamol();
            }
        }

        public override double KerületSzamol()
        {
            return a + b + c;
        }

        public override double TerületSzamol()
        {
            // Félkerület számítása
            double s = (a + b + c) / 2;

            // Terület számítása Heron képlettel
            double terület = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return terület;
        }

        public override double ÁratSzámol()
        {
            return TerületSzamol() * NégyzetméterÁrSzámol();
        }
    }
}
