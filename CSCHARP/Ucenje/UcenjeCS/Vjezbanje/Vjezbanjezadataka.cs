﻿using System;
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
            /*Zadatak 1 Ucitavamo broj s  konzole i ispisujemo je li jednoznamenkasti ili dvoznamenkasti broj. ako je broj 42 ispisujemo da je poseban broj
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
                else
                {
                    Console.WriteLine("Uneseni broj nije jednoznamenkasti ili dvoznamenkasti broj");
                }

                if (unesenibroj == 42)
                {
                    Console.WriteLine("Unijeli ste poseban broj");
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
                //double f = double.Round(prosjek);
                //Console.WriteLine(  "Zaokruzena ocjena je " + f);

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

            */

            // korisnik unosi koliko ce brojeva upisati. ucitaj te brojeve, izracunaj njihov prosjek i ispisi sve brojeve koji su veci od prosjeka
            /* Console.WriteLine("Molim Vas unesite koliko brojeva zelite unijeti:");
             int brojUnesenihBrojeva = int.Parse(Console.ReadLine());
             int suma = 0;

             int[] brojevi = new int[brojUnesenihBrojeva];

             for (int i = 0; i < brojUnesenihBrojeva; i++) // 0, 1, 2, 3
             {
                 brojevi[i] = int.Parse(Console.ReadLine());
                 suma = suma + brojevi[i];
             }
             Console.WriteLine("Suma brojeva je " + suma);

             Console.WriteLine("**********************************");

             //for (int i = 0; i < brojUnesenihBrojeva; i++) // 0, 1, 2, 3
             //{
             //    Console.WriteLine(brojevi[i]);

             //}

             //Console.WriteLine("************************************");
             //float prosjek = (float)suma / brojUnesenihBrojeva;
             //Console.WriteLine("Prosjek brojeva koje ste unijeli je: " + prosjek);

             //Console.WriteLine("*************************************");

             //// zaokruzivanje broja 
             //float zaokruzeniBroj = float.Round(prosjek);

             //Console.WriteLine("Prosjek je zaokruzen na cijeli broj:" + zaokruzeniBroj);

             //for(int i=0; i < brojevi.Length; i++) // 0, 1, 2
             //{
             //    if (brojevi[i] > prosjek)
             //    {
             //        Console.WriteLine("Broj " + brojevi[i] + " na indeksu " + i);
             //    }
             //}*/

            // u polje velicine 3 spremi dva ucitana broja, a na trece mjesto u polju stavi zbroj ta dva broja i ispisi ga
            //int[] niz = new int[3];

            //Console.WriteLine("Molim unesite 2 broja: ");
            //niz[0]  = int.Parse(Console.ReadLine());
            //niz[1] = int.Parse(Console.ReadLine());

            //niz[2] = niz[0] + niz[1];
            //Console.WriteLine(niz[2]);

            // u polje velicine 100 spremiti brojeve 10, 11, 12, .... i ispisati sve brojeve
            //int[] NoviNiz = new int[10];

            //// nacin 1
            // //int PocetniBroj = 10;
            //for (int i= 10; i<20;  i++) // i = 10
            //{
            //    NoviNiz[i-10]= i;
            //    // NoviNiz[0] = 10
            //    // NoviNiz[1] = 11
            //    // NoviNiz[2] = 12

            //    Console.WriteLine(NoviNiz[i]);
            //}


            // nacin 2
            // spremanje brojeva
            //int RedniBroj = 1;
            //    for (int i = 0; i<NoviNiz.Length; i++)
            //    {
            //        NoviNiz[i] = i + 10;
            //    }
            //    for (int i=0; i<NoviNiz.Length; i++)
            //    {
            //        Console.WriteLine(RedniBroj + " " + "Ispisani broj je: " + NoviNiz[i]);
            //        RedniBroj++;
            //    }

            int[] NoviNiz = new int[10];
            for (int i = 0; i < NoviNiz.Length; i++)
            {
                NoviNiz[i] = int.Parse(Console.ReadLine());
            }

            // 0 + 9
            // 1 + 8
            // 2 + 7
            // 3 + 6
            // 4 + 5

            int indeksNaPolovici = (int) float.Round(NoviNiz.Length / 2f, MidpointRounding.AwayFromZero);
            for (int i = 0; i < indeksNaPolovici; i++)
            {
                if (i == NoviNiz.Length - 1 - i)
                {
                    Console.WriteLine(NoviNiz[i]);
                }
                else
                {

                    int prviBroj = NoviNiz[i];
                    int drugiBroj = NoviNiz[NoviNiz.Length - 1 - i];
                    int zbroj = prviBroj + drugiBroj;
                    Console.WriteLine(zbroj);
                }
                // i = 0 => 9 => 9 - i = 9
                // i = 1 => 8 => 9 - i = 8
                // i = 2 => 7 => 9 - i = 7
            }

            // vel 10 do 5 => 10 / 2 = 5
            // vel 11 do 6 => 11 / 2 = 5.5
            // vel 12 do 6 => 12 / 2 = 6
        }
    }
}