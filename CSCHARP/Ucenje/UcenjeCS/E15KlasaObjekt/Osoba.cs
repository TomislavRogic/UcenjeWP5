using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E15KlasaObjekt
{

    // KLASA JE OPISNIK OBJEKTA-- ovo nauciti napamet
    internal class Osoba
    {
        // KLASA SADRZI SVOJSTVA (PROPERTY)
        public int? Sifra { get; set; } // OOP princip ucahurivanja
        public string? Ime { get; set; }  // ? oznacava kako Ime moze biti null
        public string? Prezime { get; set; }

        public Mjesto? Mjesto { get; set; }


        // prvi OOP princip je klasa objekt- najbitniji OOP princip
        // onda dode ucahurivanje- najbitniji OOP princip
        // onda nasljedivanje- najbitniji OOP princip
        // onda polimorfizam - najbitniji OOP princip
        // onda sucelja i tako dalje


        // sada zelimo opisati da neka osoba zivi u mjestu za koji vodim postanski broj i naziv

        // KLASA SADRZI METODE  
        public string ImePrezime()
        {
            return Ime + " " + Prezime;
        }
        



    }
}
