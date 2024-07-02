using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Vjezbanje
    {
        public static void Izvedi()
        {

            int i;
            i = 4;
            Console.WriteLine(i);
            Console.WriteLine("Molim unesite i");
           int broj = int.Parse(Console.ReadLine());
            Console.WriteLine(broj +2);
            //int novibroj;
            //novibroj = broj + 5;
            //Console.WriteLine(novibroj + 5);

            // vjezbanje desimalnih zapisać
            Console.WriteLine("Molim unesite decimalni zapis: ");
            Console.WriteLine(float.Parse(Console.ReadLine()) + 1);

            // logicka vrijednost
            bool uvjet = true;
            Console.WriteLine(uvjet);


            // usporedujemo i kojem smo dali vrijednost 5 s 5, ako je i razlicto od 5 javlja false a ako je isto ajvlja true
            i = 5;
            Console.WriteLine(i == 1);

            //bool razlicito
            Console.WriteLine(i != 2);

            // increment i dekrement
            i = 1;
            Console.WriteLine(i);// prikazuje 1
            Console.WriteLine(i++); //1 Ispisuje 1, zatim povećava i na 2
            Console.WriteLine(i); // sada je 1 odozgo povecan na 2 i ispisuje 2















        }














    }
}
