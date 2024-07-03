using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E06Z1
    {
        public static void Izvedi()
        {
            int broj = 25; // Varijabla za praćenje trenutnog broja
            for (int i = 0; i < 5; i++) // Vanjska petlja za redove
            {
                for (int j = 0; j < 5; j++) // Unutarnja petlja za stupce
                {
                    Console.Write(String.Format("{0,3}", broj) + " ");
                    broj--;
                }
                Console.WriteLine(); // Prelazak u novi red

            }

            Console.WriteLine("***********************");

            int[,] tablica = new int[5, 5]; // Kreiranje dvodimenzionalnog niza 5x5

            int vrijednost = 1; // Početna vrijednost za ispis (počinje s 1)
            int n = 5; // Veličina matrice (5x5)

            for (int k = 0; k < n / 2; k++) // Petlja za broj spiralnih krugova (ima 2 kruga za 5x5 matricu)
            {
                // Idemo s lijeva na desno po gornjem rubu matrice
                for (int i = k; i < n - k; i++)
                {
                    tablica[k, i] = vrijednost++;
                }

                // Idemo s vrha prema dnu po desnom rubu matrice
                for (int i = k + 1; i < n - k; i++)
                {
                    tablica[i, n - k - 1] = vrijednost++;
                }

                // Idemo s desna na lijevo po donjem rubu matrice
                for (int i = n - k - 2; i >= k; i--)
                {
                    tablica[n - k - 1, i] = vrijednost++;
                }

                // Idemo s dna prema vrhu po lijevom rubu matrice
                for (int i = n - k - 2; i > k; i--)
                {
                    tablica[i, k] = vrijednost++;
                }
            }

            // Ispisivanje matrice
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(String.Format("{0,3}", tablica[i, j] + 1) + " ");
                }
                Console.WriteLine(); // Prelazak u novi red nakon svakog reda matrice
            }



        }


    }
}
