namespace BingoLotteryConsole;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("LOTO 6/39");

        Dio1();
        Dio2();

        Console.ReadKey();
    }

    static void Dio1()
    {
        // Prikupljanje ulaznog podatka o broju listica
        Console.Write("Unesite broj listica: ");
        var brojListica = Convert.ToInt32(Console.ReadLine());

        // Generisanje n listica
        var listici = Generisanje.GenerisiListice(brojListica);

        // Spremanje listica u txt fajl
        Generisanje.SpremiListiceUTxtFile(listici);
    }

    static void Dio2()
    {
        // Generisanje pobjedničke kombinacije
        var dobitnaKombinacija = Generisanje.GenerisiKombinaciju();
        var dopunskiBroj = Generisanje.GenerisiDopunskiBroj(dobitnaKombinacija);

        // Citanje listica iz txt fajla
        var listici = Izvlacenje.ProcitajTxtFajl();

        // Generisanje izvještaja
        Izvlacenje.GenerisiIzvjestaj(listici, dobitnaKombinacija, dopunskiBroj);
    }
}