using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelkekProjekt
{
    internal class Négyszög : Telek
    {
        private double a;
        private double b;
        private double c;
        private double d;
        private double e;
        public Négyszög(string helyrajziSzám, bool vanKözmű, bool vanSzomszéd, double a, double b, double c, double d, double e) : base(helyrajziSzám, vanKözmű, vanSzomszéd)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
        }

        public override void InformációKözlő()
        {
            Console.WriteLine("A név: {0}, közmű: {1}, a ={2}, b= {3}, c = {4}, d = {5}, e = {6}, K={7}, T= {8}, a végső ár: {9} Ft", helyrajziSzám, vanKözmű ? "Van" : "Nincs", a, b, c, d, e, KerületSzamol(), TerületSzamol(), ÁratSzámol());

        }

        public override double KerítésHosszSzámláló()
        {
            if (vanSzomszéd)
            {
                return a + b+d;
            }
            else
            {
                return KerületSzamol();
            }
        }

        public override double KerületSzamol()
        {
            return a + b + c + d;
        }

        public override double TerületSzamol()
        {
            double s1 = (a + b + e) / 2;
            double területABE = Math.Sqrt(s1 * (s1 - a) * (s1 - b) * (s1 - e)); 

            double s2 = (c + d + e) / 2;
            double területCDE = Math.Sqrt(s2 * (s2 - c) * (s2 - d) * (s2 - e)); 

            return területABE + területCDE;
        }

        public override double ÁratSzámol()
        {
            return TerületSzamol() * NégyzetméterÁrSzámol();
        }
    }
}
