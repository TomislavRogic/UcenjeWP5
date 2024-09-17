using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.TerminiProdajeVozilaKonzolnaAplikacija
{
    internal class GlavniIzbornik
    {
        // ako zelimo raditi s klasama u svim metodama onda ju moramo deklarirati na vrhu kao property
        public ObradaOsoba ObradaOsoba { get; set; }

        // ovo je konstruktor i njega prvo moramo napraviti
        // zatim u glavnom programu tj kod nas GlavniIZbornik se poziva s new UcenjeCS.TerminiProdajeVozilaKonzolnaAplikacija.GlavniIzbornik();
        public GlavniIzbornik()
        {
            HelperClass.DEV = true; // ovo je postavka da li je aplikacija u razvojnom okruzenju ili ne

            // sada moramo reci
            ObradaOsoba = new ObradaOsoba(); // sada smo napravili instancu klase ObradaOsoba
            // sada cemo pozvati metodu PrikaziGlavniIzbornik

            // kad se pokrene aplikacija prikazi izbornik
            PrikaziGlavniIzbornik(); // unesemo naziv metode koju pozivamo te na zarulju s lijeve strane koja se pojavi generiramo metodu
            // sada smo generirali metodu PrikaziGlavniIzbornik
            // sada cemo napraviti metodu za unos podataka
        }

        private void PrikaziGlavniIzbornik()
        {

            // sada unosimo podatke u konzolu i ispisujemo ih na konzolu 
            Console.WriteLine("                                GLAVNI IZBORNIK:");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("1. Osobe");
            Console.WriteLine("2. Vozila");
            Console.WriteLine("3. Izlaz");
            Console.WriteLine("");// jedan prazan red
            // sada radimo Odabir opcije izbornika koji moramo generirati
            OdabirOpcijeGlavnogIzbornika();

            // moramo imati mehanizam koji kaze Odaberite opciju i od covjeka trazi da unese broj
            // tome nije mjesto u Glavnom izborniku , to cemo napraviti u metodi za unos podataka
            // sada cemo napraviti metodu za unos podataka

            // sada moramo imati mehanizam za unos podataka, da pita korisnika sto zeli
            // sada cemo napraviti metodu za unos podataka
            
        }

        private void OdabirOpcijeGlavnogIzbornika()
        {
            // mi trebamo metodu koja ce nam osigurati ocitanje broja koji korisnik unese
            // poziva se metoda UcitajCijelibroj koju smo napravili u klasi UcitajCijeliBroj, kako bi je
            // mogli koristiti moramo je pozvati
            // sada cemo pozvati metodu UcitajCijeliBroj
            //UcitajCijeliBroj.UcitajCijelibroj("Odaberite opciju izbornika",1,5 );
            // sada smo napravili metodu za odabir opcije glavnog izbornika, s kojom sada mozemo odabrati jednu od opcija Glavnog izbornika
           
            switch (UcitajCijeliBroj.UcitajCijelibroj("Odaberite opciju izbornika od 1 do 3",1,3 ))
            {
                case 1:
                   ObradaOsoba.PrikaziGlavniIzbornik();
                    Console.Clear();
                    PrikaziGlavniIzbornik();
                    break;
                case 2:
                    Console.WriteLine("Odabrali ste rad s vozilima");
                    break;
                case 3:
                    Console.WriteLine("Odabrali ste Izlaz");
                    break;
                default:
                    Console.WriteLine("Nepostojeca opcija");
                    break;
            }
            // koristimo switch naredbu jer znamo da cemo imati vise opcija



        }

        // sada moramo moci setati Izbornikom i odabrati opciju i to radimo s switch naredbom
    }

}
