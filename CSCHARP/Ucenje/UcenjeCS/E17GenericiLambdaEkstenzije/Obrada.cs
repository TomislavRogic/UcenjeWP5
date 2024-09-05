using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E17GenericiLambdaEkstenzije
{
    internal class Obrada<T>:ISucelje where T:Entitet
    {
        // uobicajeno je krenuti s slovom T
        public T? ObjektObrade { get; set; }

        public List<T>? ListaZaObradu { get; set; }

        public void Obradi()
        {
            Console.WriteLine(ObjektObrade?.Sifra);
        }

        public void Posao()
        {
            Console.WriteLine("Odradujem posao u Obradi");
        }

        public void IspisStavaka(Action<T> akcija)
        {
            // ovo je 5 nacin iteriranja kroz listu
            // ostali nacini iteracije su foreach, for, while, do while
            ListaZaObradu?.ForEach(e=> akcija(e)); // ovo je ForEach metoda koja prima akciju

            // ListaZaObradu?.ForEach(e=> akcija(e)); ovo radi isto kao i ovo ispod,a to je 
        }


       // kako da napisem primjer s func da daje string a prima T?
       // public void IspisStavaka(Func<T,string> funkcija)
       // {
       //     ListaZaObradu?.ForEach(e=> Console.WriteLine(funkcija(e)));
       // }
       // da li je ovo cijeli kod?
       // da, to je cijeli kod


       // kako da to ispisem s Console.WriteLine? gdje moram ici
       // u Program.cs
       // kako da to ispisem u Program.cs?
       // Obrada<Smjer> obrada=new Obrada<Smjer>();
       // obrada.ListaZaObradu=new List<Smjer>();
       // obrada.ListaZaObradu.Add(new Smjer{Sifra=1,Naziv="Prvi"});
       // obrada.ListaZaObradu.Add(new Smjer{Sifra=2,Naziv="Drugi"});
       // obrada.IspisStavaka(e=>e.Naziv);
       // ovo je primjer kako se koristi
       // ovo je primjer kako se koristi

       
        

    }
}
