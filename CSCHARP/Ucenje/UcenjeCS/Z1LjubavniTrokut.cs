using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z1LjubavniTrokut
    {
        public static void Izvedi()
        {
            string ime1 = "Tomislav";
            string ime2 = "Kristina";

            // Kombinovanje oba imena u jedan string
            string kombiniranaImena = (ime1 + ime2).ToLower();

            // Inicijalizacija niza za brojanje pojavljivanja slova
            int[] brojPonavljanja = new int[26]; // 26 slova u engleskom alfabetu

            // Prolazak kroz svaki karakter u kombinovanom stringu
            foreach (char c in kombiniranaImena)
            {
                if (char.IsLetter(c))
                {
                    brojPonavljanja[c - 'a']++;
                }
            }

            // Ispisivanje slova u prvom redu
            foreach (char c in kombiniranaImena)
            {
                if (char.IsLetter(c))
                {
                    Console.Write($"{c} ");
                }
            }
            Console.WriteLine();

            // Ispisivanje broja ponavljanja ispod svakog slova
            foreach (char c in kombiniranaImena)
            {
                if (char.IsLetter(c))
                {
                    Console.Write($"{brojPonavljanja[c - 'a']} ");
                }
            }
            Console.WriteLine();
        }

        }
}
