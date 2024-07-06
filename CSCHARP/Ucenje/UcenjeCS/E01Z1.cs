using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UcenjeCS
{
    internal class E01Z1
    {
        public static void Izvedi()
        {
            // zadatak 
            // Korisnik unosi dva cijela broja i ispisuje njihov zbroj
            int b1;
            int b2;

            while (true)
            {
                try
                {
                    Console.WriteLine("Unesi prvi cijeli broj :");
                    b1 = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Unesi drugi cijeli broj :");
                    b2 = int.Parse(Console.ReadLine());
                    break;
                }
                Console.WriteLine(b1 * b2);
            
                

            }
           

            








        }

    }
}
