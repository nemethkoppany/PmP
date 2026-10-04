/*
Kérjünk el a felhasználótól egy N pozitív egész értéket, és adjuk hozzá egy listához első elemként. Vegyük
a lista utoljára hozzáadott elemét, legyen ez K. Ha K páros, adjuk hozzá a listához K felét, ha páratlan, akkor
3K + 1-et. Addig ismételjük az előbbieket, amíg 1-et nem kapunk eredményül.

Kövessük nyomon a kiszámított érték és a lista állapotának változását hibakereső (debug) módban. Próbáljuk
meg hibakeresés közben módosítani az aktuálisan kiszámított értéket.

A program által generált kimenet:

Kérjük, adjon meg egy pozitív egész számot: 3
Első elem a listában: 3
K: 10, Lista: [3, 10]
K: 5, Lista: [3, 10, 5]
K: 16, Lista: [3, 10, 5, 16]
K: 8, Lista: [3, 10, 5, 16, 8]
K: 4, Lista: [3, 10, 5, 16, 8, 4]
K: 2, Lista: [3, 10, 5, 16, 8, 4, 2]
K: 1, Lista: [3, 10, 5, 16, 8, 4, 2, 1]
A lista végső állapota: [3, 10, 5, 16, 8, 4, 2, 1]

*/

List<int> lista = new List<int>();

// Felhasználótól kérjük az első pozitív egész értéket
Console.Write("Kérjük, adjon meg egy pozitív egész számot: ");
if (!int.TryParse(Console.ReadLine(), out int N) || N < 0)
{
    Console.WriteLine("HIBA: Pozitív egész számot kell megadni!");
    return;
}

// Az első elem hozzáadása a listához
lista.Add(N);
Console.WriteLine($"Első elem a listában: {lista[0]}");

int K = N;

// A számítások folytatása a megadott szabályok szerint
while (K != 1)
{
    if (K % 2 == 0) // K páros
    {
        K = K / 2; // K egyenlő az aktuális értékének a felével
    }
    else // K páratlan
    {
        K = 3 * K + 1; // K egyenlő az aktuális értékének a háromszorosával + 1
    }

    // K és a lista állapotának kiírása
    lista.Add(K);
    // A string.Join metódus egy lista elemeit összefűzi string-gé egy megadott szeparátor alapján
    // jelen esetben ", " szeparátor alapján. [1,2,3] -> "1, 2, 3"
    // Hint: https://learn.microsoft.com/en-us/dotnet/api/system.string.join?view=net-8.0
    Console.WriteLine($"K: {K}, Lista: [{string.Join(", ", lista)}]");
}

Console.WriteLine($"A lista végső állapota: [{string.Join(", ", lista)}]");