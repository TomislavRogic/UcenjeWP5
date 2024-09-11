using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Vjezbanjenizova
    {
        public static void Izvedi()
        {
            // Zadatak 1. Ispisati brojeve iz niza

            /* int[] PrviNiz = { 1, 2, 3, 4, 5 };

             for (int i = 0; i < PrviNiz.Length; i++)
             {
                 Console.WriteLine(i + " Broj u nizu je: " + PrviNiz[i]);

             }
            */

            // Zadatak 2. Unijeti 10 brojeva u niz i ispisati svaki s foreach petljom

            /*int[] DrugiNiz = new int[10];
            Console.WriteLine("Molim unesite 10 brojeva: ");


            
            for (int i=0; i<DrugiNiz.Length; i++)
            {
                DrugiNiz[i]= int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Brojevi koje ste unijeli su: ");
            foreach (int broj in DrugiNiz)
            {
                Console.WriteLine(broj);
            }

            */
            // Zadatak 3. u Nizu od 5 brojeva zbrojiti prvi i zadnji

            int[] TreciNiz = { 1, 2, 3, 4, 5, 6 };
            int ZbrojVanjskih = TreciNiz[0] + TreciNiz[5];

            Console.WriteLine(ZbrojVanjskih);

            // Zadatak 4. za isti niz zbroji vanjske pa prema unutra

            int[] CetvrtiNiz = { 1, 2, 3, 4, 5, 6};
            int Pocetak = 0;
            int Kraj = CetvrtiNiz.Length - 1;
            

            while (Pocetak < Kraj)
            {
                int suma = CetvrtiNiz[Pocetak] + CetvrtiNiz[Kraj];
                Console.Write(suma + " ");
                Pocetak++;
                Kraj--;
            }

            // zadatak 5. kako pobrojati ponavljanje slova u stringu
            // prvo napraviti string
            // zatim napraviti niz charova, to napravimo tako da string pretvorimo u niz charova, a to se radi sa ToCharArray() na nacin da se stringu pridruzi niz charova
            // primjer koda je u nastavku
            string recenica = "Ovo je recenica";
            //niz chaova napravimo tako s naredbom
            char[] nizSlova = recenica.ToCharArray();
            // jel mozes napisati cijeli kod? bez dictionarya
            // ne znam, mozda
            // mozda bi mogao napraviti niz charova, a zatim napraviti niz intova, pa onda provjeriti koliko se puta pojavljuje svako slovo
            // npr. napraviti niz charova, zatim napraviti niz intova, zatim provjeriti koliko se puta pojavljuje svako slovo
           // napisi mi kod, ok?
           // ne znam, mozda
            // mozda bi mogao napraviti niz charova, a zatim napraviti niz intova, pa onda provjeriti koliko se puta pojavljuje svako slovo
            // npr. napraviti niz charova, zatim napraviti niz intova, zatim provjeriti koliko se puta pojavljuje svako slovo
            // niz charova napravimo tako s naredbom
            // char[] nizSlova = recenica.ToCharArray();
            // zatim napravimo niz intova
            // int[] nizBrojeva = new int[nizSlova.Length];
            // zatim provjerimo koliko se puta pojavljuje svako slovo
            // for (int i = 0; i < nizSlova.Length; i++)
            // {
            //     for (int j = 0; j < nizSlova.Length; j++)
            //     {
            //         if (nizSlova[i] == nizSlova[j])
            //         {
            //             nizBrojeva[i]++;
            //         }
            //     }
            // }
            // zatim ispisemo koliko se puta pojavljuje svako slovo
            // for (int i = 0; i < nizSlova.Length; i++)
            // {
            //     Console.WriteLine(nizSlova[i] + " se pojavljuje " + nizBrojeva[i] + " puta");
            // }
            // zadatak 6. kako pobrojati ponavljanje slova u stringu
            // prvo napraviti string
            // zatim napraviti niz charova, to napravimo tako da string pretvorimo u niz charova, a to se radi sa ToCharArray() na nacin da se stringu pridruzi niz charova
            // primjer koda je u nastavku
            // string recenica = "Ovo je recenica";
            // niz chaova napravimo tako s naredb
            // mozes li ovo napraviti samo s petljom i nizom?
            // ne znam, mozda
            // mozda bi mogao napraviti niz charova, a zatim napraviti niz intova, pa onda provjeriti koliko se puta pojavljuje svako slovo
            // napisi mi kod, ok?
            // ne znam, mozda
            // mozda bi mogao napraviti niz charova, a zatim napraviti niz intova, pa onda provjeriti koliko se puta pojavljuje svako slovo

            // niz charova napravimo tako s naredbom, to radimo zato jer je string nepromjenjiv, a niz charova je promjenjiv, time dobijemo niz charova koji je promjenjiv
            // char[] nizSlova = recenica.ToCharArray();
            // zatim napravimo niz intova
            // int[] nizBrojeva = new int[nizSlova.Length];
            // zatim provjerimo koliko se puta pojavljuje svako slovo


            




        }
    }
}
