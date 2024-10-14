namespace UcenjeKlasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Osoba ana = new Osoba("Ana", "Anić");
            Console.WriteLine(ana.Ime);
            ana.Ime = "Ble";
        }
    }
}
