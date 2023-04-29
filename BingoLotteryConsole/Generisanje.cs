using System;

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
    public static List<int[]> GenerisiListice(int brojListica)
    {
        List<int[]> listici = new List<int[]>();

        // Implementirati logiku za generisanje n listica (koristiti generisi kombinaciju funkciju).

        return listici;
    }

    // ISSUE #4
    public static void SpremiListiceUTxtFile(List<int[]> listici)
    {
        // Implementirati logiku za spremanje listica u txt fajl.
        // Spremati kombinacije na sljedeći način jednu ispod druge, razdvajajući listiće linijom:

        // Listic br. X: 1, 9, 15, 21, 28, 35, 39
        // --------------------------------------------------
        // Listic br. X: 5, 11, 14, 25, 29, 31, 36
        // --------------------------------------------------

        // Gdje X predstavlja poziciju listica u listi povećanu za 1 zbog 0-based indeksiranja.
        // (Nulti element -> 1. element)
    }
}

