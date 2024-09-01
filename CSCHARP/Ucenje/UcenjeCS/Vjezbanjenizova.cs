using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Vjezbanjenizova
    {
        public static void Izvedi()
        {
            // Zadatak 1. Ispisati brojeve iz niza

            /* int[] PrviNiz = { 1, 2, 3, 4, 5 };

             for (int i = 0; i < PrviNiz.Length; i++)
             {
                 Console.WriteLine(i + " Broj u nizu je: " + PrviNiz[i]);

             }
            */

            // Zadatak 2. Unijeti 10 brojeva u niz i ispisati svaki s foreach petljom

            int[] DrugiNiz = new int[10];
            Console.WriteLine("Molim unesite 10 brojeva: ");


            
            for (int i=0; i<DrugiNiz.Length; i++)
            {
                DrugiNiz[i]= int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Brojevi koje ste unijeli su: ");
            foreach (int broj in DrugiNiz)
            {
                Console.WriteLine(broj);
            }











        }
    }
}
