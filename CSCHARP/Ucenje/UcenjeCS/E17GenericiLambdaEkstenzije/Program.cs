using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E17GenericiLambdaEkstenzije
{
    internal class Program
    {

        public Program()
        {
            // glavni problem rada s nizovima: Ograniceni s inicijalnim brojem elemenata
            // Rjesenje : koristiti genericke klase
            // Klasa List je parametrizirana (TIPA) tipom podatka int i u integeri varijablu mogu ici samo brojevi
            List<int> integeri= new List<int>();

            integeri.Add(1);
            integeri.Add(21);
            // integeri.Add("2"); // nece raditi jer je tip podatka int
            Console.WriteLine(integeri[0]);

            // sada ista klasa ali list stringova
            List<string> gradovi = new List<string>();
            gradovi.Add("Osijek");
            gradovi.Add("Valpovo");

            // Valpovo ispisem
            Console.WriteLine(gradovi[1]);


            List<Smjer> smjerovi = new List<Smjer>();

            smjerovi.Add(new Smjer() { Sifra = 1, Naziv = "WP" });
            smjerovi.Add(new() { Sifra = 7, Naziv = "RR" });

            // iz liste smjerovi ispisati broj 7
            Console.WriteLine(smjerovi[1].Sifra);

            // ovo je koristenje generika


            // Obrada<string> p= new Obrada<string>(); // string ne nasljeduje entitet pa ne ide

            Obrada<Smjer> o1 = new Obrada<Smjer>();
            o1.ObjektObrade = new Smjer() { Sifra = 1, Naziv = "WP" };

            Obrada<Polaznik> o2 = new Obrada<Polaznik>();

            o2.ObjektObrade = new() { Sifra = 2, Ime = "Pero", Prezime = "Peric" };

            o1.Obradi();
            o2.Obradi();

            // Kreirajte listu datuma i u nju dodajte 2 datuma
            //1. Datum Vaseg rodenja
            //2. danasnji datum

            List<DateTime> datumi = new List<DateTime>();
            datumi.Add(new DateTime(1982, 2, 25));
            datumi.Add(DateTime.Now);

            // kako da to ispisem?
            Console.WriteLine(datumi[0]);
            Console.WriteLine(datumi[1]);

            // mogli smo i ovako napisati
            // List<DateTime> vremena = new List<DateTime>() {
            //new DateTime(1980, 12, 7), DateTime.Now
            //};


















    }










    }
}
