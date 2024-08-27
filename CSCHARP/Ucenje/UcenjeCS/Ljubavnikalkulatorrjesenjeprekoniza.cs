using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Ljubavnikalkulatorrjesenjeprekoniza
    {
        public static void Izvedi()
        {
            Console.WriteLine("Unesi svoje ime:");
            string mojeime = Console.ReadLine();

            Console.WriteLine("Unesi partnerovo ime:");
            string partner = Console.ReadLine();

            string zajedno = (mojeime + partner).ToUpper();
            int[] brojSlova = new int[zajedno.Length];

            // sada radimo novi string ime zajedno velikim slovima
            foreach (char slovo in zajedno)
            {
                Console.Write(slovo + " ");
            }
            Console.WriteLine(); // dodajemo novi red nakon ispisa slova

            // Koristimo rekurziju za brojanje pojavljivanja slova
            for (int i = 0; i < zajedno.Length; i++)
            {
                brojSlova[i] = BrojPojavljivanja(zajedno, zajedno[i], 0);
            }

            // ispisujemo broj ponavljanja svakog slova
            foreach (int broj in brojSlova)
            {
                Console.Write(broj + " ");
            }
            Console.WriteLine();
        }

        // Rekurzivna funkcija za brojanje pojavljivanja slova
        private static int BrojPojavljivanja(string zajedno, char slovo, int index)
        {
            if (index >= zajedno.Length)
            {
                return 0;
            }

            int count = zajedno[index] == slovo ? 1 : 0;
            return count + BrojPojavljivanja(zajedno, slovo, index + 1);
        }
    }




}
    


    

