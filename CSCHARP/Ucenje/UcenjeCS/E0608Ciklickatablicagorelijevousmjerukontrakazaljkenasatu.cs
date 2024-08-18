using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E0608Ciklickatablicagorelijevousmjerukontrakazaljkenasatu
    {
        public static void Izvedi()
        {
            string pitanje;
            int brojkreiranihtablica = 0;
            do
            {
                int brojredova = 0;
                int brojkolona = 0;

                while (true)
                {
                    try
                    {
                        if (brojredova >= 2 && brojredova <= 50)
                        {
                            break;
                        }
                        else
                        {
                        Console.WriteLine("Molim unesite broj redova u tablici izmedu 2 i 50: ");
                        brojredova = int.Parse(Console.ReadLine());
                            Console.WriteLine("Uneseni broj redova nije izmedu 2 i 50, molim Vas unesite ponovo");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Neispravan unos. Molim unesite broj redova izmedu 2 i 50.");
                    }

                }
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Molim unesite broj kolona u tablici izmedu 2 i 50:");
                        brojkolona = int.Parse(Console.ReadLine());
                        if (brojkolona >= 2 && brojkolona <= 50)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Uneseni broj kolona nije izmedu 2 i 50, molim Vas unesite ponovo");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Neispravan unos. Molim unesite broj kolona izmedu 2 i 50.");
                    }
                }
                int[,] ciklickatablica = new int[brojredova, brojkolona];
                int broj = 2;
                int gore = 0;
                int dole = brojredova - 1;
                int lijevo = 0;
                int desno = brojkolona - 1;
                while (gore <= dole && lijevo <= desno)
                {// gore lijevo prema desno
                    for (int j = lijevo; j <= desno; j++)
                    {

                        ciklickatablica[gore, j] = broj++;
                    }
                    gore++;
                    //desno gore prema dole
                    for (int i = gore; i<= dole; i++)
                    {

                        ciklickatablica[i, desno] = broj++;
                    }
                    desno--;

                    // dole desno prema lijevo
                    for (int j = desno; j >= lijevo; j--)
                    {

                        ciklickatablica[dole, j] = broj++;
                    }
                    dole--;

                    //lijevo dole prema gore
                    for (int i = dole; i >= gore; i--)
                    {

                        ciklickatablica[i, lijevo] = broj++;
                    }
                    lijevo++;

                }
                for (int i = 0; i < brojredova; i++)
                {
                    for (int j = 0; j < brojkolona; j++)
                    {
                        Console.Write(String.Format("{0,3}", ciklickatablica[i, j]) + " ");
                    }
                    Console.WriteLine();
                }
                brojkreiranihtablica = brojkreiranihtablica + 1;

                // unos dodatnog pitanja da li korisnik zeli napraviti jos jednu tablicu

                // Provjera broja kreiranih tablica
                if (brojkreiranihtablica >= 2)
                {
                    Console.WriteLine("Napravili ste maksimalan broj cikličkih tablica. To bi bilo sve za danas :) !");
                    break;
                }

                // Unos pitanja o kreiranju nove tablice
                bool ispravanUnos = false;
                while (!ispravanUnos)
                {
                    Console.WriteLine("Želite li napraviti još jednu tablicu? (da/ne) ");
                    pitanje = Console.ReadLine().ToLower();

                    switch (pitanje)
                    {
                        case "da":
                            ispravanUnos = true;
                            break;
                        case "ne":
                            Console.WriteLine("Hvala Vam na Vašem vremenu. Želimo Vam ugodan dan!");
                            return; // Izlazak iz metode
                        default:
                            Console.WriteLine("Neispravan unos. Molim odgovorite s 'da' ili 'ne'.");
                            break;
                    }
                }

            } while (true);





        }
    }
}
