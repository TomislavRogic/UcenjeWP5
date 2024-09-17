using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.TerminiProdajeVozilaKonzolnaAplikacija.model
{
    internal class Osoba:Entitet
    {
        public string? Ime { get; set; }
        public string? Prezime { get; set; }
        public string? Email { get; set; }

    }
}
