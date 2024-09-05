using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E17GenericiLambdaEkstenzije
{
    internal class Smjer:Entitet, ISucelje, IComparable<Smjer>
    {
       
        public string? Naziv { get; set; }

        public int CompareTo(Smjer? other)
        {
            return Sifra==other?.Sifra?0 : Sifra>other?.Sifra?1:-1; // ako je sifra jednaka sifri drugog, vrati 0, ako je sifra veca od sifre drugog, vrati 1, inace vrati -1
        }

        public void Posao()
        {
            Console.WriteLine("Odradujem posao na Smjeru");
        }
    }
}
