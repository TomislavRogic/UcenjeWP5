using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z1LjubavniTrokut
    {
        public static void Izvedi()
        {
            // unos prvog imena
            Console.WriteLine("Unesite svoje ime: ");
            string vaseime= Console.ReadLine();

            // unos drugog imena
            Console.WriteLine("Unesite partnerovo ime: ");
            string partnerovoime= Console.ReadLine();

            // spajanje ta dva imena u jedno
            string imepar= vaseime + "" + partnerovoime;
            
            // brojanje pojavljivanje slova-- provjerava u ascii i svaki put oduzima asci broj od 'a' i onda broju dodijeljuje vrijednost
            int[] count= new int[26];
            foreach (char slovo in imepar.ToLower())
            {
                if (char.IsLetter(slovo))
                {
                    count[slovo - 'a']++;
                }
            }

            // ispis slova i koliko puta se pojavljuje
            foreach (char slovo in imepar)
            {
                if (char.IsLetter(slovo))
                {
                    int index = slovo - 'a';
                    Console.WriteLine($"{slovo}"); // ispisuje slovo
                    Console.WriteLine($"{count[index]}");
                }

            }






        }

    }
}
