using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E13Vjezbanje
    {

        public static void Izvedi()
        {

            Zadatak1();
        }

        private static void Zadatak1()
        {
            // koliko elemenata ima niz int brojeva
            Console.WriteLine(PodaciInt.niz.Length);
            // Postoje li dva ista broja? Ako postoji koji je to broj?

            var niz=PodaciInt.niz;
            DateTime pocetak=DateTime.Now;
            for (var i = 0; i < niz.Length; i++) 
            { 
                if (i% 1000 == 0)
                {
                    Console.WriteLine(i);
                }
                for(var j=i+1;j< niz.Length; j++)
                {
                    if (niz[j] == niz[i])
                    {
                        Console.WriteLine(j);
                        break;
                    }
                    
                }
            }
            Console.WriteLine("Trajalo{0}", DateTime.Now - pocetak);

        }
    }
}
