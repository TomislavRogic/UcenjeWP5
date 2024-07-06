using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z4
    {

        /* koristeci if
         * program ucitrava od korisnika ime grada. u ovisnosti o imenu grada ispisuje regiju prema slijecedeim
         * Osijek- Slavonija
         * Zadar-dalmacija
         * Cakovec-Medimurje
         * Pula-Istra
         * Za ostale unose program ispisuje : Ne znam koja je to regija*/

        // dodatno istu logiku s switch

        public static void Izvedi()
        {
            string grad = "Punitovci";
            if (grad == "Osijek")
            {
                Console.WriteLine("Slavonija");
            }
            else if(grad== "Zadar")
            {
                Console.WriteLine("Dalmacija");

            }
            else if(grad== "Cakovec")
            {
                Console.WriteLine("Medumurje");
            }
            else if(grad== "Pula")
            {
                Console.WriteLine("Istra");
            }
             
            {
                Console.WriteLine("Ne znam koja je to regija");
            }

            


        }

    }
}
