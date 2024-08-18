using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z101Ljubavnikalkulatorvjezba
    {
        public static void Izvedi()
        {
            string input = "tomislavkristina";
            Dictionary<char, int> letterCounts = new Dictionary<char, int>();

            // Count all occurrences of each character
            CountLetters(input, letterCounts);

            // Print the input word
            Console.WriteLine(input);

            // Print the counts of each letter in the same order as they appear in the word
            foreach (char c in input)
            {
                Console.Write(letterCounts[c]);
            }
            Console.WriteLine(); // To move to the next line after printing counts
        }

        static void CountLetters(string input, Dictionary<char, int> letterCounts)
        {
            foreach (char c in input)
            {
                if (letterCounts.ContainsKey(c))
                {
                    letterCounts[c]++;
                }
                else
                {
                    letterCounts[c] = 1;
                }
            }

        }

    }
}
