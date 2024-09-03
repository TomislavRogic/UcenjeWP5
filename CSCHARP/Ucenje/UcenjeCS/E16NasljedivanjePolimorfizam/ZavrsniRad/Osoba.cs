using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljedivanjePolimorfizam.ZavrsniRad
{
    internal class Osoba:Entitet
    {
        public string? Ime { get; set; }
        public string? Prezime { get; set; }
        public string? Email { get; set; }

       public Osoba (int? sifra, string? ime, string? prezime, string? email)
        {
            base.Sifra = sifra;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Email = email;
        }

        public override string ToString()
        {
            return $"Osoba: {Ime} {Prezime}, Email: {Email}, Sifra: {Sifra}";
        }
    }
}
