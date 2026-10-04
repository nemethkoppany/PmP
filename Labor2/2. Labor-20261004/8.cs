/*
Készítsük programot, amely kiírja a képernyőre a szorzótáblát az alábbihoz hasonlóan.
*/

const int size = 10; // A szorzótábla mérete (1-től 10-ig)

// Szorzótábla fejléc
Console.Write("   "); // Üres hely a bal felső sarokban
for (int i = 1; i <= size; i++)
{
    Console.Write($"{i,4}"); // Formázott oszlopfejlécek
}
Console.WriteLine();

// Szorzótábla sorai
for (int i = 1; i <= size; i++)
{
    Console.Write($"{i,2} "); // Sorfejléc (sor eleje)

    for (int j = 1; j <= size; j++)
    {
        Console.Write($"{i * j,4}"); // Szorzó értékek
    }
    Console.WriteLine();
}