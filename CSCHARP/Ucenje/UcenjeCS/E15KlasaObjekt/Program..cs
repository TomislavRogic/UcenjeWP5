using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.E15KlasaObjekt.edunova;

namespace UcenjeCS.E15KlasaObjekt
{
    internal class Program
    {
        // KLASA JE OPISNIK OBJEKTA
        public static void Izvedi()
        {
            Console.WriteLine("Hello OOP!");

            // OBJEKT JE INSTANCA KLASE ODNOSNO POJAVNOST KLASE

            // Osoba je ime klase
            // osoba je ime objekta (instance/pojavnosti)- varijabla
            Osoba osoba; // deklariran bez klase
            osoba = new Osoba(); // instanciranje klase, konstruiranje objekta- RADA SE, kreira se - zauzima memoriju
            osoba.Ime = "Pero"; // objekt zivi i posjeduje vrijednosti - postavljamo ih
            Console.WriteLine(osoba.Ime); // objekt zivi i posjeduje vrijednosti - citamo ih, te vrijednosti se konzumiraju
            osoba.Prezime = "Peric";
            Console.WriteLine(osoba.ImePrezime()); // metoda ImePrezime nije staticna jer nju zovem na objektu

            // u staticnoj metodi ne mozes koristiti svojstva s objekta
            // na kraju objekt (osoba) umire- UNISTAVA GA/CISTI iz memorije
            // MI NE UNISTAVAMO objekt, to radi Garbage Collector


            // drugi nacini kreiranje objekta
            Osoba ravnjatelj = new Osoba
            {
                Sifra=1,
                Ime="Marko",
                Prezime="Kas"
            };


            var direktor = new Osoba { Ime = "Edo" }; // dosta uobicajena praksa, dobra praksa

            Osoba profesor = new () { Prezime = "Reh", Ime="Klara" }; // sada je lijeva strana odlucila koji je tip podatka

            Console.WriteLine(profesor.Ime?.ToUpper()); // javlja zeleno jer smo rekli da moze biti null
           // https://gunnarpeipman.com/csharp-question-marks/
           // https://blog.wordbot.io/tech/what-do-two-question-marks-together-mean-in-c/
           // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/member-access-operators#null-conditional-operators--and-

           var o = new Osoba()
           {
               Ime = "Marija",
               Mjesto=new() { Naziv="Osijek",PostanskiBroj="31000"}
           };
            Console.WriteLine(o.Mjesto?.Naziv?.ToUpper());

            // dugi nacin
            Zupanija obz= new Zupanija();
            obz.Naziv = "Osjecko-baranjska zupanija";

            Mjesto os=new Mjesto();
            os.Naziv = "Osijek";    

            os.Zupanija = obz;

            Osoba ja= new Osoba();
            ja.Ime= "Tomislav";
            ja.Mjesto = os;

            // Ispisite u konzoli iz objekta ja vrijednost Osjecko-baranjska zupanija
            Console.WriteLine(ja.Mjesto?.Zupanija?.Naziv);


            // objekti iz edunova klasa

            var smjer = new Smjer()
            {
                Sifra= E11Metode.UcitajCijelibroj("Unesi sifru",1,10000), Naziv="Web"
            };
            var grupa = new Grupa()
            {
               Naziv="Wp5", Smjer=smjer
            };

           // zadatak: ispisi sifru smjera na grupi WP5
           Console.WriteLine(grupa.Smjer.Sifra);





        }
    }
}
