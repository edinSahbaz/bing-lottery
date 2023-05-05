using System;
using System.IO;
using System.Linq;

namespace BingoLotteryConsole;

public static class Generisanje
{
    static Random randomNumberGenerator;

    // ISSUE #1
    public static int[] GenerisiKombinaciju()
    {
        int[] kombinacija = new int[6];

        for (int i = 0; i < 6; i++)
        {
            int broj;

            do
            {
                broj = randomNumberGenerator.Next(1, 40);
            } while (Array.IndexOf(kombinacija, broj) != -1);

            kombinacija[i] = broj;
        }

        Array.Sort(kombinacija);

        return kombinacija;
    }

    // ISSUE #2
    public static int GenerisiDopunskiBroj(int[] kombinacija)
    {
        int dopunskiBroj = 0;
        bool duplikat = false;

        do
        {
            dopunskiBroj = randomNumberGenerator.Next(1, 40);

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

