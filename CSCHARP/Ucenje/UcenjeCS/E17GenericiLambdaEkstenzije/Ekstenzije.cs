using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E17GenericiLambdaEkstenzije
{
    internal static class Ekstenzije // klasa mora biti static
    {
        public static void OdradiPosao (this Entitet e) // this oznacava da je ovo ekstenzija, a Entitet je tip na kojem se ekstenzija primjenjuje, klasa mora biti static
       
        {
            Console.WriteLine(e.Sifra);
        }
       // sada imamo metodu koja se moze pozvati nad svim objektima tipa Entitet
       // ova metoda moze primiti bilo koji objekt tipa Entitet, a ne samo objekte tipa Entitet, bilo sto sto je nasljedeno od Entitet
       // ovdje je metoda naziva OdradiPosao, a moze biti bilo koji naziv
       // razlikuje se od Polimorfizma jer se Polimorfizam odnosi na metode, a ekstenzije na klase
       // ovdje se klasa naziva Ekstenzije, a moze biti bilo koji naziv

        public static void PrikazRadaSSucesljem(this ISucelje sucelje)
        {
            sucelje.Posao();
        }


    }
}
