using System;
using System.IO;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace BingoLotteryConsole;

public static class Generisanje
{
    // ISSUE #1
    // Implementirati logiku za generisanje 6 random brojeva u opsegu izmedju 1 i 39.
    // Generisanu kombinaciju sortirati od najmanjeg do najveceg broja.
    public static int[] GenerisiKombinaciju()
    {
        int[] kombinacija = new int[6];
        Random random = new Random();

        for (int i = 0; i < 6; i++)
        {
            int broj;

            do
            {
                broj = random.Next(1, 40);
            } while (Array.IndexOf(kombinacija, broj) != -1);

            kombinacija[i] = broj;
        }

        Array.Sort(kombinacija);

        return kombinacija;
    }

    // ISSUE #2
    // Implementirati logiku za generisanje dopunskog broja u opsegu izmedju 1 i 39.
    // NAPOMENA: Dopunski broj ne smije biti dio generisane pobjednicke kombinacije.
    public static int GenerisiDopunskiBroj(int[] kombinacija)
    {
        int dopunskiBroj = 0;
        Random random = new Random();
        bool duplikat = false;

        do
        {
            dopunskiBroj = random.Next(1, 40);

            duplikat = false;
            for (int i = 0; i < kombinacija.Length; i++)
            {
                if (dopunskiBroj == kombinacija[i])
                {
                    duplikat = true;
                    break;
                }
            }
        } while (duplikat);

        return dopunskiBroj;
    }

    // ISSUE #3
    // Implementirati logiku za generisanje n listica (koristiti generisi kombinaciju funkciju).
    public static List<int[]> GenerisiListice(int brojListica)
    {
        List<int[]> listici = new List<int[]>();

        for (int i = 0; i < brojListica; i++)
        {
            int[] kombinacija = GenerisiKombinaciju();
            listici.Add(kombinacija);
        }

        return listici;
    }

    // ISSUE #4
    // Implementirati logiku za spremanje listica u txt fajl.
    public static void SpremiListiceUTxtFile(List<int[]> listici)
    {
        using (StreamWriter writer = new StreamWriter("listici.txt"))
        {
            for (int i = 0; i < listici.Count; i++)
            {
                int[] listic = listici[i];
                writer.Write($"Listic br. {i + 1}: ");

                // Pisanje sortiranih brojeva u datoteku
                for (int j = 0; j < listic.Length; j++)
                {
                    writer.Write(listic[j]);
                    Console.Write(listic[j]);

                    if (j != listic.Length - 1)
                    {
                        writer.Write(", ");
                    }
                }

                writer.WriteLine();
                writer.WriteLine("-------------------------------------------");
            }
        }
    }
}

