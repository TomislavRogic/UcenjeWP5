using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljedivanjePolimorfizam.ZavrsniRad
{
    internal class Vozilo:Entitet
    {
        public string? Marka { get; set; }
        public string? OpisVozila { get; set; }
        public decimal? Cijena { get; set; }

        public Vozilo(int? sifra, string? marka, string? opisVozila, decimal? cijena)
        {
            base.Sifra = sifra;
            this.Marka = marka;
            this.OpisVozila = opisVozila;
            this.Cijena = cijena;
        }

        public override string ToString()
        {
            return $"Vozilo: {Marka}, Opis: {OpisVozila}, Cijena: {Cijena}, Sifra: {Sifra}";
        }





    }
}
