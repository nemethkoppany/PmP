/*
Felmérést végzünk barátaink programozói ismereteiről. Kérjük el az adott személy nevét (string), életkorát
(int) és hogy rendelkezik-e programozói tapasztalattal (bool). A neveket, életkorokat és tapasztalatokat tároljuk
három külön listában, amelyeket az kapcsol össze, hogy egy adott indexen egy konkrét személy adatait találjuk.
A bekérést egy üres név megadásáig folytassuk. Ezt követően határozzuk meg az alábbiakat.
• Mi az átlagéletkor a teljes adathalmazban? (Használjuk a foreach utasítást a bejáráshoz.)
• Mi az átlagéletkor a programozói tapasztalat nélküli személyek között?
• Hány éves a legidősebb, programozó tapasztalattal rendelkező személy és mi a neve?
*/

// Listák az adatok tárolásához
List<string> nevek = new List<string>(); // Nevek listája
List<int> eletkorok = new List<int>(); // Életkorok listája
List<bool> tapasztalat = new List<bool>(); // Tapasztalatok listája

// Adatok bekérése a felhasználótól
while (true)
{
    Console.Write("Add meg a személy nevét vagy hagyd üresen a befejezéshez: ");
    string nev = Console.ReadLine();

    // A string IsNullOrEmpty metódus megvizsgálja, hogy a kapott (string) változó
    // értéke Null (semmi) vagy üres.
    if (string.IsNullOrEmpty(nev))
    {
        break; // Kilépés a ciklusból, ha a név üres
    }

    Console.Write("Add meg a személy életkorát: ");
    if (!int.TryParse(Console.ReadLine(), out int eletkor) || eletkor < 0)
    {
        Console.WriteLine("HIBA: Pozitív egész számot kell megadni életkornak!");
        return;
    }

    Console.Write("Rendelkezik programozói tapasztalattal? (true/false): ");
    if (!bool.TryParse(Console.ReadLine(), out bool programozoiTapasztalat))
    {
        Console.WriteLine("HIBA: 'true' vagy 'false'  értéket kell megadni tapasztalatnak!");
        return;
    }

    // Adatok hozzáadása a listákhoz
    nevek.Add(nev);
    eletkorok.Add(eletkor);
    tapasztalat.Add(programozoiTapasztalat);
}

// Megvizsgáljuk, hogy bármelyik Lista üres-e (Ha igen, akkor kiírunk egy figyelmeztető szöveget).
// A lista "Any" metódusa igaz (true) értékkel tér vissza, ha van benne elem és hamis (false) értékkel, ha nincs, tehát üres a lista.
// Hint: https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.any?view=net-8.0
// Hint2: https://stackoverflow.com/questions/18867180/check-if-list-is-empty-in-c-sharp
// A "!" jel ugye a logikai negálás. Ez azért kell, mert pont a negatív esetet szeretnénk kezelni, tehát, amikor üzes a lista.
if (!nevek.Any() || !eletkorok.Any() || !tapasztalat.Any())
{
    Console.WriteLine("FIGYELMEZTETÉS: Nem adtál meg egyetlen személyt sem!");
}

// Átlagéletkor kiszámítása a teljes adathalmazban
int osszEletkor = 0;
foreach (int kor in eletkorok) // Végig iterálunk az eletkorok listán
{
    osszEletkor += kor; // Összeadjuk az összes életkort a listában
}
// Átlag életkor kiszámítása: Összes életkor / Az emberek száma (Lista elemeinek száma)
// A "Count" metódus visszaadja a Lista elemeinek számát (Hasonlóan a Length metódushoz a tömbök esetében).
double atlagEletkor = (double)osszEletkor / eletkorok.Count;
Console.WriteLine($"Az átlagéletkor a teljes adathalmazban: {atlagEletkor:F2}");

// Átlagéletkor kiszámítása a programozói tapasztalat nélküli személyek között
int osszEletkorTapasztalatNelkul = 0;
int tapasztalatNelkulSzamlalo = 0;
for (int i = 0; i < tapasztalat.Count; i++) // Végig iterálunk a tapasztalat listán
{
    if (!tapasztalat[i]) // Ha nincs programozói tapasztalat (Ha az érték hamis (false))
    {
        osszEletkorTapasztalatNelkul += eletkorok[i];
        tapasztalatNelkulSzamlalo++;
    }
}

// Ha van olyan személy, akinek nincs tapasztalata
if (tapasztalatNelkulSzamlalo > 0)
{
    double atlagEletkorTapasztalatNelkul = (double)osszEletkorTapasztalatNelkul / tapasztalatNelkulSzamlalo;
    Console.WriteLine($"Az átlagéletkor a programozói tapasztalat nélküli személyek között: {atlagEletkorTapasztalatNelkul:F2}");
}
else
{
    Console.WriteLine("Nincsenek programozói tapasztalat nélküli személyek az adathalmazban.");
}

// Legidősebb programozói tapasztalattal rendelkező személy és neve
int legidosebbKor = -1;
string legidosebbNev = "";

for (int i = 0; i < tapasztalat.Count; i++)  // Végig iterálunk a tapasztalat listán
{
    // Ha van tapasztalat és a hozzá tartozó életkor magasabb, mint az aktuális legidősebb érték.
    if (tapasztalat[i] && eletkorok[i] > legidosebbKor)
    {
        legidosebbKor = eletkorok[i];
        legidosebbNev = nevek[i];
    }
}

if (legidosebbKor != -1)
{
    Console.WriteLine($"A legidősebb programozói tapasztalattal rendelkező személy: {legidosebbNev}, {legidosebbKor} éves.");
}
else
{
    Console.WriteLine("Nincsenek programozói tapasztalattal rendelkező személyek az adathalmazban.");
}