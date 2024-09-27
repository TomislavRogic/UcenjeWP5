using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class VjezbanjeRekurzivnaFunkcija
    {

        public static void Izvedi()
        {
            // rekurzivna funkcija poziva samu sebe
            // moramo imati uvijet zaustavljanja rekurzivne funkcije
            // rekurzivni poziv šalje izmijenjene parametre
            //IspisiBok(3);


            Console.WriteLine(IzracunajFaktorijelu(3));
        }

        public static void IspisiBok(int broj)
        {
            Console.WriteLine("Bok");
            broj -= 1;

            if (broj > 0)
            {
                IspisiBok(broj);
            }
            // funkcija koja ne vraca nista ne mora imati return
        }

        // 3! = 1 * 2 * 3 
        // 5! = 1 *2 *3 * 4 * 5
        public static int IzracunajFaktorijelu(int n)
        {
            // F(3) = 3 * F(2)
            // F(2) =  2 * F(1)
            // F(1) = 1
            if (n == 1)
            {
                return 1;
            }

            return n * IzracunajFaktorijelu(n - 1);
        }

        // Fib(n) = Fib
        // F(1) = 1, F(2) = 1
        // F(n) = F(n-1) + F(n-2)

        // F(4) = F(3) + F(2)
        // F(4) = F(3) + 1 => F(3) = 1 * 1
        // Fin = 1, 1, 2, 3, 5, 8, 13
    }
}
