using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E07WhilePetlja
    {
        public static void Izvedi()
        {
            //pojam ulaska u petlj
            //u for petlju se mora uci

            int brojDo = 10; // ovo moze unijeti korisnik
            for(int i = 0; i < brojDo; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("*************************");

            // if radi s bool tipom podatka
            // switch radi s brojevima, char i string
            // while radi s bool tipom podatka

            while(true)
            {
                for (int i = 0; i<10; i++)
                {
                    Console.WriteLine(new Random().Next() + " ");
                }
                Console.WriteLine();
                Thread.Sleep(100);
                break;
            }
            brojDo = 10;
            while (brojDo-- > 0) 
            {
                Console.WriteLine(brojDo);
            }

            int j = 2;
            while (brojDo < 10 && j == 2)
            {
                Console.WriteLine(brojDo++);
            }
            Console.WriteLine("*************************");

            brojDo = 0;
            while (brojDo < 10)
            {
                if (++brojDo == 2)
                {
                    continue;
                }
                Console.WriteLine(brojDo);
                brojDo++;
                //brojDo += 1;
                //brojDo = brojDo + 1;
            }
            Console.WriteLine("*************************");
            brojDo = 1;

            while (brojDo <= 10)
            {
                j = 1;
                while (j <= 10)
                {
                    Console.WriteLine(brojDo++ * j++ + "/t ");
                }
                Console.WriteLine();
                brojDo++;
            }

            // hoce li se uvijek uci u while petlju
            //nece
            brojDo = 0;
            while (brojDo > 0)
            {
                Console.WriteLine(brojDo);// ovo se nece ispisati
            }

            
        }


    }
}
