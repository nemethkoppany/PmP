Random rnd = new Random();
int n = 16; // Példa: 16 elem
List<int> list = new List<int>();

// Véletlen értékek feltöltése
for (int i = 0; i < n; i++)
{
    list.Add(rnd.Next(1, 101)); // 1 és 100 közötti véletlen számok
}

// Minden második elem kiválasztása
List<int> secondElements = new List<int>();
for (int i = 0; i < list.Count; i += 2)
{
    secondElements.Add(list[i]);
}

// Rendezzük a legkisebb négyzetes mátrixba
int matrixSize = (int)Math.Ceiling(Math.Sqrt(n));
int[,] matrix = new int[matrixSize, matrixSize];

for (int i = 0; i < list.Count; i++)
{
    int row = i / matrixSize;
    int col = i % matrixSize;
    matrix[row, col] = list[i];
}

// Eredmények kiírása
Console.WriteLine("Eredeti lista:");
Console.WriteLine(string.Join(", ", list));

Console.WriteLine("\nMinden második elem:");
Console.WriteLine(string.Join(", ", secondElements));

// Eredeti lista fordítása
list.Reverse();

Console.WriteLine("\nFordított lista:");
Console.WriteLine(string.Join(", ", list));

Console.WriteLine("\nNégyzetes mátrix:");
for (int i = 0; i < matrixSize; i++)
{
    for (int j = 0; j < matrixSize; j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
