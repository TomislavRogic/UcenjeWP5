using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z3
    {

        // Program od korisnika trazi unos dva cijena broja
        // Program ispisuje manji broj
        
        public static void Izvedi()
        {
            Console.WriteLine("Molim te unesi prvi broj: ");
            int broj1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Molim te unesi drugi broj: ");
            int broj2 = int.Parse(Console.ReadLine());

            if (broj1 > broj2)
            {
                Console.WriteLine("Manji broj je" + broj2);
            } else if (broj1 < broj2)
            {
                Console.WriteLine("Manji broj je" + broj1);
            }else
            {
                Console.WriteLine("Oba broja su jednaka, oba broja su " + broj1);
            }

            // dz isti ali za 3 broja ispisi manji










        }









    }










    }

