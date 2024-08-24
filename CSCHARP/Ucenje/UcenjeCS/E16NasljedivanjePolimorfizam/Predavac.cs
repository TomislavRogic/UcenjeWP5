using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljedivanjePolimorfizam
{
    internal class Predavac:Osoba
    {
        public Predavac() { } // da li je ovo konstruktor? Da, ovo je konstruktor bez parametara
        // mi ga moramo navesti jer smo definisali konstruktor sa parametrima
        public Predavac(int sifra, string ime, string prezime, string IBAN) // konstruktor sa parametrima
        {
            base.Sifra = sifra;
            base.Ime = ime;
            base.Prezime = prezime;
            this.IBAN = IBAN;
        }
        public string? IBAN { get; set; }

    }
}
