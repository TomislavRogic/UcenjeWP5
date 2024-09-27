using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03FunkcijaKojaVracaVrijednost
    {

        public static void Izvedi()
        {
            //int duploVeciBroj = VratiDuploVeciBroj(8);
            //Console.WriteLine(duploVeciBroj);

            //Console.WriteLine(VratiDuploVeciBroj(6));
            //Console.WriteLine("Molim unesi dva broja");

            /*int prvibroj = int.Parse(Console.ReadLine());
            int drugibroj= int.Parse(Console.ReadLine());
            Console.WriteLine(dvaBroja(prvibroj,drugibroj));*/

            //zadatak
            int[] petbrojeva = new int[5];
            Console.WriteLine("Molim Vas unesite 5 brojeva");
            for (int i = 0; i < 5; i++)
            {
                petbrojeva[i] = int.Parse(Console.ReadLine());
            }

            // Poziv metode koja vraća brojeve veće od 10
            PetBrojeva(petbrojeva);


        }

        /*public static int VratiDuploVeciBroj(int broj)
        {
            return broj * 2;
        }*/

        // fja prima dva broja i vraca veci broj. Ispisati taj broj u Izvedi

        /*public static int dvaBroja(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }*/

        // korisnik upisuje 5 brojeva, spremi ih u polje i proslijedi funkciji koja ce ispisati sve brojeve vece od 10.

        public static void PetBrojeva(int[] brojevi)
        {
            foreach (int broj in brojevi)
            {
                if (broj > 10)
                {
                    Console.WriteLine(broj);
                }
            }
          
        }

        


    }
}
