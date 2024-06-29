using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E04UvjetnoGrananjeSwitch
    {
        public static void Izvedi()
        {

            // visestruko grananje
            // if - else if- else if- else if
            int i = 0;

            switch (i)
            {
                case 0:
                    Console.WriteLine("Dobar");
                    break;
                case 1:
                    Console.WriteLine("Los");
                    break;
                case 2:
                    Console.WriteLine("Zao");
                    Console.WriteLine("Zao");
                    break;
                default:
                    Console.WriteLine("Ostalo");
                    break;
            }

                    // switch radi s int, string i char i drugi https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements
                    //float f = 4;
                    //switch (f)
                    //{
                    // case 2:
                    //         Console.WriteLine("OK");
                    //   break;

                    // }

                    char znak = '@';
            Console.WriteLine(znak);
            Console.WriteLine((int) znak);








            


         















        }











    }
}
