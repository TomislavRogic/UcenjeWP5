using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E18KonzolnaAplikacija.model
{
    internal class Polaznik : Entitet, IComparable<Polaznik>
    {
        public string? Ime { get; set; }
        public string? Prezime { get; set; }
        public string? OIB { get; set; }
        public string? Email { get; set; }

        public int CompareTo(Polaznik? other)
        {
            return Prezime.CompareTo(other.Prezime);
        }
    }
}
