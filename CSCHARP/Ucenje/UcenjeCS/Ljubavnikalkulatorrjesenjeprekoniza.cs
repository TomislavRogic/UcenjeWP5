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

            string zajedno = (mojeime + " " + partner).ToUpper();
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
                if (zajedno[i] != ' ') // Preskočite razmake
                {
                    brojSlova[i] = BrojPojavljivanja(zajedno, zajedno[i], 0);
                }
            }

            // Dodajemo niz brojevi i promenljivu brojeviCount
            int[] brojevi = new int[zajedno.Length];
            int brojeviCount = 0;

            // Ispisujemo broj ponavljanja svakog slova i popunjavamo niz brojevi
            for (int i = 0; i < brojSlova.Length; i++)
            {
                if (zajedno[i] != ' ') // Preskočite ispis za razmake
                {
                    Console.Write(brojSlova[i] + " ");
                    brojevi[brojeviCount++] = brojSlova[i];
                }
                else
                {
                    Console.Write("  "); // Dodajte dva razmaka za razmake
                }
            }
            Console.WriteLine(); // Prelazak u novi red

            // Zbrajanje brojeva dok ne dođemo do dva broja
            while (brojeviCount > 2)
            {
                brojeviCount = ZbrajanjeVanjskiPremaUnutarnji(brojevi, brojeviCount);
                for (int i = 0; i < brojeviCount; i++)
                {
                    Console.Write(brojevi[i] + " ");
                }
                Console.WriteLine(); // Prelazak u novi red
            }
        }

        // Rekurzivna funkcija za brojanje pojavljivanja slova
        private static int BrojPojavljivanja(string zajedno, char slovo, int index)
        {
            if (index >= zajedno.Length)
            {
                return 0;
            }

            if (zajedno[index] == ' ') // Preskočite razmake
            {
                return BrojPojavljivanja(zajedno, slovo, index + 1);
            }

            int count = zajedno[index] == slovo ? 1 : 0;
            return count + BrojPojavljivanja(zajedno, slovo, index + 1);
        }

        // Funkcija za zbrajanje vanjskih brojeva prema unutarnjim
        private static int ZbrajanjeVanjskiPremaUnutarnji(int[] brojevi, int brojeviCount)
        {
            int[] noviBrojevi = new int[brojeviCount];
            int noviBrojeviCount = 0;
            int i = 0, j = brojeviCount - 1;

            while (i < j)
            {
                int suma = brojevi[i] + brojevi[j];
                noviBrojevi[noviBrojeviCount++] = suma;
                i++;
                j--;
            }

            // Ako je neparan broj cifara, dodajemo srednji broj
            if (i == j)
            {
                noviBrojevi[noviBrojeviCount++] = brojevi[i];
            }

            // Kopiramo nove brojeve nazad u originalni niz
            for (i = 0; i < noviBrojeviCount; i++)
            {
                brojevi[i] = noviBrojevi[i];
            }

            return noviBrojeviCount;
        }
    }







}





    


    

