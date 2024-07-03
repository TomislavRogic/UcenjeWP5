using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E06ForPetlja
    {
        public static void Izvedi()
        {
            // ispisi 10 puta jedno ispod drugog Osijek
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");

            // mehanizam koji omogucuje ponavljanje koda
            // postoji 5 vrsti interacija
            // for petlja ima 3 komponente, od kuda, do kuda, kojim korakom
            // int i = 0 kaze idi od nule
            // nakon toga dolazi boolean vrijednost
            // i=i +1

            // zelimo razdvojiti gornji red od donjeg pa pisemož
            Console.WriteLine("******************");
            for (int i = 0; i < 10; i = i + 1) // i = i + 1 mozemo jos napisati kao i++ ili ++i ili i+=1
            {

                Console.WriteLine("Osijek");
            }

            Console.WriteLine("*******************************");
            // najvaznije unutar petlje, varijabla mjenja vrijednost
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("*********************************");
            // sada ne krecemo od nule nego od 1 s Console.WriteLine(i+1);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1);

            }
            Console.WriteLine("*********************************");

            //prije same petlje nam treba varijabla int suma
            int suma = 0;
            // koristenje vrijednosti u petlji
            // zbroj prvih 100 brojeva
            for (int i = 1; i <= 100; i++)
            {
                suma += i;
            }
            Console.WriteLine(suma);

            Console.WriteLine("*********************************");

            // parni broj- ispisati sve parne brojeve od 1 do 50
            //1. los nacin
            // postavili smo i na 2, ispisujemo do 50, a uvecanje izmedu brojeve je za 2
            for (int i = 2; i <= 50; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*********************************");
            // dobar nacin, nacinom modulo
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("*********************************");
            // prikaz brojeva od veceg prema manjem
            int brojOd = 12;
            int brojDo = 2;

            for(int i=brojOd; i>brojDo; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*********************************");
            // niz
            int[] niz = { 2, 3, 2, 3, 4, 5, 4, 3 };
            // ispisati sve aprne vrijednosti niza
            for(int i=0; i< niz.Length; i++)
            {
                if (niz[i] %2 == 2)
                {
                    Console.WriteLine(niz[i]);
                }
            }
            Console.WriteLine("*********************************");

            // za neparne mozemo pisati ili if (niz[i] %2 != 0) ili if (niz[i] %2 == 1)

            // primjer kako ce se for petlja ugnijezditi unutar druge for petlje
            // sada imamo dvodimenzionalni niz
            int[,] tablica =
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
             };
            for (int i=0; i< tablica.GetLength(0); i++)
            {
                for(int j=0; j< tablica.GetLength(1); j++)
                {
                    Console.Write(tablica[i,j] +  " ");
                }
                Console.WriteLine(); // ovo koristi da nakon ispisa prvog reda ide u novi red inace bi sve ispisao u jednoj liniji
            }
            Console.WriteLine("*********************************");
            // kako posloziti da nam se brojevi u tablici poravnaju s desne strane, kopirao sam primjer odozgora ali u Console.Write dodajemo String.Format
            int[,] tablica1 =
           {
                {10,200,35},
                {40,50,6},
                {7,8,9}
             };
            for (int i = 0; i < tablica1.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    Console.Write(String.Format("{0,3}", tablica1[i, j]) + " ");
                }
                Console.WriteLine();
                             
            }
            Console.WriteLine("*********************************");

            // petlja s tablicom mnozenja
            // opet koristimo String.Format("{0,3}" da poravnamo s desne strane
            for (int i=0; i<10; i++)
            {
                for (int j=0; j<10; j++)
                {
                    Console.Write(String.Format("{0,3}", (i+1)*(j+1)) + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("*********************************");


            // petlja se moze preskociti, nastaviti izvodenje i petlja se moze nasilno prekinuti
            // j<10; ovo je prirodno prekidanje petlje
            // ovo je bolja varijanta koda a nize cemo napisati i losiji kod
            int ukupno = 0;
            for (int i=0; i<10; i++)
            {
                if (i==1 || i == 3)
                {
                    continue;
                }
                if(++ukupno > 5)
                {
                    break;
                }
                Console.WriteLine(i);
                
            }


            Console.WriteLine("*********************************");
            // losija varijanta koda
            ukupno = 0;
            for (int i = 0; i < 10; i++)
            {
                if (i != 1 && i != 3)
                {
                    if(ukupno++ < 5)
                    {
                        Console.WriteLine(i);
                    }               
                }
            }

            Console.WriteLine("*********************************");
            // ugnjecena petlja
            // kad se kaze u unutarnjoj petlji break to znaci
            for (int i=0; i<10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    // kako iz unutarnje prekinuti vanjsku petlju - pomocu labele
                    goto labela;
                    //break;
                }
                // ovdje smo zavrsili u unutarnjoj petlji
            }
            labela:// https je njemu nastavak
        //https://dnevnik.hr/#google_vignette
            Console.WriteLine("Hello");

            // beskonacna petlja
            // beskonacne petlje nisu lose, bez njih ne bi radilo racunalo
            // beskonacne petlje su tzv slusatelji
            // losa beskonacna for petlja-- jer ako maksimalni broj 2,147,483,647 uvecas za 1 dobijes -2,147,483,648 jer je to kruzna petlja i uvijek se vrti u krug
            for (int i=0; i>-1; i++)
            {
                break;
            }

            Console.WriteLine("*********************************");

            // ispravna beskonacna petlja
            int broj = 0;
            for (; ; )
            {
                Console.WriteLine("Unesi broj izmedu 10 i 20 : ");
                broj = int.Parse(Console.ReadLine());
                if (broj >= 10 && broj <= 20)
                {
                    break;
                }
                Console.WriteLine("Neispravan unos");
            }
            Console.WriteLine("Unijeli ste " + broj);
            // ako unesemo broj izmedu 10 i 20 beskonacna petlja se zaustavlja
            // ako unesem broj koji nije izmedu 10 i 20 program nas jos uvijek trazi da upisemo broj izmedu 10 i 20

            Console.WriteLine("*********************************");

            // nizovi + petlje
            // cinjenica da string tip podatka je zapravo nis znakova

            string ime1 = "Ana";
            char[] ime2 = { 'a', 'n', 'a' };

            for(int i=0; i<ime2.Length; i++)
            {
                Console.Write(ime2[i]);
                
            }
            // dobijemo rijec ana

            Console.WriteLine("*********************************");
            for(int i=0; i < ime1.Length; i++)
            {
                Console.Write(ime1[i]);
            }




        }

    }
}
