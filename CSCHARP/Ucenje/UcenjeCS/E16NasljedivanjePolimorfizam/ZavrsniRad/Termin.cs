using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljedivanjePolimorfizam.ZavrsniRad
{
    internal class Termin:Entitet
    {
        public Osoba? Osoba { get; set; }
        public Vozilo? Vozilo { get; set; }
        public DateTime? TerminDatum { get; set; }

        public Termin(int? sifra, Osoba? osoba, Vozilo? vozilo, DateTime? terminDatum)
        {
            base.Sifra = sifra;
            this.Osoba = osoba;
            this.Vozilo = vozilo;
            this.TerminDatum = terminDatum;
        }

        public override string ToString()
        {
            return $"Termin: {Osoba?.Ime} {Osoba?.Prezime}, {Vozilo?.Marka}, Datum: {TerminDatum}, Sifra: {Sifra}";
        }




    }
}
