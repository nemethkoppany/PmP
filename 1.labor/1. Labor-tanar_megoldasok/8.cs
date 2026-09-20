/*
Alakítsuk át úgy az előző programot, hogy a jelszó beírásakor a karakterek helyett csak *-ok jelenjenek meg.
Legyen lehetőség tévesen bevitt karakter törlésére is a Backspace billentyűvel.
*/

using System;

class Program
{
    static void Main()
    {
        // Jelszó bekérése csillagokkal (*)
        Console.Write("Kérlek, add meg a jelszavadat: ");
        string jelszo1 = ReadPassword();

        // Jelszó megerősítése csillagokkal (*)
        Console.Write("\nKérlek, add meg újra a jelszavadat: ");
        string jelszo2 = ReadPassword();

        // Jelszavak összehasonlítása
        if (jelszo1 == jelszo2)
        {
            // Zöld szín beállítása és sikeres üzenet
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nA jelszavak egyeznek!");
        }
        else
        {
            // Piros szín beállítása és hibaüzenet
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nHiba: A megadott jelszavak nem egyeznek!");
        }

        // Szín visszaállítása az alapértelmezett színre
        Console.ResetColor();

        // Program vége
        Console.WriteLine("Nyomj meg egy Enter billentyűt a kilépéshez...");
        Console.ReadLine();
    }

    // Specifikus függvény jelszó bevitelére csillagokkal (*)
    static string ReadPassword()
    {
        string password = "";
        ConsoleKeyInfo key;

        do
        {
            key = Console.ReadKey(true); // A billentyű lenyomása rejtve marad

            if (key.Key == ConsoleKey.Backspace && password.Length > 0)
            {
                password = password.Substring(0, password.Length - 1);
                Console.Write("\b \b"); // Karakter visszavétele a konzolon
            }
            else if (key.Key != ConsoleKey.Enter)
            {
                password += key.KeyChar;
                Console.Write("*");
            }
        } while (key.Key != ConsoleKey.Enter); // Amíg nem nyomja meg az Entert

        return password;
    }
}
