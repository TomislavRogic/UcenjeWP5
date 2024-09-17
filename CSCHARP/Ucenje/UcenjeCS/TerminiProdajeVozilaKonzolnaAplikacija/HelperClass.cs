using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.TerminiProdajeVozilaKonzolnaAplikacija
{
    internal class HelperClass
    {

        public static bool DEV = false;
        public static string UcitajString(string poruka)
        {
            string s;
            while (true)
            {
                Console.WriteLine(poruka);
                s = Console.ReadLine().Trim();
                if (s.Length == 0)
                {

                   Console.WriteLine("Obavezan unos");
                    continue;
                }
                return s;
            }
        }
    }
}
