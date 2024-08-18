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
            string vaseime= Console.ReadLine();

            // unos drugog imena
            Console.WriteLine("Unesite partnerovo ime: ");
            string partnerovoime= Console.ReadLine();

            // spajanje ta dva imena u jedno
            string imepar= vaseime + "  " + partnerovoime;
            

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
            foreach (char slovo in imepar.ToUpper())
            {
                if (char.IsLetter(slovo)) // Ignore non-letter characters
                {
                    Console.Write(letterCounts[char.ToLower(slovo)]);
                }
                else
                {
                    Console.Write(' '); // Maintain spaces in the output
                }
            }
            Console.WriteLine(); // Move to the next line




        }

    }
}
