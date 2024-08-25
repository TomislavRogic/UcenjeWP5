using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Vjezbanjezadataka
    {
        public static void Izvedi()
        {
            try
            {

                Console.WriteLine("Molim unesi jednoznamenkasti ili dvoznamenkasti broj: ");
                int unesenibroj = int.Parse(Console.ReadLine());
                if (unesenibroj >= 0 && unesenibroj <= 9)
                {
                    Console.WriteLine("Uneseni broj je jednoznamenkasti broj");
                }
                else if (unesenibroj >= 10 && unesenibroj <= 99)
                {
                    Console.WriteLine("Uneseni broj je jednoznamenkasti broj");
                }
                else if (unesenibroj==42)
                {
                    Console.WriteLine("Unijeli ste poseban broj");
                }
                else
                {
                    Console.WriteLine("Uneseni broj nije jednoznamenkasti ili dvoznamenkasti broj");
                }
            }
            catch
            {
                Console.WriteLine("Neispravan unos. Molim unesite jednoznamenkasti ili dvoznamenkasti broj.");
            }

           

        }
    }
}
