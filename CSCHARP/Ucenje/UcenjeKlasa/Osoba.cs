using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeKlasa
{
    internal class Osoba
    {
        private string ime;
        private string Ime;

        public string Ime { get; private set; } // raspisati i validirati

        public Osoba(string Ime, string Prezime)
        {
            this.Ime = Ime;
            this.Ime = Prezime;
        }

        public Osoba(string ime)
        {
            Ime = ime;
        }
    }
}
