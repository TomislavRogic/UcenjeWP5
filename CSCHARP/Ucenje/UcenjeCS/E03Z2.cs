using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z2
    {

        // Program od korisnika trazi unos cijelog broja
        // Program ispisuje da li je broj paran ili neparan
        
        public static void Izvedi()
        {
            Console.WriteLine("Molim te unesi broj: ");
            int broj = int.Parse(Console.ReadLine());
            if(broj % 2 == 0)
            {
                Console.WriteLine("broj " + broj + " je paran!");
            }
            else
            {
                Console.WriteLine("broj " + broj +  " je neparan!");
            }

            // pisanje iste naredbe ali s inline if naredbom ? :
            //OVO JE RIJESENJE KOJE JE DAO GTP
            //Console.WriteLine("Broj " + broj + " je " + (broj % 2 == 0 ? "paran!" : "neparan!"));

            // ovo je profesorovo rjesenje
            Console.WriteLine(broj %2 == 0 ? "PARAN" : "NEPARAN");











        }









    }










    }

