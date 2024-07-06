using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E07Z2
    {
        public static void Izvedi()
        {
            // program unosi brojeve sve dok se ne unese broj -1
            // Program ispusje zbroj svih unesenih brojeva

            int i = 0;
            int suma = 0;
            while (true)
            {
                i = int.Parse(Console.ReadLine());
                if (i== -1)
                {
                    break;
                }
                suma += i;
            }

            Console.WriteLine(suma);
        }
    }
}
