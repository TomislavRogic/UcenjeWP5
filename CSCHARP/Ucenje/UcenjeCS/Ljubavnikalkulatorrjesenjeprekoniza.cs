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
            int k = 0;

            // sada radimo novi string ime zajedno velikim slovima
            foreach (char slovo in zajedno)
            {
                Console.Write(slovo + " ");
            }
            Console.WriteLine(); // dodajemo novi red nakon ispisa slova

            for (int i = 0; i < zajedno.Length; i++)
            {
                for (int j = 0; j < zajedno.Length; j++)
                {
                    if (zajedno[i] == zajedno[j]) // u ovoj for petlji k vrijednosti su jednake broju ponavljanja svakog slova u ime
                    {
                        k++;// k je broj ponavljanja svakog slova
                    }
                }
                brojSlova[i] = k;
                k = 0; // k se resetira nakon svakog vanjskog loopa
            }

            // ispisujemo broj ponavljanja svakog slova
            foreach (int broj in brojSlova)
            {
                Console.Write(broj + " ");
            }
            Console.WriteLine();




        }
    }
}

    

