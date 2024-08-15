using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E1Zadatakinstrukcije
    {
        public static void Izvedi()
        {
            string ime = "Marko";
            char prvoslovo = ime[0];
            string prezime = "Markic";

            string imeprezime = ime + " " + prezime; //MarkoMarkic
            imeprezime = imeprezime.ToLower();
            //string tekst= Console.ReadLine();
            //Console.WriteLine(tekst);

            int[] ponavljanjeslova = new int[26]; // [0:A, 1: B,...]

            for (int i =0; i < imeprezime.Length; i++)
            {
                char slovo = imeprezime[i]; // broji za slovo
            }

        }
    }
}
