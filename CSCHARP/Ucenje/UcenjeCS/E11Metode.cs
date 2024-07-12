using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UcenjeCS
{
    internal class E11Metode

        
    {
        /// <summary>
        /// U ovoj klasi ucimo rad s metodama.
        /// </summary>
        
        // metode su gradivni dio nekog bloka koji imaju svrhu da bi se visestruko povezivale, pisu se jednom
        // za pocetak metode cemo podijeliti na 4 vrste u odnosu na to kojeg su tipa
        // public je nacin pristupai static void
        // ako u tip dva ne stavis vrijednost javlja se greska jer nisi poslao parametar
        public static void Izvedi()
        {
            // Poziv metode
            Tip1();
            int broj = 5;
            Tip2(broj);
            // Tip2(5);
            Tip2(); // nisam poslao vrijednosti, pa je uzeta zadana vrijednost 2

            Tip2("Edunova");
            // Console je klasa
            //WriteLine je metoda

            Tip2("Osijek", 7);
           Tip3(); // metoda koja vraca vrijednost moze biti pozvana kao i vodi i odraditi ce se ali njezin rezultat ode u vjetar
            Console.WriteLine(Tip3());

            //  Console.WriteLine(Tip1()); ovo ne ide
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(Slucajnarijec());
            }
            Console.WriteLine(SumaBrojeva(3,23));
            Console.WriteLine(SumaBrojeva(1,100));
            Console.WriteLine(SumaBrojeva(100,1));
            int[]brojevi = { 2, 2, 2, 2, 2, 2, 3 };
            Console.WriteLine(SumaBrojeva(brojevi));

            int redova = UcitajCijelibroj("Unesi broj redova", 2, 100);
            int stupaca = UcitajCijelibroj("Unesi broj stupaca", 2, 100);

            // ovim nacinom ovdje ja sam siguran  da redova i stupaca imaju vrijednost 2 do 100



        }
        // ovdje nije naveden ni public ni static
        // kada nije naveden nacin pristupa je private
        // private je privatno, nije vidljivo iz drugih klasa
        // ako odemo u Program necemo vidjeti metodu E11 Tip1 jer je ona private
        // internal znaci da je unutar tog Namespacea
        // ako public static vodi promjenimo u private onda nam javlja gresku u Programu
        // ako stavimo da je metoda internal onda ju mozemo vidjeti u programu
        // ima jos jedan nacin koji necemo danas obradivati a zove se protected i vezan je uz OOP

        // static je mehanizam da se metoda pozove direktno na klasi
        // static je oznaka da se metoda zove na klasi
        // metode ne moraju sve biti staticne ali to necemo sad obradivat dok ne pocnemo s OOP-om
        // mi za sada koristimo metode samo na klasama
        // ako maknemo static ne mozemo pozvati nestaticnu metodu na klasi, ali mozemo u Programu napisati new E11Metode().Izvedi();
        // svrha staticnih metoda je da odrade neki posao

        // void- prijevod je nista,prazno, vodi oznacava da metoda ne vraca vrijednost
        // Tip 1 je naziv metode
        //() su parametri metode, prazno je pa znaci da metoda prima nula parametra, odnosno ne prima parametre

        static void Tip1()
        {
            Console.WriteLine("Sadrzaj metode koja ne prima parametar i ne vraca vrijednost");

        }

        // ne mozes pozvati nestaticnu metodu iz staticne metode
        // iz nestaticne metode mozes pozvati staticnu metodu na klasi
        // ova metoda dole sad prima jedan parametar

        // ovo nize cak i nije dobra praksa
         private static void Tip2(int x=2) // opcionalni parametri, doda se zadana vrijednost =2
         {
             Console.WriteLine("Metoda je primila parametar tipa int s vrijednoscu {0}",x);
             for (int i=0; i < x; i++)
             {
                 Console.WriteLine(i);
             }
         }
        

        // bolje je da napravimo ovakvu metodu
        private static void Tip2() // 
        {
            Tip2(2);
        }

        // dolazimo do toga da naziv metode jedinstven


        // metodu mozemo pozvati na ova dva nacina
        //int broj = 5;
        //Tip2(broj); prvi nacin
        // Tip2(5);
        // Tip2()- drugi nacin
        // i to se zove method overloading - nije vezan uz opcionalne parametre
        // metoda moze imati isti naziv sve dok prima razlicite parametre
        // metoda Tip2 sada prima i broj i string (Tip2 bez icega, Tip2 s stringom i Tip2 s int)

        // sada radimo private
        private static void Tip2(string ime)
        {
            Console.WriteLine("Preopterecena s stringom vrijednoscu: {0}", ime);
        }

        private static void Tip2(string ime, int b)
        {
            Console.WriteLine("Metoda primila {0} i {1} ", ime, b);
        }

        // treci tip- metoda vraca vrijednost
        // sada se od metode ocekuje da vrati vrijednost ali ne moze vratiti bilo sto npr boolean javlja gresku a char 'a' ne
        static int Tip3()
        {
            Console.WriteLine("U metodi Tip3 sam");
            return int.MaxValue;
        }

        static int Slucajnibroj()
        {
            return new Random().Next();
        }

        static string Slucajnarijec()
        {
            char[] niz = new char [8];
            var r = new Random();
            for(int i = 0; i<niz.Length; i++)
            {
                niz[i] = (char)r.Next(65,90);
            }
            return string.Join("",niz);

            
        }
        // cetvrti tip metode-nama najzanimljiviji Tip4
        // metoda je odredenog tipa (vraca vrijednost) i prima parametre
        // radimo sada primjer metoda suma brojeva

        // metoda se moze dokumentirati na nacin ///
        // dokumentiranje metoda
        /// <summary>
        /// Metoda vraca zbroj svih brojeva izmedu dva primljena broja bez obzira koji je manji a koji veci
        /// </summary>
        /// <param name="b1"></param>
        /// <param name="b2"></param>
        /// <returns>Vraca zbroj brojeva izmedu dva primljena broja</returns>
        /// 
        //suma: Ova promenljiva će sadržati konačni rezultat, tj. sumu svih brojeva.
        /*min i max: Ove promenljive se koriste da odrede koji je od dva data broja manji(min) 
         * i veći(max). Ovo se radi pomoću ternarnog operatora ?:. Ako je b1 manje od b2, min dobija vrednost b1, 
         * inače dobija vrednost b2.Slično, max dobija vrednost većeg od ta dva broja.*/

        // novi primjer je metoda primi neki niz i njegov zadatak je  zbrojiti sve brojeve u tom nizu
        private static int SumaBrojeva(int b1, int b2)
        {
            int suma = 0;
            int min = b1 < b2 ? b1: b2;
            int max = b1 > b2 ? b1 : b2;
            for(int i=min; i<=max; i++)
            {
                suma += i;
            }
            return suma;
        }
        private static int SumaBrojeva(int[] niz)
        {
            var suma = 0;
            foreach(var b in niz)
            {
                suma += b;
            }
            return suma;
        }

        public static int UcitajCijelibroj(string poruka="Unesi broj",int min=0, int max = 1000)
        {
            int broj=0;
            while (true)
            {
                Console.WriteLine(poruka + ": ");
                try
                {
                    broj = int.Parse(Console.ReadLine());
                    if(broj<min || broj > max)
                    {
                        Console.WriteLine("Broj mora biti u rasponu {0} i {1}", min,max);
                        continue;
                    }
                    return broj;
                }
                catch
                {
                    Console.WriteLine("Nisi unio broj");
                }
            }
            



            return broj;
        }

    }
}
