using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.E18KonzolnaAplikacija.model;

namespace UcenjeCS.E18KonzolnaAplikacija
{
    public class ObradaGrupa
    {
        public List<Grupa> Grupe { get; set; }
        public Izbornik Izbornik { get; set; }

        public ObradaGrupa(Izbornik Izbornik)
        {
            this.Izbornik= Izbornik;
           Grupe = new List<Grupa>();
            if (Pomocno.DEV)
            {
                UcitajTestnePodatke();

            }

        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Rad s grupama");
            Console.WriteLine("1. Prikazi sve grupe");
            Console.WriteLine("2. Dodaj novu grupu");
            Console.WriteLine("3. Promjeni podatke grupe");
            Console.WriteLine("4. Obrisi grupu");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch(E11Metode.UcitajCijelibroj("Odaberi stavku izbornika", 1, 5) )
            {

                case 1:
                    PrikaziSveGrupe();
                    PrikaziIzbornik();
                    break;
            
            
            }
       
        
        
        
        
        
        
        
        }

        private void PrikaziSveGrupe()
        {
            
        }

        private void UcitajTestnePodatke()
        {
           Grupe.Add(new () { Sifra = 1, Naziv = "WP5", Smjer =Izbornik.ObradaSmjer.Smjerovi[0] });
            Grupe.Add(new() { Sifra = 2, Naziv = "WP4", Smjer = Izbornik.ObradaSmjer.Smjerovi[0] });
        }
    }
}
