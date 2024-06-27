using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UcenjeCS
{
    internal class E02VarijableTipoviPodataka
    {
        // opcija formatiranja koda CTRL + K + D
        public static void Izvedi()
        {

            // deklaracija varijable
            // i je prvo slovo  abecede dolazi od rijeci increment
            int i;

            // dodjeljivanje vrijednosti -  operator dodjeljivanja =
            // prvo smo na liniji 17 definirali mjesto spremanja i rekli da ce biti tip podataka int i unutra moze ici samo cijeli broj
            // onda smo na liniji 22 fiksno stavili broj 7
            i = 7;


            // koristenje varijable
            Console.WriteLine(i);

            // postoji podsustav GARBAGE COLLECTOR-- o automatski provjera i vidi ono sto ti vise ne koristis i oslobodi tu memoriju
            // jer varijabla je prostor u memoriji
            // kad kazemo uzet cemo intiger i u nasoj memoriji koja je podijeljena na sektora kazemo tu cu strpat ovaj intriger i time smanjio memoriju

            // ucitanje varijable od korisnika
            /// procitati Why Good Programmers Are Lazy and Dumb- why  good programers are lazy and dumb
            /// 

            Console.WriteLine("Molim upisati cijeli broj veci od nule: ");
            // ne mozemo pisati int broj = Console.ReadLine(); jer je lijevo broj int a desno je string pa moramo parsirati na slijedeci nacin
            // svaki put kad iz stringa zelimo nesto parsirati ili interpretirati moramo znati u sto cemo, u ovom slucaju int
            int broj = int.Parse(Console.ReadLine());

            // s desne strane se prvo izvodi Console.ReadLine pa se onda pozove int.Parse i onda ubaciti u varijablu s lijeve strane koja je int
            Console.WriteLine(broj + 1);

            // dobijemo ovo
            /*7
  Molim upisati cijeli broj veci od nule:
              1
  2
            */

            // ako kojim slucajem unesemo slovo umjesto brojke program pucat i rjesenje za to cemo rjesavati kasnije

            int rez;
            //Linija int rez; u C# znači deklaraciju varijable nazvane rez koja je tipa int (cijeli broj).
            rez = broj + 1;
            Console.WriteLine(rez);

            // za decimalne brojeve koristiti cemo float, float znaci pluta a pluta pomicna tocka



            Console.WriteLine("Unesi decimalni broj(, je oznaka za decimalni broj):");

            // ako smo na hrvatskom onda je zarez a ako smo na engleskom jeziku onda je tocka

            Console.WriteLine(float.Parse(Console.ReadLine()) + 1);


            // objasnjenje 
            // Console.ReadLine():             Ova metoda čita cijeli redak teksta koji korisnik unese u konzolu i pritisne Enter.
            // Vraća unos korisnika kao string.

            // Console.ReadLine() + 1: Operator + između stringa i broja(1) uzrokuje konkatenaciju.
            //Na primjer, ako korisnik unese 5, Console.ReadLine() + 1 rezultira stringom "51".
            // float.Parse:Metoda float.Parse uzima string i pokušava ga pretvoriti u float.
            //Ako je korisnički unos bio 5, rezultat konkatenacije je "51", što je validan string za parsiranje u float.
            //  Console.WriteLine: Ova metoda ispisuje vrijednost na konzolu.

            // program onda radi ovim redoslijedom
            //Ako korisnik unese 5, redoslijed operacija bit će:

            //Console.ReadLine() vraća "5".
            //float.Parse("5") vraća 5.0.
            //5.0 + 1 daje 6.0.
            //Console.WriteLine(6.0) ispisuje 6 na konzolu.


            // kako definirati logicku vrijednost
            // to radimo s boolean
            bool uvjet = false;
            Console.WriteLine(uvjet);
            //Deklaracija i inicijalizacija: Varijabla uvjet se deklarira kao boolean (bool) i postavlja se na false.
            // Ispisivanje: Vrijednost varijable uvjet(false) ispisuje se na konzolu.
            // kada pokrenemo ovaj kod ispisat ce nam 
            // False

            // operatori za rad s varijablama
            // = , +, *, /

            // == operator usporedivanja, tipa bool

            int j = 3;
            Console.WriteLine(j == 3);
            // samo usporedujemo da li je j jednako 3

            // sada zelimo razlicito, tipa bool
            Console.WriteLine(j != 6);

            // operator increment i decrement

            i = 0;
            i = i + 1;// i je 1

            // skraceno se jos da napisati
            i += 1;
            i++; // dva puta uvecaj za 1 - je increment , kaze prvo koristi za uvecaj
            ++i; // prvo uvecaj pa koristi

            // resetiramo i
            i = 1;
            Console.WriteLine(i++); //1 Ispisuje 1, zatim povećava i na 2
            Console.WriteLine(i); // 2 jer ju je gornja linija uvecala za 1
            Console.WriteLine(++i); // prvo se uveca pa se ispise i dobijemo 3
            Console.WriteLine(i); // 3, ispisuje 3 jer nismo uvecavali



            // pojam debuger
            // stanemo skroz lijevo (prije brojeva linija) gdje se pojavi kuglica
            // to je takozvani break point, kod pokretanja dode do te tocke i stane

            // onda mozemo gore ici na step bi step , 3 polja desno od tipke stop


            // dekrement je ista stvar samo u minus
            i--;
            --i;


            // Prekrasni podaci
            int x = 0, y = 1;
            x = ++x - y; // x ce postat 1, y=1, x= 1 -1=0
            y = x-- + y; // 0+1=1, y=1, pa nakon - y, --x= -1, x+y= -1 +1 =0
            Console.WriteLine(x + y); // ispisuje 0

            // prvo na pocetku dvosatnog zadatka si zadati zadatak
            // prvo si zadati zadatak od dva - tri reda

            // operator modulo, 3 modul od 2 je 1 jer kad 3 podijelimo s dva dobijemo cijeli broj 1, modulo je %, 3 cjelobrojno podijeljeno s dva je 1 jer zaokruzuje na cijeli broj
            // 9 modul od 2 je 4 * 2 = 8, 9 -8=1 
            //4 modul od 2, 4/2=2, 2*2=4,4-4=0
            // kod neparnih brojeva je 1, kod parnih je nula

            // Console.WriteLine("9%2 = {0}", 9%2);// tu nismo stavili razmak a kad stisnemo CRTL + K + D formatira kako treba biti
            Console.WriteLine("9%2 = {0}", 9 % 2);
            Console.WriteLine("8%2 = {0}", 8 % 2);


            x = 5;
            y = 2;

            //Console.WriteLine(x / y);
            // pravilo kaze ako dijelis cijeli broj s cijelim brojem dobijes cijeli broj jer nije oznacen kao decimala

            // da bi dobili kao decimalu
            Console.WriteLine(x / (float)y);
            //(float) cast u tip podatka float, castat mozemo samo int, ne mozes string












        }












    }
}
