using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z1LjubavniTrokut
    {
        public static void Izvedi()
        {
            // unos prvog imena
            Console.WriteLine("Unesite svoje ime: ");
            string vaseime = Console.ReadLine();

            // unos drugog imena
            Console.WriteLine("Unesite partnerovo ime: ");
            string partnerovoime = Console.ReadLine();

            // spajanje ta dva imena u jedno
            string imepar = vaseime + "  " + partnerovoime;


            // brojanje pojavljivanje slova-- dva imena ubacujemo u dictionary i onda radimo petlju koja provjerava da li slovo vec postoji, ako postoji inetarcija se povecava za 1 a ako ne vrijednot je 1
            Dictionary<char, int> letterCounts = new Dictionary<char, int>();
            foreach (char slovo in imepar.ToLower())
            {
                if (char.IsLetter(slovo))
                {
                    if (letterCounts.ContainsKey(slovo))
                    {
                        letterCounts[slovo]++;
                    }
                    else
                    {
                        letterCounts[slovo] = 1;
                    }
                }
            }

            // Print each character as it is
            foreach (char slovo in imepar.ToLower())
            {
                Console.Write(slovo);
            }
            Console.WriteLine(); // Move to the next line

            // Print the count of each character in the same order
            // Print the count of each character in the same order
            string brojevi = "";
            foreach (char slovo in imepar.ToUpper())
            {
                if (char.IsLetter(slovo))
                {
                    int count = letterCounts[char.ToLower(slovo)];
                    Console.Write(count);
                    brojevi += count;
                }
                else
                {
                    Console.Write(' '); // Zadržavamo prazne prostore u ispisu
                    brojevi += ' ';
                }
            }
            Console.WriteLine(); // Prelazak u novi red

            // Zbrajanje brojeva dok ne dođemo do dva broja
            while (brojevi.Length > 2)
            {
                brojevi = ZbrajanjeVanjskiPremaUnutarnji(brojevi);
                Console.WriteLine(brojevi);
            }
        }

        private static string ZbrajanjeVanjskiPremaUnutarnji(string brojevi)
        {
            List<int> noviBrojevi = new List<int>();
            int i = 0, j = brojevi.Length - 1;

            while (i < j)
            {
                if (char.IsDigit(brojevi[i]) && char.IsDigit(brojevi[j]))
                {
                    int suma = (brojevi[i] - '0') + (brojevi[j] - '0');
                    noviBrojevi.Add(suma);
                }
                i++;
                j--;
            }

            // Ako je neparan broj cifara, dodajemo srednji broj
            if (i == j && char.IsDigit(brojevi[i]))
            {
                noviBrojevi.Add(brojevi[i] - '0');
            }

            return string.Join("", noviBrojevi);
        }
    }
    /* public static void Izvedi()
{
// unos prvog imena
Console.WriteLine("Unesite svoje ime: ");
string vaseime = Console.ReadLine() ?? string.Empty; // Provjera za null vrijednosti

// unos drugog imena
Console.WriteLine("Unesite partnerovo ime: ");
string partnerovoime = Console.ReadLine() ?? string.Empty; // Provjera za null vrijednosti

// spajanje ta dva imena u jedno
string imepar = vaseime + "  " + partnerovoime; // Dodavanje dva prazna prostora između imena

// brojanje pojavljivanje slova-- dva imena ubacujemo u dictionary i onda radimo petlju koja provjerava da li slovo vec postoji, ako postoji inetarcija se povecava za 1 a ako ne vrijednot je 1
Dictionary<char, int> letterCounts = new Dictionary<char, int>();
foreach (char slovo in imepar.ToLower()) // Iteriramo kroz svaki znak u malim slovima
{
if (char.IsLetter(slovo)) // Provjeravamo je li znak slovo
{
    if (letterCounts.ContainsKey(slovo)) // Ako slovo već postoji u rječniku
    {
        letterCounts[slovo]++; // Povećavamo brojanje za 1
    }
    else
    {
        letterCounts[slovo] = 1; // Ako slovo ne postoji, dodajemo ga s vrijednošću 1
    }
}
}

// Print each character as it is
foreach (char slovo in imepar.ToUpper()) // Iteriramo kroz svaki znak u velikim slovima
{
Console.Write(slovo); // Ispisujemo svaki znak
}
Console.WriteLine(); // Prelazak u novi red

// Print the count of each character in the same order
foreach (char slovo in imepar.ToUpper()) // Iteriramo kroz svaki znak u velikim slovima
{
if (char.IsLetter(slovo)) // Ignoriramo znakove koji nisu slova
{
    Console.Write(letterCounts[char.ToLower(slovo)]); // Ispisujemo broj pojavljivanja slova
}
else
{
    Console.Write(' '); // Zadržavamo prazne prostore u ispisu
}
}
Console.WriteLine(); // Prelazak u novi red
}*/




}

    


