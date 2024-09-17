using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.TerminiProdajeVozilaKonzolnaAplikacija
{
    internal class UcitajCijeliBroj // internal znaci da je klasa dostupna samo u ovom namespaceu
    {

        public static bool DEV = false;
        public static int UcitajCijelibroj(string poruka = "Unesi broj", int min = 0, int max = 1000)
        {
            int broj = 0;
            while (true)
            {
                Console.WriteLine(poruka + ": ");
                try
                {
                    broj = int.Parse(Console.ReadLine());
                    if (broj < min || broj > max)
                    {
                        Console.WriteLine("Broj mora biti u rasponu {0} i {1}", min, max);
                        continue;
                    }
                    return broj;
                }
                catch
                {
                    Console.WriteLine("Nisi unio broj");
                }
            }

        }
    }
}
