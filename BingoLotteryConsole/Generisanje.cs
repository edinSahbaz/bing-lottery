using System;

namespace BingoLotteryConsole;

public static class Generisanje
{
    // ISSUE #1
    public static int[] GenerisiKombinaciju()
    {
        int[] kombinacija = new int[6];

        // Implementirati logiku za generisanje 6 random brojeva u opsegu izmedju 1 i 39.
        // Generisanu kombinaciju sortirati od najmanjeg do najveceg broja.

        return kombinacija;
    }

    // ISSUE #2
    public static int GenerisiDopunskiBroj(int[] kombinacija)
    {
        int dopunskiBroj = 0;

        // Implementirati logiku za generisanje dopunskog broja u opsegu izmedju 1 i 39.
        // NAPOMENA: Dopunski broj ne smije biti dio generisane pobjednicke kombinacije.

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

