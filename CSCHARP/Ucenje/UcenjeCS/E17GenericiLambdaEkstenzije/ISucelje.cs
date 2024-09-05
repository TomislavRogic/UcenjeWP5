using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E17GenericiLambdaEkstenzije
{
    internal interface ISucelje// pise interface jer je to sucelje
        // kada se radi sucelje, ne treba se pisati pristupni modificator jer je po defaultu internal
        // kada kreiram novi item s pocetnim slovom I, to znaci da je to sucelje

    {
        public void Posao();

    }
}
