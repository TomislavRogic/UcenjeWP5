using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E11Z1
    {

        public static void Izvedi()
        {
            // Program ucitava dva broja i ispisuje broj
            Console.WriteLine(
                E11Metode.UcitajCijelibroj("Unesi prvi broj", int.MinValue, int.MaxValue) +
                E11Metode.UcitajCijelibroj("Unesi drugi broj", int.MinValue, int.MaxValue));
        }

    }
}
