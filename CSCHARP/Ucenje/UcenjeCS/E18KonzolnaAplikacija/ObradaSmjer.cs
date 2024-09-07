using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.E18KonzolnaAplikacija.model;


namespace UcenjeCS.E18KonzolnaAplikacija
{
    public class ObradaSmjer
    {

        public List<Smjer>  Smjerovi { get; set; }

        public ObradaSmjer() 
        {
            Smjerovi = new List<Smjer>();
            if(Pomocno.DEV)
            {
                UcitajTestnePodatke();
            }
        
        }

        private void UcitajTestnePodatke()
        {
            Smjerovi.Add(new Smjer { Sifra = 1, Naziv = "Web programiranje" });
            Smjerovi.Add(new Smjer { Sifra = 2, Naziv = "AAA" });
            Smjerovi.Add(new Smjer { Sifra = 3, Naziv = "BBB" });
            Smjerovi.Add(new Smjer { Sifra = 4, Naziv = "CCC" });
            Smjerovi.Add(new Smjer { Sifra = 5, Naziv = "DDD" });
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Rad s smjerovima");
            Console.WriteLine("1. Prikazi sve smjerove");
            Console.WriteLine("2. Dodaj novi smjer");
            Console.WriteLine("3. Promjeni podatke smjera");
            Console.WriteLine("4. Brisanje smjera");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch(E11Metode.UcitajCijelibroj("Odaberi stavku izbornika", 1, 5))
            {
                case 1:
                    PrikaziSveSmjerove();
                    PrikaziIzbornik();
                    break;
                case 2:
                    DodajNoviSmjer();
                    PrikaziIzbornik();
                    break;
                case 3:
                    PromjeniSmjer();
                    PrikaziIzbornik();
                    break;
                case 4:
                    ObrisiSmjer();
                    PrikaziIzbornik();
                    break;
                case 5:
                    break;

            }
        }

        private void ObrisiSmjer()
        {
            PrikaziSveSmjerove();
            Smjerovi.RemoveAt(
                E11Metode.UcitajCijelibroj("Odaberi redni broj smjera za brisanje", 1, Smjerovi.Count) - 1
                );
            // Smjerovi.Count koristimo jer se niz smjerova moze mjenjati, a ne zelimo da korisnik unese broj veci od broja smjerova
            // da smo koristili fiksno 5, mogli bi dobiti IndexOutOfRangeException, jer korisnik moze unijeti 6, a niz ima 5 elemenata
        }
        //MVP Minimum Viable Product- to je najmanje sto moramo napraviti da bi aplikacija radila, a onda
        //dodajemo nove funkcionalnosti

        private void PromjeniSmjer()
        {
            PrikaziSveSmjerove();
            var s = Smjerovi[
                E11Metode.UcitajCijelibroj("Odaberi redni broj smjera", 1, Smjerovi.Count) - 1 // -1 jer korisniku prikazujemo od 1
                                                                                               // , a indeksi pocinju od 0
                ];

            s.Sifra= E11Metode.UcitajCijelibroj("Unesi novu vrijednost sifre (" + s.Sifra + ")", 1, int.MaxValue);
            s.Naziv= Pomocno.UcitajString("Unesi novi naziv (" + s.Naziv + ")");
        }

        private void DodajNoviSmjer()
        {
            Smjerovi.Add(new()
            {
                Sifra=E11Metode.UcitajCijelibroj("Unesi sifru smjera", 1, int.MaxValue),
                Naziv=Pomocno.UcitajString("Unesi naziv smjera")

            });
        }

        public void PrikaziSveSmjerove()
        {
            if(Smjerovi.Count == 0)
            {
                var staraB= Console.BackgroundColor;
                var staraF=Console.ForegroundColor;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Nema smjerova u bazi");

                Console.BackgroundColor = staraB;
                Console.ForegroundColor = staraF;
                return;
            }

            var rb = 0;// morali smo staviti vanjsku varijablu jer je koristimo u foreach petlji
           foreach(var s in Smjerovi)
            {
                Console.WriteLine(++rb + ". " + s.Naziv);
            }
        }
    }
    
}
