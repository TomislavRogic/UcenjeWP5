using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03UvjetnoGrananjeIf
    {

        public static void Izvedi()
        {


            int i = 7; // Ovo simuliramo da je korisnik pomocu int.Parse CR ucitao vrijednost

            // grananje - binarno (True or False) ili visestruko grananje prva,druga, treca,cetvrta,peta)
            // binarno grananje je If i ono radi s bool tipom podatka


            bool uvjet = i == 8 ;
            Console.WriteLine(uvjet);

            // If radi s bool tipom podatka

            if(uvjet)
            {
                Console.WriteLine("Vrijednost varijable i je 8");
            }


            // ovo nikad ne pisati
           // if (uvjet == true)
            {

            }

            // najcesca sintaksa
            if (i==8)
            {

            }

            // if ima i else granu
            if (i>10)
          {
                Console.WriteLine("i je veci od 10");

            }
            else
            {
                Console.WriteLine("i nije veci od 10");
           }

            // if ne mora imati viticastu zagradu {} ako se if ili else odnose samo na jednu liniju

            // ovo je najbolja praksa. Best practice

            if(i>10) Console.WriteLine("i je veci");
            else Console.WriteLine("i nije veci od 10");

            // puna sintaksa if naredbe- if, else, else if
            int b = 2;
            if (b == 1) // ako je b =1 prikazuje Ne moze
            {
                Console.WriteLine("Ne moze");
            } else if (b > 5) // ako je b vece od 5 ispisuje Ok
            {
                Console.WriteLine("Ok");
            } // jos moze ici nn else if dijelova , ako b nije 1 i nije vece od 5 pokazuje ostalo
            else
            {
                Console.WriteLine("ostalo");
            }

            // operatori and & i and and &&
            // & uvijek provjerava oba uvjeta
            //&& ukoliko prvi uvjet nije zadovoljen drugi se i ne gleda
            int x = 2, y = 1;

            if (x==1 && y == 1)
            {
                Console.WriteLine("x i y su 1");
            }

            // operatori ALTGR + W| ||  OR, znak se zove pike, na netu ascii table
            // | provjerava oba uvjeta
            // || ukoliko je prvi uvjet zadovoljen, ne gleda se drugi

            if (x>1 || y == 0)
            {
                Console.WriteLine("ako je prvi uvjet zadovoljen ulazi se u if");
            }

            // if se moze gnijezditi
            if (x == 3)
            {
                int k = 9; // ako varijabla ce biti deklarirana samo ako je x 3
                if (i>0)
                {
                    Console.WriteLine("Zadovoljeno");
                }
                
            }




            // inline if- tercijarni operator?:
            x = 0;
            if (x == 0)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("NE");
            }

            // preduvjet je da if i else provode istu akciju -  u ovom slucaju ce

            Console.WriteLine(x==0 ? "OK" : "NE");









        }























    }
}
