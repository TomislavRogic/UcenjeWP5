using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
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

            smjerovi.Add(new Smjer() { Sifra = 11, Naziv = "WP" });
            smjerovi.Add(new() { Sifra = 7, Naziv = "RR" });
            smjerovi.Add(new() { Sifra = 9, Naziv = "AA" });
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

            // Lambda izrazi
            // sto su lambda izrazi? 
            // to su anonimne metode koje se koriste za definiranje delegata
            // delegat je tip podatka koji moze sadrzavati referencu na metodu
            // delegat je slican pokazivacu na funkciju u C++
            // delegat je tip podatka koji moze sadrzavati referencu na metodu


            Console.WriteLine(KlasicnaMetoda(2,3));

            var Zbroj = (int x, int y) => x + y;
            // ispisuje 5, zato sto pozivamo metodu KlasicnaMetoda
            // u C# 7.0 uvedeni su lambda izrazi
            Console.WriteLine(Zbroj(2, 3));

            var Algoritam= (int x, int y) => 
            {

                var t = x + 1;
                return t - y;
            
            };
            Console.WriteLine(Algoritam(2,3));// ispisuje 0, zato je x+1=3, 3-3=0
            // Kreirajte lambda izraz koji za primljeni broj vraca da li je parni ili ne (bool)
            var Parni = (int i) => i % 2 == 0;
            Console.WriteLine(Parni(2)); // ispisuje true


            // pojam Ekstenzije
            // Ekstenzije su metode koje se dodaju na vec postojece klase
            // npr. dodati metodu u klasu string koja ce ispisati broj znakova u stringu
            // metoda se dodaje u statickoj klasi
            // metoda se mora nalaziti u statickoj klasi

            var s= "Osijek";
            Console.WriteLine(s.LastOrDefault()); // ispisuje krajnji znak u stringu

            Console.WriteLine(gradovi.LastOrDefault());// ispisuje zadnji grad u listi, koji je Valpovo, u listi gradovi,koja se nalaiz u klasi Program
            Console.WriteLine(smjerovi.LastOrDefault());// ispisuje zadnji smjer u listi, koji je RR, u listi smjerovi,koja se nalazi u klasi Program, ispisuje se preko metode LastOrDefault
            // LastOrDefault je metoda koja se nalazi u klasi List, a koja se nalazi u namespace System.Collections.Generic

            smjerovi[0].OdradiPosao(); // ispisuje 1, jer smo u klasi Ekstenzije dodali metodu OdradiPosao koja ispisuje Sifru, a Sifra je 1

            o2.ObjektObrade.OdradiPosao(); // ispisuje 2, jer smo u klasi Ekstenzije dodali metodu OdradiPosao koja ispisuje Sifru, a Sifra je 2




            o1.PrikazRadaSSucesljem(); // ispisuje Odradujem posao u Obradi, jer smo u klasi Ekstenzije dodali metodu PrikazRadaSSucesljem koja ispisuje Posao,
                                       // a Posao je Odradujem posao u Obradi
                                       // kako dodem do toga da znam da je Posao u Obradi? U klasi Obrada smo napisali metodu Posao koja ispisuje Odradujem posao u Obradi, a kako to znamo?
                                       // kako znam da gornji kod vuce metodu iz Obrade?  o1.PrikazRadaSSucesljem(); 
                                       // jer smo u klasi Ekstenzije dodali metodu PrikazRadaSSucesljem koja ispisuje Posao, a Posao je Odradujem posao u Obradi
            // kako iz Isucelja dodem do toga da se posao izvrsava u Klasi Obrada?
            // nije mi jos jasno kako se izvodi Posao u Obradi?
            // kako znam da se Posao izvodi u Obradi? jer smo u klasi Obrada napisali metodu Posao koja ispisuje Odradujem posao u Obradi
                
            smjerovi[0].PrikazRadaSSucesljem(); // ispisuje Odradujem posao na Smjeru, jer smo u klasi Ekstenzije dodali metodu PrikazRadaSSucesljem koja ispisuje
                                                // Posao, a Posao je Odradujem posao na Smjeru
            o2.ObjektObrade.PrikazRadaSSucesljem(); // ispisuje Odradujem posao na Polazniku, jer smo u klasi Ekstenzije dodali metodu PrikazRadaSSucesljem
                                                    // koja ispisuje Posao, a Posao je Odradujem posao na Polazniku
        // Zasto gornja linija ispisuje Polaznik, a ne Pero? Zato sto je metoda PrikazRadaSSucesljem u klasi Ekstenzije,
        // a ne u klasi Polaznik, pa se ispisuje Posao, a Posao je Odradujem posao na Polazniku
        // a gdje smo napisali Odradujem posao u Obadi? U klasi Polaznik, u metodi Posao
        // mozes li mi detaljnije ovo objasniti? molim te, polako, korak po korak
        // u klasi Polaznik imamo metodu Posao koja ispisuje Odradujem posao na Polazniku
        // u klasi Ekstenzije imamo metodu PrikazRadaSSucesljem koja ispisuje Posao, a Posao je Odradujem posao na Polazniku
        
        
            smjerovi.Sort(); // sortira smjerove po sifri
            Console.WriteLine(smjerovi.FirstOrDefault()?.Sifra); // ispisuje 7, jer je prvi smjer u listi smjerovi smjer s sifrom 7 

            // custom sortiranje bez implementacije IComparable
            smjerovi.Sort((s1,s2) => s1.Naziv.CompareTo(s2.Naziv)); // sortira smjerove po nazivu

            Console.WriteLine(smjerovi.FirstOrDefault()?.Naziv); // ispisuje RR, jer je prvi smjer u listi smjerovi smjer s nazivom RR


            // klasa Action i Function koji su parametrizirani tipom podatka
            // Action je delegat koji ne vraca vrijednost, sluzi za pozivanje metoda, a Function je delegat koji vraca vrijednost, sluzi za pozivanje metoda
            // Action sluzi da kao parametar metode proslijedis koju metodu treba pozvati

            o1.ListaZaObradu = smjerovi;
            o1.IspisStavaka(TuMeObradi); // ispisuje Obradujem u Programu smjerRR, jer smo u klasi Obrada napisali metodu IspisStavaka koja prima akciju, a akcija je metoda TuMeObradi
            // kako znam da se metoda TuMeObradi izvodi u klasi Program? jer smo u klasi Obrada napisali metodu IspisStavaka koja prima akciju, a akcija je metoda TuMeObradi

            // ovo je nacin kako se moze iterirati kroz listu
            // ova metoda se naziva Action, a moze biti bilo koji naziv

            o1.IspisStavaka(s=>
            {

            Console.WriteLine("I bez poziva metode " + s.Naziv); 
            }); // ispisuje Obradujem u Programu smjer WP, jer smo u klasi Obrada napisali metodu IspisStavaka koja prima akciju, a akcija je metoda TuMeObradi})

            // koja je action metoda? IspisStavaka
            //  o1.IspisStavaka(s=>
            //{

            //    Console.WriteLine("I bez poziva metode " + s.Naziv);
            //});
            // ovaj gore kod je aCTION METODA, A AKCIJA JE METODA TuMeObradi


            // Domaca zadaca: Poigrati se s Funkcion delegatom
            //// https://medium.com/@interviewer.live/func-and-action-in-c-a-complete-guide-dfe8cf31581c
            // Func je delegat koji vraca vrijednost, a Action je delegat koji ne vraca vrijednost


            // ovo je metoda koristenja Func delegata
            Obrada<Smjer> obrada = new Obrada<Smjer>();
            obrada.ListaZaObradu = new List<Smjer>();
            obrada.ListaZaObradu.Add(new Smjer { Sifra = 1, Naziv = "Prvi" });
            obrada.ListaZaObradu.Add(new Smjer { Sifra = 2, Naziv = "Drugi" });
            obrada.IspisStavaka(e => Console.WriteLine(e.Naziv!)); 
        }

        public void TuMeObradi(Smjer s)
        {
            Console.WriteLine("Obradujem u Programu smjer s pozivom metode " + s.Naziv);
        }




        public int KlasicnaMetoda (int x, int y)
        {
            return x + y;
        }








    }
}
