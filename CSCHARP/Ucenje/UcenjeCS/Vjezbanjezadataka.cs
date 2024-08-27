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
            // Zadatak 1 Ucitavamo broj s  konzole i ispisujemo je li jednoznamenkasti ili dvoznamenkasti broj. ako je broj 42 ispisujemo da je poseban broj
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
                    Console.WriteLine("Uneseni broj je dvoznamenkasti broj");
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

           
            // Zadatak 2 Ucitavamo 3 broja s konzole i ispisujemo njihov prosjek    Dodatno, ispisujemo koja ocjena ce biti zakljucena uceniku
            try
            {
                // unos tri ocjene
                Console.WriteLine("Molim unesi prvi broj: ");
                int prvi = int.Parse(Console.ReadLine());
                Console.WriteLine("Molim unesi drugi broj: ");
                int drugi = int.Parse(Console.ReadLine());
                Console.WriteLine("Molim unesi treci broj: ");
                int treci = int.Parse(Console.ReadLine());

                // racunanje prosjeka
                double prosjek = (prvi + drugi + treci) / 3.0;
                Console.WriteLine("Prosjek unesenih brojeva je: " + prosjek);

                // izracunavanje zakljucene ocjene
                if (prosjek >= 4.5)
                {
                    Console.WriteLine("Ocjena je 5");
                }
                else if (prosjek >= 3.5)
                {
                    Console.WriteLine("Ocjena je 4");
                }
                else if (prosjek >= 2.5)
                {
                    Console.WriteLine("Ocjena je 3");
                }
                else if (prosjek >= 1.5)
                {
                    Console.WriteLine("Ocjena je 2");
                }
                else
                {
                    Console.WriteLine("Ocjena je 1");
                }
            }
            catch
            {
                Console.WriteLine("Neispravan unos. Molim unesite tri broja.");
            }

            // Zadatak 3.Ucitaj s konzole dva decimalna broja. Izracunaj njihov zbroj a da su cijeli brojevi

            Console.WriteLine("Molim Vas unesite prvi decimalni broj: ");
            double prvibroj=double.Parse(Console.ReadLine());

            Console.WriteLine("Molim Vas unesite drugi decimalni broj: ");
            double drugibroj = double.Parse(Console.ReadLine());
        
            int broj1= (int)prvibroj;
            int broj2 = (int)drugibroj;

            int suma= broj1 + broj2;
            Console.WriteLine("Zbroj unesenih brojeva je: " + suma);
        
        }

    }
}
