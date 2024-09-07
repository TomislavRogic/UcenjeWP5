using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E18KonzolnaAplikacija
{
    public class Izbornik
    {

        // ako zelimo raditi s svim klasama u svim metodama, onda ju deklariramo na vrhu klase kao property

        public ObradaSmjer ObradaSmjer { get; set; }
        public ObradaGrupa ObradaGrupa { get; set; }

        public Izbornik()
        {
            Pomocno.DEV = true;// postavljamo DEV na true, ovo nam koristi
            ObradaSmjer = new ObradaSmjer();
            ObradaGrupa= new ObradaGrupa(this);
            PrikaziIzbornik();
        }

        private void PrikaziIzbornik()
        {
          

             Console.WriteLine("Glavni izbornik:");
            Console.WriteLine("1. Smjerovi");
            Console.WriteLine("2. Grupe");
            Console.WriteLine("3. Polaznici");
            Console.WriteLine("4. Izlaz iz programa");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {

            switch(E11Metode.UcitajCijelibroj("Odaberi stavku izbornika", 1, 4))
            {
                case 1:
                    ObradaSmjer.PrikaziIzbornik();
                    Console.Clear(); // ocisti konzolu, stavljamo ju tu jer zelimo ocistiti konzolu nakon sto se vratimo iz ObradaSmjer
                    PrikaziIzbornik();
                    break;
                case 2:
                    ObradaGrupa.PrikaziIzbornik();
                    Console.Clear(); // ocisti konzolu, stavljamo ju tu jer zelimo ocistiti konzolu nakon sto se vratimo iz ObradaSmjer
                    PrikaziIzbornik();
                    break;
                case 4:
                    Console.WriteLine("Dovidenja");
                    break;

            }
        }
    }
}
