/*
Egészítsük ki az előző félkarú rabló játékot ASCII art grafikai elemekkel: a számok helyett karakterekből
kialakított színes figurák (pl. pikk, kőr, treff, káró) jelenjenek meg pörgetéskor.
*/

using System;
using System.Threading;

class Program
{
    static readonly string[] symbols = { "♠", "♥", "♣", "♦" }; // Pikk, Kőr, Treff, Káró

    static void Main()
    {
        int credits = 100; // Kezdő kreditek
        int bet = 1; // Alaptét
        Random random = new Random();
        ConsoleKey key;

        Console.WriteLine("Félkarú rabló játék!");
        Console.WriteLine("Spacebar: Pörgetés, Fel/Le nyilak: Tét növelése/csökkentése, Escape: Kilépés");
        Console.WriteLine($"Kezdő kreditek: {credits}");

        while (credits > 0)
        {
            Console.WriteLine($"Jelenlegi tét: {bet} kredit | Kreditek: {credits}");
            key = Console.ReadKey(true).Key;

            if (key == ConsoleKey.Escape)
            {
                Console.WriteLine("Kilépés a játékból.");
                break;
            }

            if (key == ConsoleKey.UpArrow && bet < credits)
            {
                bet++;
                Console.WriteLine($"Tét növelve: {bet} kredit");
            }
            else if (key == ConsoleKey.DownArrow && bet > 1)
            {
                bet--;
                Console.WriteLine($"Tét csökkentve: {bet} kredit");
            }
            else if (key == ConsoleKey.Spacebar)
            {
                // Levonjuk a tétet a kreditből
                credits -= bet;

                // Pörgetés: három véletlenszerű szimbólum
                int reel1 = random.Next(0, symbols.Length);
                int reel2 = random.Next(0, symbols.Length);
                int reel3 = random.Next(0, symbols.Length);

                // Szimbólumok kirajzolása színesen
                PrintSymbol(reel1);
                PrintSymbol(reel2);
                PrintSymbol(reel3);
                Console.WriteLine();

                // Nyeremény ellenőrzése
                if (reel1 == reel2 && reel2 == reel3)
                {
                    int win = bet * 50;
                    credits += win;
                    Console.WriteLine($"Három egyforma! Nyeremény: {win} kredit!");
                }
                else if (reel1 == reel2 || reel2 == reel3 || reel1 == reel3)
                {
                    int win = bet * 10;
                    credits += win;
                    Console.WriteLine($"Két egyforma! Nyeremény: {win} kredit!");
                }
                else
                {
                    Console.WriteLine("Nincs nyeremény.");
                }

                // Ellenőrizzük, hogy elfogyott-e a kredit
                if (credits <= 0)
                {
                    Console.WriteLine("Elfogytak a kreditjeid! Játék vége.");
                    break;
                }
            }

            Thread.Sleep(100); // Egy kis szünet a következő kör előtt
        }
    }

    // Segédfüggvény a szimbólumok színes kiírásához
    static void PrintSymbol(int index)
    {
        switch (symbols[index])
        {
            case "♠": // Pikk
                Console.ForegroundColor = ConsoleColor.Gray;
                break;
            case "♥": // Kőr
                Console.ForegroundColor = ConsoleColor.Red;
                break;
            case "♣": // Treff
                Console.ForegroundColor = ConsoleColor.Green;
                break;
            case "♦": // Káró
                Console.ForegroundColor = ConsoleColor.Yellow;
                break;
        }

        Console.Write(symbols[index] + " ");
        Console.ResetColor();
    }
}
