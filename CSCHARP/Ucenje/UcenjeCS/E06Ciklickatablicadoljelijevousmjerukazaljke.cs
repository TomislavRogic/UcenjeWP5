using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E06Ciklickatablicadoljelijevousmjerukazaljke
    {
        public static void Izvedi()
        {
            int brojredova = 0;
            int brojkolona = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine("Molim unesite broj redova u tablici izmedu 2 i 50: ");
                    brojredova = int.Parse(Console.ReadLine());
                    if (brojredova >= 2 && brojredova <= 50)
                    {
                        break;
                    }
                    else
                    {
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
                    if(brojkolona>=2 && brojkolona <= 50)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Uneseni broj redova nije izmedu 2 i 50, molim Vas unesite ponovo");
                    }
                }
                catch
                {
                    Console.WriteLine("Neispravan unos. Molim unesite broj kolona izmedu 2 i 50.");
                }
            }









        }
                
       
    }
           
    
}










