namespace UcenjeCS
{
    internal class E1Zadatakinstrukcije
    {
        public static void Izvedi()
        {
            //string ime = "Marko";
            //char prvoslovo = ime[0];
            //string prezime = "Markic";

            //string imeprezime = ime + " " + prezime; //MarkoMarkic
            //imeprezime = imeprezime.ToLower();
            ////string tekst= Console.ReadLine();
            ////Console.WriteLine(tekst);

            //int[] ponavljanjeslova = new int[26]; // [0:A, 1: B,...]

            //for (int i =0; i < imeprezime.Length; i++)
            //{
            //    char slovo = imeprezime[i]; // broji za slovo
            //}


            //int a; // deklaracija varijable => tip ime;
            //a= 3; // inicijalizacija => postavljanje početne vrijednosti varijabli
            //Console.WriteLine(a);
            //a = 6;

            //long c = 4;

            //float g = 3.4345f;
            //double b = 3.343534567646;

            //int a = 4;
            //float b = a; // implicitno castanje
            //// b = 4.0

            //b = 3.14f;
            //a = (int) b; // eksplicitno castanje

            //int a = 5 / 2; // 2 - cjelobrojno djeljenje
            //float b = 5 / 2f; // 2.5 - decimalno djeljenje
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            // 2 / 2 = 1;        2 % 2 = 0
            // 3 /2  = 1;        3 % 2 = 1
            // 4 / 2 = 2;        4 % 2 = 0

            // 3 / 3 = 1        3 % 3 = 0
            // 4 / 3 = 1        4 % 3 = 1
            // 5 / 3 = 1        5 % 3 = 2

            // ucitaj broj s konzole i ispisi ako nije djeljiv s 3
            //int broj;
            //Console.WriteLine("Molim unesi cijeli broj:");
            //broj = int.Parse( Console.ReadLine());

            //if (broj % 3 != 0)
            //{
            //    Console.WriteLine("Broj nije djeljiv s 3");
            //}


            // 345
            int broj = 345;
            int desnaZnamenka = broj % 10; // 345 / 10 = 34      345 % 10 = 5
            int srednjaZnamenka = (broj / 10) % 10; // 345 / 10 = 34       34 % 10 = 4
            int lijevaZnamenka = broj / 100;

            // jako slabo vas cujem. nemam materijale za ovo sto smo radili, ali mogu vam zadati par zadataka za vjezbu
            // moze. i vjezbat cemo petlje?
            // moze, sljedeci put petnje, pozdrav
            //pozdrav
        }
    }
}
