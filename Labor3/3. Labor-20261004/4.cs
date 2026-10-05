/*
Módosítsuk az előző feladat megoldását úgy, hogy a felhasználótól bekért szavakat egy listában tároljuk el,
és a bekérést a STOP kulcsszó megadásakor fejezzük be. Ha szükséges, módosítsuk a két előbbi lekérdezést is.
Milyen hasonlóságokat és különbségeket tapasztalunk a tömbök és listák használatában?

Hasonlóságok:
    Hozzáférés: Mind a listák, mind a tömbök elemeihez index alapján férhetünk hozzá.
    Ciklusok: Ugyanúgy használhatunk for, foreach, vagy while ciklusokat mindkettőnél, hiszen mindkettő iterálható.

Különbségek:
    Méret: A tömbök fix méretűek, vagyis létrehozáskor meg kell határozni a hosszát,
           és utólag nem lehet megváltoztatni.
           A listák dinamikusan bővülnek, így nem kell előre meghatározni a méretüket,
           és a felhasználó által megadott bármennyi szó hozzáadható.
    Módosíthatóság: A listák elemei könnyen hozzáadhatók vagy eltávolíthatók,
                    míg a tömbökkel ez bonyolultabb lenne (új tömböt kellene létrehozni,
                    ha változtatni akarunk a méretén).
    Metódusok: A listák rendelkeznek beépített metódusokkal,
               mint például Add(), Remove(), Contains(), stb., 
               ami rugalmasabbá teszi őket a tömbökhöz képest.
*/

List<string> szavak = new List<string>();

// Szavak bekérése a felhasználótól, amíg a STOP kulcsszó nem érkezik
while (true)
{
    Console.Write("Add meg a következő szót (STOP a befejezéshez): ");
    string szo = Console.ReadLine();

    // A "ToUpper()" metódus nagybetűssé alakítja a szót, amit a felhasználó megadott,
    // tehát "case insensitive" a feltétel, ami azt jelenti, hogy nem számít a kis és
    // nagy betű a STOP szóban.
    // Hint: https://learn.microsoft.com/en-us/dotnet/api/system.string.toupper?view=net-8.0
    if (szo.ToUpper() == "STOP")
    {
        break; // Kilépés a ciklusból a STOP kulcsszóra
    }

    szavak.Add(szo); // Hozzáadás a listához
}

// Keresendő szó bekérése
Console.Write("Add meg a keresendő szót: ");
string keresettSzo = Console.ReadLine();

// Szó keresése while ciklussal a listában
int index = -1;
int i = 0;

// Iterálás a Lista végéig
while (i < szavak.Count)
{
    if (szavak[i] == keresettSzo)
    {
        index = i;
        break; // Megáll, ha megtalálta az első előfordulást
    }
    i++;
}

// Eredmény kiírása
if (index != -1)
{
    Console.WriteLine($"A(z) \"{keresettSzo}\" szerepel a gyűjteményben, és először a(z) {index + 1}. helyen található.");
}
else
{
    Console.WriteLine($"A(z) \"{keresettSzo}\" nem található a gyűjteményben.");
}
