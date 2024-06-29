using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z1
    {

        // Program od korisnika trazi unos broj godina koje ima korisnik
        // Program upisuje da li je korisnik punoljetna osoba ili ne
        // dodatno ako je unos ispod jedne godine ili iznad 112 godina ispisati GRESKA
        public static void Izvedi()
        {

            // ovo je moje rjesenje zadatka
            Console.Write("Molim upisite broj godina: ");
            int godine = int.Parse(Console.ReadLine());
            if (godine < 1 || godine >112)
            {
                Console.WriteLine("Unos nije dobar");
            } else if (godine >=18)
            {
                Console.WriteLine(" vi ste punoljetni");
            }
            else
            {
                { Console.WriteLine("vi ste maloljetni"); 
                
             }










            }









        }










    }
}
