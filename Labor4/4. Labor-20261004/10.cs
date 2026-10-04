/*
Készítsünk egyszerű szövegszerkesztő programot az alábbiak szerint. A szöveget tároljuk egy kétdimenziós
karaktertömbben, amelynek mérete előre megadott (pl. 50 karakter széles és 20 karakter magas). A program
frissítse és jelenítse meg a tömb tartalmát minden billentyűlenyomás után. Legyen lehetőség a kurzorbillentyűk
segítségével navigálni a szövegben, továbbá szöveg beírására, amely ilyenkor felülírja a korábban ott lévő szöveget.
*/

using System;

class Program
{
    static void Main()
    {
        const int WIDTH = 50; // Szélesség
        const int HEIGHT = 20; // Magasság

        char[,] textBuffer = new char[HEIGHT, WIDTH]; // Kétdimenziós tömb inicializálása
        int cursorX = 0; // Kurzor X pozíció
        int cursorY = 0; // Kurzor Y pozíció

        // Inicializáljuk a tömböt üres karakterekkel
        for (int i = 0; i < HEIGHT; i++)
        {
            for (int j = 0; j < WIDTH; j++)
            {
                textBuffer[i, j] = ' ';
            }
        }

        while (true)
        {
            Console.Clear(); // Képernyő törlése
            DisplayBuffer(textBuffer, cursorX, cursorY); // Megjelenítjük a szöveget

            ConsoleKeyInfo keyInfo = Console.ReadKey(true); // Billentyűlenyomás olvasása

            // Navigálás a kurzorbillentyűkkel
            if (keyInfo.Key == ConsoleKey.UpArrow && cursorY > 0)
            {
                cursorY--; // Fel
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow && cursorY < HEIGHT - 1)
            {
                cursorY++; // Le
            }
            else if (keyInfo.Key == ConsoleKey.LeftArrow && cursorX > 0)
            {
                cursorX--; // Balra
            }
            else if (keyInfo.Key == ConsoleKey.RightArrow && cursorX < WIDTH - 1)
            {
                cursorX++; // Jobbra
            }
            // Szöveg bevitele
            else if (keyInfo.KeyChar != 0) // Ha nem irányító billentyű
            {
                textBuffer[cursorY, cursorX] = keyInfo.KeyChar; // Karakter bevitele
                cursorX++; // Kurzor jobbra léptetése

                // Ha elérjük a sor végét, új sorba lépünk
                if (cursorX >= WIDTH)
                {
                    cursorX = 0;
                    cursorY++;
                    if (cursorY >= HEIGHT) cursorY = HEIGHT - 1; // Ne lépjünk ki a keretből
                }
            }

            // Kilépés a programból (ESC billentyű)
            if (keyInfo.Key == ConsoleKey.Escape) break;
        }
    }

    // A szöveg megjelenítése
    static void DisplayBuffer(char[,] buffer, int cursorX, int cursorY)
    {
        for (int i = 0; i < buffer.GetLength(0); i++)
        {
            for (int j = 0; j < buffer.GetLength(1); j++)
            {
                if (i == cursorY && j == cursorX)
                {
                    Console.BackgroundColor = ConsoleColor.Gray; // Kurzor kiemelése
                    Console.Write(buffer[i, j]);
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(buffer[i, j]);
                }
            }
            Console.WriteLine(); // Új sor
        }
    }
}
