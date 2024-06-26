using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E02VarijableTipoviPodataka
    {


        public static  void Izvedi()
        {

            //deklaracija varijable
            int i;6

            // dodjeljivanje vrijednosti i koristenje varijable - operator dodjeljivanja =
            i = 7;

            // koristenje varijable

            Console.WriteLine(i);

            //ucitanje broja od korisnik
            // procitati Why Good Programmers Are Lazy and Dumb

            Console.WriteLine("Molim upisati cijeli broj veći od nule: ");
            int broj = int.Parse(Console.ReadLine());
            Console.WriteLine(broj+1);

            // za decimalne brojeve cemo koristiti float

            Console.WriteLine("Unesi decimalni broj (, je oznaka za decimalni broj): ");
            Console.WriteLine(float.Parse(Console.ReadLine())+1);

            bool uvjet = false;
            Console.WriteLine(uvjet);

            // operatori za rad s varijablama 
            //=,+,-,*,/
            //== operator usporedivanja, tipa bool
            // != razlicito, tipa bool

            int j = 3;
            Console.WriteLine(j==3);
            Console.WriteLine(j!=6);

            //increment i dekrement
            i = 0;
            i = i + 1;
            i += 1;
            i++; // prvo koristi pa uvecaj
            ++i; // prvo uvecaj pa koristi
            i = 1;
            Console.WriteLine(i++); //1
            Console.WriteLine(i);//2
            Console.WriteLine(++i);//3
            Console.WriteLine(i);//3


            //dekrement je ista stvar samo u minu
            i--;
            --i;

            // prekrasni zadaci
            int x = 0, y = 1;
            x = ++x - y; // x =1, y = 1
            y = x-- + y; //x= -1 y=1
            Console.WriteLine(x + y); //0

            // prvo si pocetku dvosatnog vjezbanja doma si zadati zadatak
            // na kraju dvosatnog vjezbanja rijesiti ga

            // operator modulo

            Console.WriteLine("9%2 = {0}",  9%2);
            Console.WriteLine("8%2 = {0}", 8%2);

            x = 5;
            y = 2;

            // int/int daje int
            // mora se raditi cast

            Console.WriteLine(x / (float)y); //(float) cast u tip podatka float







        }




    }
}
