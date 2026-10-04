/*
Készítsünk tízes számrendszerből kettes számrendszerbe átváltó alkalmazást. A bemenet legyen egy 32
bites előjel nélküli egész (uint), kimenetként pedig jelenítsük meg az érték kettes számrendszerbeli alakját 8
bites blokkokban, big endian formátumban.

Példa
420 (10) = 00000000 00000000 00000001 10100100 (2)

Hint unit-re: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types
*/

// Bemenet bekérése a felhasználótól
Console.Write("Adj meg egy 32 bites előjel nélküli egész számot (uint): ");
if (!uint.TryParse(Console.ReadLine(), out uint number))
{
    Console.WriteLine("Érvénytelen bemenet. Kérlek, adj meg egy pozitív egész számot!");
    return;
}

// Az uint érték átalakítása 32 bites bináris formára
string binary = Convert.ToString(number, 2).PadLeft(32, '0'); // 32 bites bináris forma

// A kimenet formázása 8 bites blokkokban
string formattedBinary = "";
for (int i = 0; i < 32; i += 8)
{
    formattedBinary += binary.Substring(i, 8) + " ";
}

// A végeredmény kiírása
Console.WriteLine($"{number} (10) = {formattedBinary.Trim()} (2)");