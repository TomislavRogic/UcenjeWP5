using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E07Z1
    {
        public static void Izvedi()
        {
            // Program od korisnika unosi cijeli broj (osigurava se unos)
            //Koristeci while petlju program ispisuje
            //zbroj svih parnih brojeva od 1 do unesenog broja (skupa s njim)
            //unos 10 ispis 30
            //unos 12 ispis 42

            int i = 0;
            int suma = 0;

            while (true)
            {
                Console.WriteLine("Molim unesite cijeli broj: ");
                int broj = int.Parse(Console.ReadLine());
            }

            // Program od korisnika unosi 10 brojeva
            //Program ispisuje prvo zbroj svih unesenih brojeva
            // i nakon toga ispisuje unesene brojeve jedno ispred drugog

            int[] brojevi = new int[10]; // Kreiranje niza za pohranu 10 brojeva
            int sum = 0; // Varijabla za pohranu zbroja brojeva

            // Unos 10 brojeva od korisnika
            for (int k = 0; k < brojevi.Length; k++)
            {
                Console.Write("Unesite broj {0}: ", k + 1);
                brojevi[k] = int.Parse(Console.ReadLine()); // treba osigurati unos brojeva
                sum += brojevi[k]; // Dodavanje trenutnog broja na zbroj
            }

            Console.WriteLine(brojevi.Sum(b=>sum + b));
            foreach(var b in brojevi)
            {
                Console.WriteLine(b);
            }
            // Ispis zbroja svih unesenih brojeva
            Console.WriteLine("Zbroj svih unesenih brojeva je: " + sum);

            // Ispis svih unesenih brojeva jedno ispred drugog
            Console.Write("Uneseni brojevi su: ");
            for (int k = 0; k < 10; k++)
            {
                Console.Write(brojevi[k] + " ");
            }



        }
    }
}
