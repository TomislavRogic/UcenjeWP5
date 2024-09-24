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
            Console.WriteLine("Molim unesi dva broja");

            int prvibroj = int.Parse(Console.ReadLine());
            int drugibroj= int.Parse(Console.ReadLine());
            Console.WriteLine(dvaBroja(prvibroj,drugibroj));

        }

        public static int VratiDuploVeciBroj(int broj)
        {
            return broj * 2;
        }

        // fja prima dva broja i vraca veci broj. Ispisati taj broj u Izvedi

        public static int dvaBroja(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        // korisnik upisuje 5 brojeva, spremi ih u polje i proslijedi funkciji koja ce ispisati sve brojeve vece od 10.
            
    }
}
