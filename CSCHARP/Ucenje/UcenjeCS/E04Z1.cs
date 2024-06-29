using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E04Z1
    {
        // korisnik unosi brojcanu vrijednost ocjene od 1 do 5
        // Program ispisuje slovno ocjenu, ako korisnik nije unio ocjenu
        // Program ispisuje broj nije ocjena

        public static void Izvedi()
        {

            Console.WriteLine("Molim unesite ocjenu od 1 do 5: ");
            int ocjena = int.Parse(Console.ReadLine());
            switch (ocjena)
            {
                case 1:
                    Console.WriteLine("A");
                    break;
                case 2:
                    Console.WriteLine("B");
                    break;
                case 3:
                    Console.WriteLine("C");
                    break;
                case 4:
                    Console.WriteLine("D");
                    break;
                case 5:
                    Console.WriteLine("E");
                    break;
                default:
                    Console.WriteLine("Broj nije ocjena");
                    break;

            }









        }


    }
}
