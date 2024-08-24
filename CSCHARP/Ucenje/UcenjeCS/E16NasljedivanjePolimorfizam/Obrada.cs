using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljedivanjePolimorfizam
{
    internal abstract class Obrada
    {
        // abstract metoda koja se mora implementirati u svim klasama koje nasljedjuju ovu klasu
        // nema implementaciju
        // nema {}
        // nema ;
        //cak i da stavimo ; nece raditi
        // ta metoda koristi se u polimorfizmu
        // polimorfizam je mogucnost da se metoda sa istim imenom poziva iz razlicitih klasa
        // abstract klasa moze imati i obicne metode
        // abstract klasa ne moze imati instance    

        public abstract void Procesuiraj();


    }
}
