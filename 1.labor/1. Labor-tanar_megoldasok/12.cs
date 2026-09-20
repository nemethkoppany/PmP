/*
Kérjünk egy a felhasználótól egy betűt, majd írjuk ki, hogy magánhangzót vagy mássalhangzót adott-e meg.
*/

// Felhasználótól betű bekérése
Console.Write("Adj meg egy betűt: ");
string input = Console.ReadLine();

// Ellenőrizzük, hogy a bemenet pontosan egy karakter hosszú és betű-e
//    - https://learn.microsoft.com/en-us/dotnet/api/system.string.length?view=net-8.0
//    - https://learn.microsoft.com/en-us/dotnet/api/system.char.isletter?view=net-8.0
if (input.Length == 1 && char.IsLetter(input[0]))
{
    // Kisbetűs formára konvertálás
    // https://learn.microsoft.com/en-us/dotnet/api/system.char.tolower?view=net-8.0
    char betu = char.ToLower(input[0]);

    // Magánhangzók ellenőrzése egy if kondíción belül a logikai ÉS operátorral (||)
    // Hint: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators
    if (betu == 'a' || betu == 'e' || betu == 'i' || betu == 'o' || betu == 'u' ||
        betu == 'á' || betu == 'é' || betu == 'í' || betu == 'ó' || betu == 'ö' || betu == 'ő' || betu == 'ú' || betu == 'ü' || betu == 'ű')
    {
        Console.WriteLine("A megadott betű magánhangzó.");
    }
    // Mássalhangzók ellenőrzése
    else
    {
        Console.WriteLine("A megadott betű mássalhangzó.");
    }
}
else
{
    Console.WriteLine("Hiba: Kérlek, adj meg egy érvényes betűt.");
}

// Program vége
Console.WriteLine("Nyomj meg egy Enter billentyűt a kilépéshez...");
Console.ReadLine();