using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljedivanjePolimorfizam.ZavrsniRad
{
    internal class Zadatak
    {
        public Osoba? osoba;
        public Vozilo? vozilo;
        public Termin? Termin;

        /*
         * 
         * Kreirati klase prema ERA dijagramu Vaše baze podataka - napravio
         * Implementirati nasljeđivanje i prepisati metodu ToString- napravio
         * 
         * Za svaku klasu napraviti po jedan konstruktor- napravio  
         * 
         * Svaku klasu instancirati u ovoj klasu
         */



        public Zadatak() 
        {
            // //ovdje instancirati svaku kreiranu klasu jednom i dodjeliti svim svojstvima vrijednosti

            Osoba osoba = new Osoba(1, "Marko", "Peric", "markoperic@gmail.com");
            Vozilo vozilo = new Vozilo(1, "Mazda", "CX5", 16000);
            Termin Termin = new Termin(1, osoba, vozilo, DateTime.Now);


            // testiranje
            Console.WriteLine(osoba.ToString());
            Console.WriteLine(vozilo.ToString());
            Console.WriteLine(Termin.ToString());




        }
    }
}
