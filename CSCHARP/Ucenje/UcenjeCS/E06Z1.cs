using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

            Console.WriteLine("**************************");

            // ovo je primjer kako zamjeniti pozicije brojevima 25 i 24

            int brojprimjer = 25; // Varijabla za praćenje trenutnog broja
            int[,] tablica = new int[5, 5]; // Kreiranje dvodimenzionalnog niza 5x5

            for (int i = 0; i < 5; i++) // Vanjska petlja za redove
            {
                for (int j = 0; j < 5; j++) // Unutarnja petlja za stupce
                {
                    tablica[i, j] = brojprimjer;
                    brojprimjer--;
                }
            }

            // Zamjena mjesta broju 25 i 24 unutar petlje
            for (int i = 0; i < 5; i++) // Vanjska petlja za redove
            {
                for (int j = 0; j < 5; j++) // Unutarnja petlja za stupce
                {
                    if (tablica[i, j] == 25)
                    {
                        tablica[i, j] = 24;
                    }
                    else if (tablica[i, j] == 24)
                    {
                        tablica[i, j] = 25;
                    }
                    // zamjenio sam mjesta 23 i 24
                    int temp = tablica[0, 0];
                    tablica[0, 0] = tablica[0, 2];
                    tablica[0, 2] = temp;
                }
            }

            // Ispisivanje matrice s zamijenjenim vrijednostima
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(String.Format("{0,3}", tablica[i, j]) + " ");
                }
                Console.WriteLine(); // Prelazak u novi red
            }


            Console.WriteLine("***********************");

                    int[,] tablica2 = new int[5, 5]; // Kreiranje dvodimenzionalnog niza 5x5

                      int vrijednost = 1; // Početna vrijednost za ispis (počinje s 1)
                      int n = 5; // Veličina matrice (5x5)

                      for (int k = 0; k < n / 2; k++) // Petlja za broj spiralnih krugova (ima 2 kruga za 5x5 matricu)
                      {
                          // Idemo s lijeva na desno po gornjem rubu matrice
                          for (int i = k; i < n - k; i++)
                          {
                              tablica2[k, i] = vrijednost++;
                          }


                          // Idemo s vrha prema dnu po desnom rubu matrice
                          for (int i = k + 1; i < n - k; i++)
                          {
                              tablica2[i, n - k - 1] = vrijednost++;
                          }

                          // Idemo s desna na lijevo po donjem rubu matrice
                          for (int i = n - k - 2; i >= k; i--)
                          {
                              tablica2[n - k - 1, i] = vrijednost++;
                          }

                          // Idemo s dna prema vrhu po lijevom rubu matrice
                          for (int i = n - k - 2; i > k; i--)
                          {
                              tablica2[i, k] = vrijednost++;
                          }
                      }

                      // Ispisivanje matrice
                      for (int i = 0; i < n; i++)
                      {
                          for (int j = 0; j < n; j++)
                          {
                              Console.Write(String.Format("{0,3}", tablica2[i, j] + 1) + " ");
                          }
                          Console.WriteLine(); // Prelazak u novi red nakon svakog reda matrice
                      }

            int primjer = 12;
            for (int i = 0;i < 3; i++)
            {
                for(int j = 0;j < 3; j++)
                {
                    Console.Write(primjer  + "");
                    primjer--;
                }
                Console.WriteLine();
            }

            int[,] tablica3 = new int[5, 5];
            int broj3 = 25;

            // Prvi red, ispisivanje s lijeva na desno od 25 do 21
            for (int j = 0; j < 5; j++)
            {
                tablica3[0, j] = broj3--;
            }

            // Drugi red, ispisivanje s desna na lijevo od 20 do 16
            for (int j = 4; j >=0; j--)
            {
                tablica3[1, j] = broj3--;
            }

            // Ispisivanje matrice
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(String.Format("{0,3}", tablica3[i, j]) + " ");
                }
                Console.WriteLine();
            }

        }
        
    }

}


    

