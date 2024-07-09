using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E06Z1CiklickatablicaClockwise
    {
        // ciklicka tablica clockwise - prva pozicija dole desno
        public static void Izvedi()
        {
            Console.WriteLine("Molim unesite broj redova u tablici: ");
            int brojredova=int.Parse(Console.ReadLine());
            Console.WriteLine("Molim unesite broj kolona u tablici: ");
            int brojkolona=int.Parse(Console.ReadLine());

            int[,] ciklickatablica = new int[brojredova, brojkolona];
            int broj = 1;

            int gore = 0;
            int dole = brojredova - 1;
            int lijevo = 0;
            int desno= brojkolona - 1;

            while (gore <= dole && lijevo <= desno)
            {
                for (int i = dole; i >= gore; i--) // pocinje od max -1, ide do 0 i pozicija i nakon ispunjavanja ide za 1 manje
                {
                    if (broj <= brojredova * brojkolona)
                        ciklickatablica[i, desno] = broj++; // desni red popunjavanj

                }
                desno--;// nakon popunjavanja smanji za 1 kolonu

                for (int j = desno; j >= lijevo; j--)
                {
                    if (broj <= brojredova * brojkolona)
                        ciklickatablica[gore, j] = broj++;
                }
                gore++;

                for (int i = gore; i <= dole; i++)
                {
                    if (broj <= brojredova * brojkolona)
                        ciklickatablica[i, lijevo] = broj++;
                }
                lijevo++;

                for (int j = lijevo; j <= desno; j++)
                {
                    if (broj <= brojredova * brojkolona)
                        ciklickatablica[dole, j] = broj++;
                }
                dole--;

            }
                for (int i = 0; i < brojredova; i++)
                {
                    for (int j = 0; j < brojkolona; j++)
                    {
                        Console.Write(String.Format("{0,3}", ciklickatablica[i, j]) + " ");
                    }
                    Console.WriteLine();
                }

            



        }

    }
}
