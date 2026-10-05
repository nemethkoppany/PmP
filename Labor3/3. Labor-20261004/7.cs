/*
Egy horgászverseny fogási adatait egy F táblázatban (kétdimenziós tömbben) tároljuk. F(i, j) azt jelenti,
hogy az i-edik horgász a j-edik halfajtából hány darabot fogott.
• Generáljuk le véletlenszerűen a táblázat adatait.
• Jelenítsük meg formázottan a fogási adatokat a képernyőn.
• Adjuk meg, hogy a horgászok mennyit fogtak az egyes halfajtákból.
• Melyik horgász fogta a legtöbb halat összesen?
• Volt-e olyan horgász, aki egyetlen halat sem fogott?
*/

Random rnd = new Random();

// Horgászok és halfajták számának megadása
int horgaszokSzama = 5; // Horgászok száma
int halfajtakSzama = 4; // Halfajok száma

// Fogási adatok táblázatának létrehozása
int[,] F = new int[horgaszokSzama, halfajtakSzama];

// Fogási adatok véletlenszerű generálása
for (int i = 0; i < horgaszokSzama; i++)
{
    for (int j = 0; j < halfajtakSzama; j++)
    {
        // Az i. horgász a j. halfajból [0-10] darabot fogott.
        F[i, j] = rnd.Next(0, 11); // Véletlenszerű fogások 0 és 10 között
    }
}

// Fogási adatok megjelenítése
Console.WriteLine("Fogási adatok (Horgászok sorokban, Halfajták oszlopokban):");
for (int i = 0; i < horgaszokSzama; i++) // Végig iterálunk a horgászokon
{
    for (int j = 0; j < halfajtakSzama; j++) // Végig iterálunk a halfajtakon, hogy miből mennyit fogott a horgász
    {
        // F[i, j]: Ez maga az aktuális elem a kétdimenziós tömbből, amit ki szeretnénk írni.
        // ,3: Ez egy formázási utasítás, amely megadja,
        //     hogy a kiírt érték legyen legalább 3 karakter széles.
        //     Ha az érték ennél rövidebb (pl. egyjegyű szám), akkor balra kitöltődnek
        //     a hiányzó karakterek szóközzel.
        Console.Write($"{F[i, j],3} "); // Formázott kiírás
    }
    Console.WriteLine();
}

// Halfajtánkénti összes fogás kiszámítása
// Note: A "\n" egy új sort szúr be ("nyom egy entert"): https://learn.microsoft.com/en-us/dotnet/api/system.environment.newline?view=net-8.0
Console.WriteLine("\nÖsszes fogás halfajtánként:");
for (int j = 0; j < halfajtakSzama; j++) // Végig iterálunk a halfajtakon
{
    int osszesFajtaFogas = 0;
    for (int i = 0; i < horgaszokSzama; i++) // Végig iterálunk a horgászokon
    {
        osszesFajtaFogas += F[i, j]; // Összeadjuk a fogott halak számát
    }
    Console.WriteLine($"Halfajta {j + 1}: {osszesFajtaFogas} db");
}

// A legtöbb halat fogó horgász meghatározása
int legtobbHalHorgasz = -1;
int legtobbHal = 0;
for (int i = 0; i < horgaszokSzama; i++) // Végig iterálunk a horgászokon
{
    int horgaszFogas = 0;
    for (int j = 0; j < halfajtakSzama; j++) // Végig iterálunk a halfajtakon
    {
        horgaszFogas += F[i, j];
    }
    if (horgaszFogas > legtobbHal) // Ha az adott horgász fogása nagyobb, mint a korábbi legnagyobb fogás
    {
        legtobbHal = horgaszFogas;
        legtobbHalHorgasz = i;
    }
}
Console.WriteLine($"\nA legtöbb halat fogó horgász: {legtobbHalHorgasz + 1}, {legtobbHal} db hal.");

// Ellenőrzés: volt-e olyan horgász, aki nem fogott egyetlen halat sem
bool voltNullasHorgasz = false;
for (int i = 0; i < horgaszokSzama; i++) // Végig iterálunk a horgászokon
{
    int horgaszFogas = 0;
    for (int j = 0; j < halfajtakSzama; j++) // Végig iterálunk a halfajtakon
    {
        horgaszFogas += F[i, j];
    }
    if (horgaszFogas == 0) // Ha a horgász minden halfajtából 0 darabot fogott.
    {
        Console.WriteLine($"\nA(z) {i + 1}. horgász nem fogott egyetlen halat sem.");
        voltNullasHorgasz = true;
    }
}

if (!voltNullasHorgasz)
{
    Console.WriteLine("\nMinden horgász fogott legalább egy halat.");
}