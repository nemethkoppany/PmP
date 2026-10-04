/*
Töltsünk fel egy egydimenziós tömböt megadott számú véletlen értékkel, majd valósítsuk meg az alábbi
műveleteket, majd oldjuk meg a feladatot listával is.
• Válogassuk ki a gyűjtemény minden második elemét egy új gyűjteménybe.
• Fordítsuk meg a gyűjtemény elemeinek sorrendjét.
• Rendezzük a lehető legkisebb négyzetes mátrixba a gyűjtemény elemeit (az esetlegesen üresen maradó
értékek helyére nulla kerüljön).

Négyzetes mátrix:

A legkisebb négyzetes mátrix az a négyzetes mátrix,
amelynek sorai és oszlopai száma megegyezik,
és amely elegendő helyet biztosít a megadott elemek tárolására.
Az elemeken kívül a mátrixban üres helyeket 0-kkal tölthetjük ki,
ha a megadott elemek száma kevesebb, mint a mátrix maximális mérete.

Például, ha 10 elemet szeretnénk tárolni, a legkisebb négyzetes mátrix 4x4-es lesz,
mivel 4 sor és 4 oszlop 16 helyet biztosít, ami elegendő a 10 elemhez (a fennmaradó 6 helyet 0-kal töltjük ki).
*/

Random rnd = new Random();
int n = 16; // 16 elemű tömböt hozunk létre
int[] array = new int[n];

// Véletlen értékek feltöltése
for (int i = 0; i < n; i++)
{
    array[i] = rnd.Next(1, 101); // 1 és 100 közötti véletlen számok
}

// Minden második elem kiválasztása
int newSize = (n + 1) / 2; // Kerekítjük felfelé, ha n páratlan
int[] secondElements = new int[newSize];

// Dupla feltételes for ciklus:
//      i-t és j-t is 0-val inicializáljuk
//      A ciklus addig fut amíg i kisebb, mint n
//      i-t 2-vel növeljük minden ciklustan, míg j-t 1-el inkrementáljuk.
for (int i = 0, j = 0; i < n; i += 2, j++)
{
    secondElements[j] = array[i];
}

// Rendezzük a legkisebb négyzetes mátrixba
// (int): A kerekített értéket egész számra (int) konvertálja, mivel a mátrix mérete egész szám kell, hogy legyen.
// Math.Ceiling(...): A kapott négyzetgyök értéket a legközelebbi egész számra kerekíti felfelé.
// Hint: https://learn.microsoft.com/en-us/dotnet/api/system.math.ceiling?view=net-8.0
// Pl.:
// Ha n = 10, akkor:
// Math.Sqrt(10) ≈ 3.16
// Math.Ceiling(3.16) = 4
// Tehát matrixSize értéke 4 lesz, így egy 4x4-es mátrixot kapunk.
int matrixSize = (int)Math.Ceiling(Math.Sqrt(n));
int[,] matrix = new int[matrixSize, matrixSize];

for (int i = 0; i < n; i++)
{
    int row = i / matrixSize;
    int col = i % matrixSize;
    matrix[row, col] = array[i];
}

// Eredmények kiírása
Console.WriteLine("Eredeti tömb:");
Console.WriteLine(string.Join(", ", array));

Console.WriteLine("\nMinden második elem:");
Console.WriteLine(string.Join(", ", secondElements));

// Eredeti tömb fordítása
// Hint: https://learn.microsoft.com/en-us/dotnet/api/system.array.reverse?view=net-8.0
Array.Reverse(array);

Console.WriteLine("\nFordított tömb:");
Console.WriteLine(string.Join(", ", array));

Console.WriteLine("\nNégyzetes mátrix:");
for (int i = 0; i < matrixSize; i++)
{
    for (int j = 0; j < matrixSize; j++)
    {
        // A "\t" karakter a string-be beszúr egy TAB-ot (Behúzás)
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}