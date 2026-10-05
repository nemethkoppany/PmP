/*
Készítsünk programot, amely ciklusok használatával felsorolja a francia kártya lapjait egy tömbbe . A
lehetséges színek: Kőr, Káró, Treff és Pikk. A lapoknak 13 féle magassága lehet: számok 2-től 10-ig, majd
Jumbó, Dáma, Király és Ász.

Példa:
Az 52 elemű tömb elemei tehát:
{ "Kőr 2", "Kőr 3", ..., "Kőr Király", "Kőr Ász", "Káró 2", "Káró 3", ...,
"Pikk Dáma", "Pikk Király", "Pikk Ász" }
*/

// Szín tömb
string[] szinek = { "Kőr", "Káró", "Treff", "Pikk" };
// Magasság tömb
string[] magassagok = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jumbó", "Dáma", "Király", "Ász" };
// Eredmény tömb
string[] kartyaLapok = new string[52];

// A "kartyaLapok" indexelésére használatos változó.
int kartyaLapokIndex = 0;

// Iterálás a színeken
for (int i = 0; i < szinek.Length; i++)
{
    // Iterálás a magasságokon
    for (int j = 0; j < magassagok.Length; j++)
    {
        // A szín és magasság párosítása
        kartyaLapok[kartyaLapokIndex] = szinek[i] + " " + magassagok[j];
        kartyaLapokIndex++;
    }
}

// Eredmény kiírása for ciklussal
// Az "<=" kifejezes azért nem helyes a feltételben, mert túlindexeli a tömböt
// Ne felejtsük el, hogy a tömb indexelése 0-tól kezdődik, ami azt jelenti, hogy
// ha a tömb 1 elemű, akkor csak a 0. indexen van értéke, viszont a Length
// 1-et fog visszaadni, mert akkora a mérete a tömbnek.
for (int i = 0; i < kartyaLapok.Length; i++)
{
    Console.WriteLine(kartyaLapok[i]);
}

/*
// Eredmény kiírása foreach ciklussal
foreach (string lap in kartyaLapok)
{
    Console.WriteLine(lap);
}
*/