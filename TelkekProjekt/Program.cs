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
            telkek.Add(new Téglalap("T1",true, true, 13.95, 12.9));
            telkek.Add(new Négyszög("T2", true, true, 13.95, 16.38, 14.24, 19.26, 21.52));
            telkek.Add(new Négyszög("T3", false, true, 14.24, 26.4, 23.1, 41.9, 27.32));
            telkek.Add(new Háromszög("T4", false, false, 23.1, 18.36, 13.95));
            telkek.Add(new Téglalap("T5", true, true, 13.95, 12.9));
            telkek.Add(new Négyszög("T6", true, true, 13.95, 23.13, 14.48, 19.26, 27));
            telkek.Add(new Háromszög("T7", true, true, 14.48, 22.84, 22.14));
            telkek.Add(new Négyszög("T8", false, false, 22.84, 38, 13.95, 19.71, 24.15));

            double valami = 0;
            double kerites = 0;
            foreach (Telek s in telkek) 
            {
                valami += s.ÁratSzámol();
                kerites += s.KerítésHosszSzámláló();
                s.InformációKözlő();
               
            // }
            //double kerítésHossz = 0;
            //    for (int i = 0; i < telkek.Count; i++)
            //    {
            //        for (int j = 1; j < telkek.Count + 1; j++)
            //    {
            //        if (true)
            //        {
                        
            //        }
            //    }
                }
            Console.WriteLine("A bevétel: {0} Ft",valami);
            Console.WriteLine(kerites);
            Console.ReadLine();


        }
    }
}
