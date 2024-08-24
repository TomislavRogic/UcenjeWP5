using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljedivanjePolimorfizam
{
    // apstraktna klasa je ona klasa koja se ne može instancirati
    // ona se kreira da bi ju je druge klase nasljedile i dopunile
    // apstraktnost je svojstvo klase da se ne može instancirati, a to znaci da se ne može kreirati objekt te klase

    internal abstract class Entitet : Object // ovo se podrazumijeva i ne mora se pisati (Object)- ovdje imamo konstruktor ali je prazan
    {

        public int? Sifra { get; set; }
        public override string ToString()
        {
            return Sifra.ToString();
        }

    }
}
