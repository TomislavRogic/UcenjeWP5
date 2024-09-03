using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljedivanjePolimorfizam
{
    internal class Smjer: Entitet // Klasa smjer nasljeđuje javna i zaštićena svojstva i metode klase Entitet
    {
        public string? Naziv { get; set; }


        // override metode je moguće pozvati iz klase koja nasljeđuje
        // override metoda se koristi kada želimo promijeniti ponašanje metode koja se nasljeđuje, sto znaci da se metoda sa istim potpisom iz bazne klase neće izvršiti
        // kao primjer, u klasi Entitet metoda ToString() vraća string sa ID-om, a u klasi Smjer vraća string sa nazivom
        // kada override metoda nije definirana, koristi se metoda iz bazne klase
        // kada overridamo metodu, možemo pozvati metodu iz bazne klase koristeći ključnu riječ base
        // na primjer da smo u metodi override ToString() u klasi Smjer, mogli smo pozvati metodu iz bazne klase sa base.ToString()
        // na primjer time dobijemo string sa ID-om
        // primjer overridea metode ToString() je u klasi Smjer

        // override znaci da zelimo promijeniti ponašanje metode koja se nasljeđuje

        // zasto uopce konvertiramo u string? zato sto je metoda ToString() metoda koja se poziva kada se objekt koristi u string kontekstu
        // postoje i druge metode koje se mogu overrideati, kao npr. Equals() i GetHashCode()? koje se koriste za usporedbu objekata
        // Equals() se koristi za usporedbu objekata, a GetHashCode() za dobivanje hash koda objekta
        // Equals() i GetHashCode() se koriste za usporedbu objekata, a ToString() za pretvaranje objekta u string
        // pretvara se u string jer se koristi u string kontekstu, npr. kada se objekt koristi u interpolaciji stringova
        public override string ToString()
        {
            return Naziv; // vraća naziv smjera, ali ima i sifru jer je nasljedila metodu iz klase Entitet
        }
    }
}
