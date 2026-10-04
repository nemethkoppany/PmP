/*
Módosítsuk úgy a programot, hogy az csak a páros számokat írja ki.
*/

Console.Write("Adj meg egy pozitív egész számot: ");
int N = int.Parse(Console.ReadLine());

/*
// Az érvénytelen bemenet kezelése (Amit nem lehet int típussá konvertálni)
//  - Megpróbálja a Console.ReadLine() függvény által beolvasott felhasználói bemenetet
//            egy int típusú változóvá alakítani.
//  - Az int.TryParse metódus ellenőrzi, hogy a konverzió sikeres volt-e.
//      - Ha a felhasználó számot adott meg,
//            akkor az értéket a N változóba helyezi,
//            és a kifejezés true-t ad vissza.
//  - Ha a konverzió nem sikerül (például mert a felhasználó nem számot adott meg),
//            akkor a TryParse visszatérési értéke false,
//            és a ! miatt a feltétel true lesz, így az if ágon belüli utasítások futnak le.
if (!int.TryParse(Console.ReadLine(), out int N))
{
    Console.WriteLine("Érvénytelen bemenet. Kérlek, adj meg egy pozitív egész számot!");
    return;
}

*/

/*
// Vizsgálat arra, hogy a megadott szám nullánál nagyobb.
if (N < 0)
{
    Console.WriteLine("Érvénytelen bemenet. Kérlek, adj meg egy nullánál nagyobb számot!");
    return;
}
// Az előző feltétellel összevonva:
    if (!int.TryParse(Console.ReadLine(), out int N) || N < 0)
*/

Console.WriteLine("Egész számok 0 és N között:");
for (int i = 0; i <= N; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}