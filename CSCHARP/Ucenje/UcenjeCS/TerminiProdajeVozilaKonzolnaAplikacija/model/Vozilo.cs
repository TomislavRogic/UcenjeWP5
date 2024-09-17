using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.TerminiProdajeVozilaKonzolnaAplikacija.model
{
    internal class Vozilo:Entitet
    {
        public string? Marka { get; set; }
        public string? OpisVozila { get; set; }
        public decimal? Cijena { get; set; }
    }
}
