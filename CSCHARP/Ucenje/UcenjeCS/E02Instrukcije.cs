using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E02Instrukcije
    {
        public static void Izvedi()
        {
            // Funkcija prima broj 
            // treba ispisati broj je djeljiv s 3 ili broj je djeljiv s 2 i 3 
            // ako nije nista od navedenoga treba ispisati taj broj
            // treba pozvati funkciju za sve brojeve od 1 do 30
            for (int i = 1; i <= 30; i++)
            {
                Console.WriteLine("Upisi broj izmedu 1 i 30");
                int broj = int.Parse(Console.ReadLine());
                IspisiDjeljivost(broj);
            }
        }

        private static void IspisiDjeljivost(int broj)
        {
            if (broj % 2 == 0 && broj % 3 == 0)
            {
                Console.WriteLine("Broj koji ste unijeli djeljiv je s 2 i 3");
            }
            else if (broj % 3 == 0)
            {
                Console.WriteLine("Broj koji ste unijeli djeljiv je s 3");
            }
            else if (broj % 2 == 0)
            {
                Console.WriteLine("Broj koji ste unijeli djeljiv je  s 2");
            }
            else
            {
                Console.WriteLine(broj);
            }
        }
    }
}
