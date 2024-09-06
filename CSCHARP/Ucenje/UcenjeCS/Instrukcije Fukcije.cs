using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Instrukcije_Fukcije
    {
        public static void Izvedi()
        {
            Console.WriteLine("Prije fje");
            ObicniIspis();
            Console.WriteLine("Nakon fje");

            Console.WriteLine("Upisite dva broja");
            int prvi = int.Parse(Console.ReadLine());
            int drugi = int.Parse(Console.ReadLine());
            Zbroj(drugi, prvi);

            int aaa = int.Parse(Console.ReadLine()); // 6
            Uvecavanje(ref aaa);
            Console.WriteLine(aaa);
        }

        //public static void main(string[] args)
        //{

        //}

        
        static void ObicniIspis()
        {
            Console.WriteLine("Ja sam funkcija");
        }

        static void Zbroj(int a, int b) // primamo kopije primljenih vrijednost
        {
            int zbroj = a + b;
            Console.WriteLine("Zbroj: " + zbroj);
        }

        static void Uvecavanje(ref int a) // primamo referencu na varijablu
        {
            a = a + 20;
            Console.WriteLine(a);
        }

    }
}
