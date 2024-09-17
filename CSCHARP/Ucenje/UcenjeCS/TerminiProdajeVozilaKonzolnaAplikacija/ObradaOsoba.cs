using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.TerminiProdajeVozilaKonzolnaAplikacija.model;


namespace UcenjeCS.TerminiProdajeVozilaKonzolnaAplikacija
{
    internal class ObradaOsoba
    {
        // opet kad zelimo imati nesto u razlicitim metodama to mora biti deklarirano na razini klase
        // jer bi inace bilo dostupno samo u jednoj metodi

        public List<Osoba>  Osobe    { get; set; }
        public object DodajNovuKontaktOsobu { get; private set; }

        public ObradaOsoba()
        {
            Osobe = new List<Osoba>();
            if (HelperClass.DEV)
            {
                
                UcitajTestnePodatke();
                
            }

        }

        private void UcitajTestnePodatke() // s ovime testiramo ispravnost 

        {
            
            Osobe.Add(new() { Sifra=1, Ime="Marko", Prezime= "Walter", Email="marko.walter@gmail.com"});
            Osobe.Add(new() { Sifra = 2, Ime = "Milan", Prezime = "Prodanovic", Email = "milan.prodanovic@gmail.com" });
            Osobe.Add(new() { Sifra = 3, Ime = "Kristina", Prezime = "Andric", Email = "kristina.andric13@gmail.com" });
        }

        public void PrikaziGlavniIzbornik()
        {
            Console.WriteLine("");
            Console.WriteLine(" RAD S OSOBAMA");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1. Prikazi sve kontakt osobe");
            Console.WriteLine("2. Unesi novu kontakt osobu");
            Console.WriteLine("2. Promjeni detalje kontakt osobe");
            Console.WriteLine("2. Obrisi kontakt osobu");
            Console.WriteLine("5. Povratak u glavni izbornik");
            OdabirOpcijeGlavnogIzbornika();
        }

        private void OdabirOpcijeGlavnogIzbornika()
        {
            switch (UcitajCijeliBroj.UcitajCijelibroj("Odaberite opciju izbornika od 1 do 5", 1, 5))
            {
                case 1:
                    PrikaziSveOsobe();
                    PrikaziGlavniIzbornik();
                    
                    break;
                case 2:
                    DodajOsobu();
                    PrikaziGlavniIzbornik();
                    break;
                case 3:
                    Console.WriteLine("Promjeni kontakt osobu");
                    break;
                case 4:
                    Console.WriteLine("Obrisi kontakt osobu");
                    break;
                case 5:
                    Console.WriteLine("Povratak u glavni izbornik");
                    break;
                default:
                    Console.WriteLine("Nepostojeca opcija");
                    break;
            }
        }

        private void DodajOsobu()
        {
            Osobe.Add(new Osoba()
            {
                Sifra = UcitajCijeliBroj.UcitajCijelibroj("Unesite sifru osobe: ", 1, int.MaxValue),
                Ime = HelperClass.UcitajString("Unesite ime osobe:"),
                Prezime = HelperClass.UcitajString("Unesite prezime osobe: "),
                Email = HelperClass.UcitajString("Unesite email osobe: ")

            });
        }

        private void PrikaziSveOsobe()
        {
            if (Osobe.Count == 0)// ako nema osoba u bazi, ispisujemo poruku
            {
                Console.WriteLine("Nema osoba u bazi.");
            }
            else
            {
                Console.WriteLine("OSOBE IZ BAZE:");
                Console.WriteLine("--------------------------");
                foreach (var osoba in Osobe)
                {
                    Console.WriteLine($"Ime: {osoba.Ime}, Prezime: {osoba.Prezime}, Email: {osoba.Email}");
                }
            }
        }
    }
}
