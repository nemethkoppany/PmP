/*
Írjunk programot, amely sztenderd formátumra hozza egy jármű rendszámát. A jelenlegi sztenderd formátum
kétszer két nagybetű, közöttük egy szóköz, majd egy kötőjel és három szám.

Példa:
A következő rendszámok mindegyike sztenderd formátumban AA BC-123:
• aabc 123
• a a BC123
• a a B c 1 2 3
• AABc-123
*/

Console.Write("Adj meg egy rendszámot:");
string rendszam = Console.ReadLine();
string betuk = "";
string szamok = "";

// Végig iterálunk a kapott rendszám karakterein
foreach (char karakter in rendszam)
{
    // Betűk megtartása
    if (char.IsLetter(karakter)) // Ha csak 4 betűt akarunk beolvasni: && betuk.Length < 4
    {
        betuk += char.ToUpper(karakter); // Nagybetűkre alakítás
    }
    // Számok megtartása
    else if (char.IsDigit(karakter)) // Ha csak 3 számot akarunk beolvasni: && szamok.Length < 3
    {
        szamok += karakter;
    }
}

// Formázás: két betű, egy szóköz, két betű, kötőjel és három szám
if (betuk.Length == 4 && szamok.Length == 3)
{
    string formatRendszam = $"{betuk[0]}{betuk[1]} {betuk[2]}{betuk[3]}-{szamok}";
    Console.WriteLine($"A rendszám sztenderd formátuma: {formatRendszam}");
}
else
{
    Console.WriteLine("Érvénytelen rendszám! 4 betűvel kell kezdődni és 3 számmal végződni! Pl.: aabc 123");
}
