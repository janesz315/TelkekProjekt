using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelkekProjekt
{
    internal abstract class Telek
    {

        public string helyrajziSzám;
        public bool vanKözmű;
        public bool vanSzomszéd;

        public Telek(string helyrajziSzám, bool vanKözmű, bool vanSzomszéd)
        {
            this.helyrajziSzám = helyrajziSzám;
            this.vanKözmű = vanKözmű;
            this.vanSzomszéd = vanSzomszéd;
        }
        //Szerződés
        public abstract double TerületSzamol();
        public abstract double KerületSzamol();
        public abstract double ÁratSzámol();

        public abstract void InformációKözlő();

        public abstract double KerítésHosszSzámláló();

        //Nem szerződés (megvalósítás)
        public double NégyzetméterÁrSzámol()
        {
            return vanKözmű ? 30000 : 10000;
        }
         
    }
}
