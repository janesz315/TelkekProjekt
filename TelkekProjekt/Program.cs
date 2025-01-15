using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelkekProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Telek> telkek = new List<Telek>();
            telkek.Add(new Téglalap("t1",true, 13.95, 12.9));

            foreach (Telek s in telkek) { s.InformációKözlő(); }
            Console.ReadLine();


        }
    }
}
