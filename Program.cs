using StudentskiDogodki;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Lokacija lokacija = new Lokacija();
        Prizorisce prizorisce = new Prizorisce(lokacija, true, 5000, 2000);

        List<string> seznamPredavanj = new List<string>()
        {
            "Napredno programiranje za studente",
            "Kako hitro do diplome?",
            "Zakaj se (ne) splaca studirati?"
        };

        Konferenca konferenca = new Konferenca("Mednarodna konferenca", "Konferenca o izobrazevanju", prizorisce, DateTime.Now, TimeSpan.FromHours(2), false, 4, 50.0, seznamPredavanj, true);

        List<string> seznamNastopajocih = new List<string>()
        {
            "JokerOut"
        };

        Koncert koncert = new Koncert("Veliki rock koncert", "Koncert priljubljenih bendov", prizorisce, DateTime.Now.AddDays(1), TimeSpan.FromHours(3), false, 5, 30.0, seznamNastopajocih);

        List<string> osebeZaKoncert = new List<string> { "Janez Novak", "Ivan Novak", "Maja Novak" };
        List<string> osebeZaKonferenco = new List<string> { "Ana Kranjc", "Marko Polje", "Sara Zelen" };

        string rezultatKoncert = koncert.NagradnaIgra(2, osebeZaKoncert);
        Console.WriteLine("Rezultati nagradne igre za koncert:");
        Console.WriteLine(rezultatKoncert);

        string rezultatKonferenca = konferenca.NagradnaIgra(2, osebeZaKonferenco);
        Console.WriteLine("Rezultati nagradne igre za konferenco:");
        Console.WriteLine(rezultatKonferenca);

        Console.WriteLine("\nKonferenca:");
        Console.WriteLine(konferenca);
        Console.WriteLine("\nKoncert:");
        Console.WriteLine(koncert);
    }
}
