using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E05Nizovi
    {

        public static void Izvedi()
        {
            // motivacija: treba ti 12 varijabli za 12 temperatura različitih mjeseci
            // ono što znamo
            int temp1, temp2, temp3, t3, t4; // ovo je lose rijesenje pisanja

            // nizovi na engleskom eng. Arrays, na hrvatskom HR polja

            // jednodimenzionalni nizovi
            int[] temperature = new int[12]; // najveci broj nizova je sto je na pocetku moram znati koliko ima elemenata

            // nizovi pocinju s indeksom 0
            // 1. element niza je na indexu 0
            temperature[0] = -2; // sijecanj
            temperature[1] = 0;
            //..
            temperature[11] = -3; // prosinac

            // duzina niza
            Console.WriteLine(temperature.Length); // ukupan broj elemenata 

            // zadnji se u pravilu ovako postavlja
            temperature[temperature.Length - 1] = 0;

            Console.WriteLine(temperature[1]); //0

            // temperature[12] = 1; - greska prilikom izvodenja

            Console.WriteLine(temperature);

            // ispisati sve elemente niza
            Console.WriteLine(string.Join(",", temperature));

            // kraci naci
            int[] niz = { 2, 3, 4, 5, 56, 6, 3, 3 };

            // ispisati 56
            Console.WriteLine(niz[4]);
            string[] gradovi = { "Osijek", "Donji Miholjac", "Valpovo", "Belisce" };

            // ispisati zadnji grad
            Console.WriteLine(gradovi[gradovi.Length-1]);

            // dvodimenzionalni niz je tablica
            int[,] tablica =
            {
                { 1,2,3},
                {4,5,6 },
                {7,8,9 }
            };

            // ispisi 6
            Console.WriteLine(tablica[1,2]);

            // ispisi 9
            Console.WriteLine(tablica[2,2]);

            // trodimenzionalni niz
            int[,,] kocka = { };

            // tesaarect- 4 dimezije

            int[,,] tesaarect = { };

            // multiverse
            int[,,,,,,] multiverse = { };

            // nizovi mogu imati i razlicite tipove podataka
            object[] objekti = { "ovo", 3, 2.6, true };









        }







    }
}