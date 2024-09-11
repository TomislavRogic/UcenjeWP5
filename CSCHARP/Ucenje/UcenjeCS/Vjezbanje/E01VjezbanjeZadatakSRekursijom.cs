using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01VjezbanjeZadatakSRekursijom
    {
        public static void Izvedi()
        {
            // molim te lagani zadatak s rekursijom
            // zadatak: napiši metodu koja će ispisati sve brojeve od 1 do n
            // npr. ako je n=5, metoda treba ispisati 1 2 3 4 5
            // npr. ako je n=10, metoda treba ispisati 1 2 3 4 5 6 7 8 9 10
            // npr. ako je n=3, metoda treba ispisati 1 2 3

            // npr. ako je n=1, metoda treba ispisati 1

            // kako da to rijesimo s rekurzijom?
            // 1. definiramo metodu koja će ispisati brojeve od 1 do n
            // 2. metoda prima jedan argument, n
            // 3. ako je n=1, ispiši 1
            // 4. inače, ispiši n-1, pa ispiši n

            // 1. definiramo metodu koja će ispisati brojeve od 1 do n
            // kako da definiram metodu koja će ispisati brojeve od 1 do n?
            // 1.1. metoda prima jedan argument, n
            

            int n = 5;
            Console.WriteLine("Unesi n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(
                "Ispisujemo brojeve od 1 do n koristeći rekurziju: ");
            IspisiBrojeveOd1DoN(n);



        }

        public static void IspisiBrojeveOd1DoN(int n)
        {
            // 3. ako je n=1, ispiši 1
            if (n == 1)
            {
                Console.Write(n + " ");
            }
            // 4. inače, ispiši n-1, pa ispiši n
            else
            {
                IspisiBrojeveOd1DoN(n-1);  // zasto n-1? zato sto zelimo ispisati brojeve od 1 do n
                Console.Write(n + " ");
            }
        }

    }
}
