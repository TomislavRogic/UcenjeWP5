namespace UcenjeKlasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //Osoba ana = new Osoba("Ana", "Anić");
            //Console.WriteLine(ana.Ime);
            ////ana.Ime = "Ble";

            // korisnik ce 5 puta upisati ime i prezime u konzolu. Napravi 5 osoba i spremi ih u polje. Dodati
            // fju Predstavi se koja vraca string u kojem pise "Bok ja sam x x". Ispisi sve osobe
            Console.WriteLine("Molim unesi 5 imena i 5 prezimena");
            Osoba[] osobe = new Osoba[5];

            for(int i = 0; i<5; i++)
            {
                string ime = Console.ReadLine();
                string prezime = Console.ReadLine();
                Osoba nekaOsoba = new Osoba(ime, prezime);
                osobe[i] = nekaOsoba;
            }
        }
    }
}
