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
            Console.WriteLine("************************************************************");
            // isti kod ali s ubacenim try-catch

            
            
            
            int brojredova1 =0 ;
            int brojkolona1 = 0;
           
            while(true)
            {
                try
                {
                    Console.WriteLine("Molim unesite broj redova u tablici: ");
                    brojredova1 = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Unijeli ste slovo, molim unesite broj!");
                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Molim unesite broj kolona u tablici: ");
                    brojkolona1 = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Unijeli ste slovo, molim unesite broj!");
                }
            }

            int[,] ciklickatablica1 = new int[brojredova1, brojkolona1];
            int broj1 = 1;
            int gore1 = 0;
            int dole1 = brojredova1 - 1;
            int lijevo1 = 0;
            int desno1 = brojkolona1 - 1;


            while (gore1 <= dole1 && lijevo1 <= desno1)
            {
                for (int i = dole1; i >= gore1; i--) // pocinje od max -1, ide do 0 i pozicija i nakon ispunjavanja ide za 1 manje
                {
                    if (broj1 <= brojredova1 * brojkolona1)
                        ciklickatablica1[i, desno1] = broj1++; // desni red popunjavanj

                }
                desno1--;// nakon popunjavanja smanji za 1 kolonu

                for (int j = desno1; j >= lijevo1; j--)
                {
                    if (broj1 <= brojredova1 * brojkolona1)
                        ciklickatablica1[gore1, j] = broj1++;
                }
                gore1++;

                for (int i = gore1; i <= dole1; i++)
                {
                    if (broj1 <= brojredova1 * brojkolona1)
                        ciklickatablica1[i, lijevo1] = broj1++;
                }
                lijevo1++;

                for (int j = lijevo1; j <= desno1; j++)
                {
                    if (broj1 <= brojredova1 * brojkolona1)
                        ciklickatablica1[dole1, j] = broj1++;
                }
                dole1--;

            }
            for (int i = 0; i < brojredova1; i++)
            {
                for (int j = 0; j < brojkolona1; j++)
                {
                    Console.Write(String.Format("{0,3}", ciklickatablica1[i, j]) + " ");
                }
                Console.WriteLine();
            }



        }

    }
}
