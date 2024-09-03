using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.E15KlasaObjekt.edunova;

namespace UcenjeCS.E16NasljedivanjePolimorfizam
{
    internal class Program
    {  // danas se upoznajemo s petom vrstom metoda koja se naziva KONSTRUKTOR
        // ne vraca vrijednost a odredenog je tipa
        // konstruktor- posebna vrsta metode koja se izvrsava kada se kreira objekt- prilikom kreiranja instance klase-objekta
        // kljucna rijec new
        // konstruktor se naziva kao i klasa
        // konstruktori sluze tome da se formalno izvedu u trenutku kreiranja nove instance

        public Program() // metoda KONSTRUKTOR
        {
            Console.WriteLine("Hello from construktor");

            var s = new Smjer(); // ovdje smo kreirali novu objekt ?- da, ovo je instanca klase, objekt je instanca klase, s je objekt
            s.Sifra= 2;
            s.Naziv = "WP";
            // ispisuje 2 i WP
            Console.WriteLine(s.Sifra);
            Console.WriteLine(s.Naziv);
            
            // metoda GETHASHCODE - ispisuje broj koji je vezan uz memoriju gdje je pohranjena instanca
            // to je metoda koja je na klasi Object
            // ispisat ce 43942917- vezan je uz memoriju gdje je pohranjena instanca te klase
            Console.WriteLine(s.GetHashCode());

            // radimo objekt s1
            var s1 = new Smjer() { Sifra = 2, Naziv = "WP" };
            // da li su s1 i s2 jednaki?- imaju iste vrijednosti ali nisu na istim prostorima u memoriji
            Console.WriteLine(s1.GetHashCode());

            // ako sad zelimo napisati EQUALS metodu- ispisat ce false jer su to dvije razlicite instance, odnosno dvije razlicite adrese u memoriji, iako imaju iste vrijednosti, nisu isti objekti
            Console.WriteLine(s.Equals(s1));// ispisuje false, Equals metoda je na klasi Object, a ona usporeduje adrese u memoriji, tipa je bool

            // sada unosimo iste vrijednosti u a, ali ce ispisati razlicite brojeve jer su to razlicite instance
            // linija 43 i linija 45 dati ce van istu vrijednost jer smo rekli ista varijabla, ali daju razlicite vrijednost
            // razlog je taj sto je string immutable- ne moze se promijeniti
            var a = "A";
            Console.WriteLine(a.GetHashCode());
            a = a + "B";
            Console.WriteLine(a.GetHashCode());

            // postoji klasa
            // stringbuilder- mutable- moze se promijeniti
            // stringbuilder je brzi od stringa, stringbilder je sto? to je klasa koja omogucava da se stringovi mogu promijeniti
            StringBuilder sb= new StringBuilder();
            sb.Append('A');
            Console.WriteLine(sb.GetHashCode());// ovo ispise prvi broj, broj koji ispisuje je vezan uz memoriju gdje je pohranjena instanca
            sb.Append('B');
            Console.WriteLine(sb.GetHashCode());// ovo ispise drugi broj, jer se promijenio, broj koji ispisuje je vezan uz memoriju gdje je pohranjena instanca
            Console.WriteLine(sb);// ovo ispisuje AB, jer smo dodali A i B
            // kada radimo s stringbilderom, onda se ne stvara nova instanca, nego se samo mijenja vrijednost, + radi svaki puta novu varijablu , a append ne radi novu varijablu, nego samo mijenja vrijednost
            // radimo li s stringom, svaki put kada se mijenja vrijednost, stvara se nova instanca
            // koristimo samo jednu memorijsku lokaciju kojoj onda ne mijenjamo vrijednost, nego samo dodajemo vrijednost
             // 

            // metoda ToString
            // metoda ToString je metoda koja se nalazi na klasi Object
            // metoda ToString je virtualna metoda
            // ToString metoda se koristi za ispisivanje objekta
            // ToString metoda se koristi za ispisivanje objekta u string
            // ToString metoda se koristi za ispisivanje objekta u string u formatu koji mi zelimo, to znaci da mozemo predefinirati metodu ToString
            // Console.WriteLine(s);  odlazi na metodu Smjer.ToString, a ta metoda nema metodu ToString, pa onda odlazi na metodu Object.ToString
            Console.WriteLine(s.ToString()); // ovako i ne treba
            Console.WriteLine(s); // sada se poziva metoda ToString, jer je ona virtualna metoda, i ona se poziva automatski, treba mi ispisati sifru i naziv
            


            var g= new Grupa() { Sifra=1,DatumPocetka=DateTime.Now};
            Console.WriteLine(g);

            var polaznik=new Polaznik();// ovo je instanca klase Polaznik, objekt je instanca klase, polaznik je objekt, da li je ovo konstruktor? ne, ovo je instanca klase
            polaznik.Sifra = 1;
            polaznik.Ime = "Pero";

            var predavac = new Predavac() { Sifra = 1, Ime = "Marko" };// ovo je instanca klase Predavac, objekt je instanca klase, predavac je objekt, da li je ovo konstruktor? ne, ovo je instanca klase
            // Predavac je klasa, a predavac je objekt, instanca klase je objekt
            // polaznik i predavac su objekti, a Polaznik i Predavac su klase
            // konstruktori su metode koje se izvrsavaju prilikom kreiranja objekta i sluze tome da se formalno izvedu u trenutku kreiranja nove instance
            predavac= new Predavac(2,"Ana","Mak","HR24242424");
            Console.WriteLine("{0} - {1}", polaznik,predavac);

            //var e = new Entitet(); - apstrakna greska u programu, klasa se ne moze instancirati, ali ju mozes naslijediti. ovo je sintaksna greska jer smo rekli da je klasa Entitet apstraktna

            var obradi= new Obrada[2];
            obradi[0]=new ObradaIzlaznihRacuna();
            obradi[1]=new ObradaUlaznihRacuna();

            // polimorfizam- mogucnost da se objekt ponasa kao objekt druge klase

            foreach (var o in obradi)
            {
                o.Procesuiraj();
            }



        }





        // overloads konstruktora

        public Program(string s)
        {
            Console.WriteLine("Hello from construktor " + s);
            



        }
        

        // nasljedivanje ili Polimorfizam- razlicite klase imaju zajednicke osobine
        // Polimorfizam- mogucnost da se objekt ponasa kao objekt druge klase














    }
}
