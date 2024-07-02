using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01UlazIzlaz
    {
        public static void Izvedi()

        {
            Console.Write("Unesi moje prezime: ");
            string prezime = Console.ReadLine();

            //Console.WriteLine: Ispisuje tekst i prelazi u novi red.
            // Console.Write: Ispisuje tekst, ali ostaje u istom redu.
            Console.WriteLine("Hello");

            Console.Write("Upiši svoje ime: ");
            // Console.ReadLine() Ova metoda čita cijeli redak teksta koji korisnik unese u konzolu i pritisne Enter.
            // Vraća unos korisnika kao string.
            // string ime Deklarira varijablu nazvanu ime koja može pohraniti tekstualne podatke (string).

            // = operator dodjele Operater dodjele (=) koristi se za dodjeljivanje vrijednosti desne strane lijevoj strani.
            //U ovom slučaju, vrijednost koju vraća Console.ReadLine() (unos korisnika) dodjeljuje se varijabli ime.


            // string ime = Console.ReadLine(); znači da program:
            // 1. Prikazuje kursor u konzoli i čeka da korisnik unese tekst
            // 2. Kada korisnik pritisne Enter, uneseni tekst se pohranjuje u varijablu ime.

            string ime = Console.ReadLine();


            //Console.WriteLine:Metoda Console.WriteLine koristi se za ispisivanje teksta na konzolu., Nakon ispisa, kursor prelazi u novi red.
            // pva naredba znaci Spajanje tekstova: Tekst "Unijeli ste " se spaja s vrijednošću varijable ime te
            // Ispisivanje na konzolu: Kombinirani tekst se ispisuje na konzolu, nakon čega kursor prelazi u novi red.
            Console.WriteLine("Unijeli ste " + ime);

            // formatirani nacin ispisa
            //Linija Console.WriteLine("Unijeli ste {0}", ime); koristi formatirane stringove za ispis na konzolu. Evo što to znači:
            //Console.WriteLine:
            // Metoda Console.WriteLine koristi se za ispisivanje teksta na konzolu.
            // Nakon ispisa, kursor prelazi u novi red.
            //"Unijeli ste {0}" je formatirani string.
            //{0} je zamjensko mjesto (placeholder) koje će biti zamijenjeno vrijednošću varijable ime.
            //Formatiranje:
            //Console.WriteLine uzima formatirani string i varijablu ime, te zamjenjuje { 0}
           //vrijednošću varijable ime.

                        Console.WriteLine("Unijeli ste {0}", ime);
            Console.WriteLine("Unijeli ste {0}", prezime);

            // ovo gore je bilo za unos stringa znaci sve pod navodnicima



            // zadatak: Unijeti Adresu i grad te ispisati jedno ispod drugog i grad
            Console.WriteLine("Molim unesite adresu: ");
            string adresa= Console.ReadLine();
            Console.WriteLine("Molim unesite grad: ");
            string grad = Console.ReadLine();

            Console.Write(adresa + " ");
            Console.Write(grad);


            }

        



    }
}
