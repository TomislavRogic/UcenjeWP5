using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01Z3
    {

        // program od korisnika ucitava ime grada i broj stanovnika
        // ispisuje recenicu U xxxxx zivi xxxx ljudi

        // osigurati da se upise grad
        // psigurati da se upise broj stanovnika kao broj

        public static void Izvedi()
        {
           

            Console.WriteLine("Molim Vas unesite ime grada:");
            var grad = Console.ReadLine();
            Console.WriteLine("Molim unesite broj stanovnika:");
            int bs=int.Parse(Console.ReadLine());


            Console.WriteLine("U {0} zivi {1} stanovnika!", grad, bs);
        }
    }
}
