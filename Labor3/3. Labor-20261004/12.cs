/*
Készítsünk egy egyszerű labirintus játékot. Töltsünk fel egy kétdimenziós tömböt véletlenszerűen true és
false értékekkel. Adjunk meg egy kezdő koordinátát (indexet), majd határozzuk meg, hogy onnan eljuthatunk-e
bármilyen úton a jobb alsó sarokba mindig csak szomszédos true mezőkre lépve. Egy adott elem szomszédai
alatt a tőle balra és jobbra, valamint felette és alatta lévő elemeket értjük. A feltételeknek eleget tevő út nem
minden esetben létezik. Ugyanígy előfordulhat, hogy több megfelelő útvonal is található a labirintusban.
*/

using System;

class LabirintusJatek
{
    static int sorok = 4;
    static int oszlopok = 10;
    static bool[,] labirintus;
    static bool[,] latogatott;

    static void Main(string[] args)
    {
        // Labirintus és látogatott mezők inicializálása
        labirintus = new bool[sorok, oszlopok];
        latogatott = new bool[sorok, oszlopok];

        Random rand = new Random();
        for (int i = 0; i < sorok; i++)
        {
            for (int j = 0; j < oszlopok; j++)
            {
                // ?: operator - the ternary conditional operator
                // Hint: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator
                labirintus[i, j] = rand.Next(0, 2) == 0 ? false : true;
            }
        }

        // A generált labirintus kiíratása
        Console.WriteLine("Generált labirintus:");
        KiirLabirintus();

        // Kezdő koordináták (A mátrix mérete felének a tartományában, hogy ne legyen túl közel a jobb alsó sarokhoz)
        int kezdX = rand.Next(0, sorok/2), kezdY = rand.Next(0, oszlopok/2);

        // Addig adunk új értéket kezdX és kezdY kezdő koordinátáknak amíg azok nem true mezőn állank.
        while (!labirintus[kezdX, kezdY])
        {
            kezdX = rand.Next(0, sorok/2);
            kezdY = rand.Next(0, oszlopok/2);
        }

        Console.WriteLine($"\nA kezdő koordináták: X:{kezdX} ; Y:{kezdY}");

        // Út keresése
        if (UtvonalKereses(kezdX, kezdY))
        {
            Console.WriteLine("\nÚt a jobb alsó sarokba megtalálva:");
        }
        else
        {
            Console.WriteLine("\nNem található út a jobb alsó sarokba. Bejárt út (Kék a kiinduló pont és piros a bejárt út):");
        }

        // A labirintus kiíratása az útvonal jelölésével
        KiirLabirintusUt(kezdX, kezdY);
    }

    // Útvonal keresése rekurzívan
    static bool UtvonalKereses(int x, int y)
    {
        // Alapeset: ha kint vagyunk a labirintusból vagy hamis mezőn állunk
        if (x < 0 || y < 0 || x >= sorok || y >= oszlopok || !labirintus[x, y] || latogatott[x, y])
            return false;

        // Jelöljük a cellát látogatottnak
        latogatott[x, y] = true;

        // Ha elértük a jobb alsó sarkot
        if (x == sorok - 1 && y == oszlopok - 1)
            return true;

        // Próbáljunk meg minden irányba lépni: le, jobbra, fel, balra
        if (UtvonalKereses(x + 1, y) || UtvonalKereses(x, y + 1) || UtvonalKereses(x - 1, y) || UtvonalKereses(x, y - 1))
            return true;

        // Ha nem található út, akkor visszalépünk, de a látogatott mezőt jelölve hagyjuk
        return false;
    }

    // Labirintus kiíratása
    static void KiirLabirintus()
    {
        for (int i = 0; i < sorok; i++)
        {
            for (int j = 0; j < oszlopok; j++)
            {
                Console.Write(labirintus[i, j] ? "T " : "F ");
            }
            Console.WriteLine();
        }
    }

    // Labirintus kiíratása a bejárt úttal
    static void KiirLabirintusUt(int kezdX, int kezdY)
    {
        for (int i = 0; i < sorok; i++)
        {
            for (int j = 0; j < oszlopok; j++)
            {
                if (i == kezdX && j == kezdY)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write(labirintus[i, j] ? "T " : "F ");
                    Console.ResetColor();
                }
                else if (latogatott[i, j])
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("T ");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(labirintus[i, j] ? "T " : "F ");
                }
            }
            Console.WriteLine();
        }
    }
}
