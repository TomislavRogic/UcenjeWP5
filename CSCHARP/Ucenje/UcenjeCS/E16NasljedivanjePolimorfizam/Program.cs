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
        public Program()
        {
            Console.WriteLine("Hello from construktor");
            var p = new Smjer();
            p.Sifra = 2;
            p.Naziv = "WP5";

            Console.WriteLine(p.Sifra);
            Console.WriteLine(p.Naziv);

            Console.WriteLine(p.GetHashCode());
            var s1 = new Smjer() { Sifra = 2, Naziv = "WP" };
            Console.WriteLine(s1.GetHashCode());

            Console.WriteLine(p.ToString()); // ovako i ne treba
            Console.WriteLine(p); // sada se poziva metoda ToString


            var g= new Grupa() { Sifra=1,DatumPocetka=DateTime.Now};
            Console.WriteLine(g);

            var polaznik=new Polaznik();
            polaznik.Sifra = 1;
            polaznik.Ime = "Pero";

            var predavac = new Predavac() { Sifra = 1, Ime = "Marko" };
            Console.WriteLine("{0} - {1}", polaznik,predavac);
        }

        // overloads konstruktora

        public Program(string s)
        {
            Console.WriteLine("Hello from construktor" + s);
            var p =new Smjer();
            p.Sifra = 2;
            p.Naziv = "WP5";

            Console.WriteLine(p.Sifra);
            Console.WriteLine(p.Naziv);

            Console.WriteLine(p.GetHashCode());
            var s1 = new Smjer() { Sifra = 2, Naziv = "WP" };
            Console.WriteLine(s1.GetHashCode());



        }
        

        // nasljedivanje- razlicite klase imaju zajednicke osobine














    }
}
