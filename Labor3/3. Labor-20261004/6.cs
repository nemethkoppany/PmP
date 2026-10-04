/*
Hozzunk létre egy N × M-es kétdimenziós tömböt (1 < N, M < 10), amit töltsünk fel véletlenszerűen
0 és 9 közötti értékekkel. Jelenítsük meg a képernyőn ennek a mátrixnak az elemeit. Állítsuk elő a mátrix
transzponáltját1

, vagyis tükrözzük azt a főátlójára.

Példa
1 2 3
4 5 6
7 8 9
  ↓ 
1 4 7
2 5 8
3 6 9

a b c d
e f g h
i j k l
  ↓ 
a e i
b f j
c g k
d h l
*/

Random rnd = new Random();

// N és M értékek megadása (2 és 9 közötti véletlen számok)
int N = rnd.Next(2, 10);
int M = rnd.Next(2, 10);

// 2 dimenziós Mátrix létrehozása és véletlen számokkal feltöltése
// Hint: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays
int[,] matrix = new int[N, M];

Console.WriteLine($"Eredeti {N} x {M} mátrix:");
// Beágyazott ciklus!
for (int i = 0; i < N; i++) // Végig iterálunk az 1. dimenzión (sor)
{
    for (int j = 0; j < M; j++) // Végig iterálunk a 2. dimenzión (oszlop)
    {
        // Feltöltjük az aktuális index párhoz tartozó értéket egy random 1 és 10 közötti számmal
        matrix[i, j] = rnd.Next(0, 10);
        // Kiíratjuk az aktuális értéket
        Console.Write(matrix[i, j] + " ");
    }
    // Amikor a 2. dimenziót végig iteráltunk akkor beszúrunk egy új sort.
    // Ez azt jelenti, hogy befejeztünk egy sort feltöltését adatokkal.
    Console.WriteLine();
}

// Mátrix transzponáltjának kiszámítása (Új tömb létrehozás)
int[,] transzponalt = new int[M, N];

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        // Elem áthelyezése, azáltal, hogy felcseréljük az index párok sorrendjét.
        transzponalt[j, i] = matrix[i, j];
    }
}

// Transzponált mátrix kiírása
Console.WriteLine("\nTranszponált mátrix:");
// Az utolsó for ciklusban azért van felcserélve az iteráció sorrendje
// (kívül az M bejárás és belül az N bejárás),
// mert a transzponált mátrix sorait és oszlopait megcseréltük az eredeti mátrixhoz képest.
// Magyarázat:
//  Eredeti mátrix: Az eredeti mátrix mérete N×M,
//                  tehát a külső ciklus bejárja a sorokat (azaz az N-t),
//                  a belső pedig az oszlopokat (azaz az M-et).
//  Transzponált mátrix: A transzponálás azt jelenti, hogy a sorokat és oszlopokat felcseréljük.
//                       Így a transzponált mátrix mérete M×N, tehát most az eredeti oszlopok
//                       lesznek a sorok, és az eredeti sorok lesznek az oszlopok.
//  Ezért az utolsó for ciklusban:
//      Külső ciklus az M bejárására szolgál
//          (az eredeti oszlopok száma, ami most a transzponált mátrix sorainak felel meg).
//      Belső ciklus az N bejárására szolgál
//          (az eredeti sorok száma, ami most a transzponált mátrix oszlopainak felel meg).
for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        Console.Write(transzponalt[i, j] + " ");
    }
    Console.WriteLine();
}