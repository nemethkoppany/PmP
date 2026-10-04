/*
Készítsünk algoritmust, amely egy N ×M-es mátrix elemeit az óramutató járásának megfelelően K ×90◦-kal
„elforgatja”, ahol K egész szám. Két példát mutatunk a K = 1 esetre.

Példa:

1 2 3
4 5 6
7 8 9
  ↓ 
4 1 2
7 5 3
8 9 6

1  2  3  4
5  6  7  8
9  10 11 12
13 14 15 16
    ↓ 
5  1  2  3
9  10 6  4
13 11 7  8
14 15 16 12
*/

// 2 dimenziós tömb létrehozása random számokkal.
int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

int N = matrix.GetLength(0);
int M = matrix.GetLength(1);

Console.WriteLine($"Eredeti {N} x {M} mátrix:");
// Beágyazott ciklus!
for (int i = 0; i < N; i++) // Végig iterálunk az 1. dimenzión (sor)
{
    for (int j = 0; j < M; j++) // Végig iterálunk a 2. dimenzión (oszlop)
    {
        // Kiíratjuk az aktuális értéket
        Console.Write(matrix[i, j] + "\t");
    }
    // Amikor a 2. dimenziót végig iteráltunk akkor beszúrunk egy új sort.
    // Ez azt jelenti, hogy befejeztünk egy sort feltöltését adatokkal.
    Console.WriteLine();
}

Console.Write("\nAdd meg, hányszor 90 fokkal forgassuk a mátrixot: ");

// pozitív egész szám bekérése hiba kezeléssel
if (!int.TryParse(Console.ReadLine(), out int K) || K < 0)
{
    Console.WriteLine("HIBA: Pozitív egész számot kell megadni!");
    return;
}

int rows = matrix.GetLength(0); // 1. dimenzió hossza (sorok)
int cols = matrix.GetLength(1); // 2. dimenzió hossza (oszlopok)

// A forgatásokat 90 fokban kell értelmezni
K = K % 4; // Max 3 forgatásra van szükség (4 forgatás == 360 fok, nincs értelme)

// Forgatás
for (int k = 0; k < K; k++)
{
    // Új tömb létrehozása a forgatott mátrixnak.
    int[,] rotated = new int[cols, rows];

    for (int i = 0; i < rows; i++) // Végig iterálunk a sorokon.
    {
        for (int j = 0; j < cols; j++) // Végig iterálunk az oszlopokon.
        {
            // matrix[i, j]: Ez az eredeti mátrix i-edik sorának és j-edik oszlopának az eleme.
            // rotated[j, rows - 1 - i]: Ez az új, elforgatott mátrix j-edik sorának és a
            // rows−1−i-edik oszlopának az eleme. Ez a kifejezés biztosítja, hogy a forgatás során az elemek megfelelő helyre kerüljenek.
            // Értelmezés:
            //      Kicseréli a pozíciót: Az i-edik sor j-edik elemét az elforgatott mátrixban úgy helyezi el,
            //                            hogy az új pozícióban tükrözze a 90 fokos elforgatást.
            //      Számítás: A rows−1−i kifejezés biztosítja,
            //                hogy a forgatás következtében az új oszlopok megfelelő helyre kerüljenek
            //                (az aljáról felfelé haladva).
            rotated[j, rows - 1 - i] = matrix[i, j];
        }
    }

    // Mátrix frissítése
    matrix = rotated;

    // Sorok és oszlopok cseréje
    int temp = rows;
    rows = cols;
    cols = temp;
}

Console.WriteLine($"\nForgatott {N} x {M} mátrix:");

// Eredmény kiírása
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
