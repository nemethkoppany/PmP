/*
Egy új kriptovaluta árfolyamának alakulását szimuláljuk. Jelölje az aktuális árfolyamot Pt (valós szám). A
kriptovaluta árfolyamát a következő órában a

Pt+1 = r × Pt + εt

képlettel modellezzük, ahol r egy adott paraméter, εt pedig egy véletlen valós szám a [−α, α] intervallumból.
Írjuk ki a képernyőre az árfolyam alakulását különböző r és α értékekkel a felhasználó által megadott számú
órára.

Egy a program által generált példa:

Add meg a kezdeti árfolyamot (P0): 100
Add meg az r paramétert (szorzó): 1.05
Add meg az α paramétert (véletlen intervallum határa): 2
Add meg az órák számát, ameddig szimulálni szeretnéd az árfolyamot: 5

Árfolyam alakulása:
0. óra: 100.00
1. óra: 105.97
2. óra: 111.33
3. óra: 117.98
4. óra: 124.68
5. óra: 130.21
*/

// Felhasználói bemenetek
Console.Write("Add meg a kezdeti árfolyamot (P0): ");
double initialPrice = double.Parse(Console.ReadLine());

Console.Write("Add meg az r paramétert (szorzó): ");
double r = double.Parse(Console.ReadLine());

Console.Write("Add meg az α paramétert (véletlen intervallum határa): ");
double alpha = double.Parse(Console.ReadLine());

Console.Write("Add meg az órák számát, ameddig szimulálni szeretnéd az árfolyamot: ");
int hours = int.Parse(Console.ReadLine());

Random random = new Random();
double currentPrice = initialPrice;

Console.WriteLine("\nÁrfolyam alakulása:");
Console.WriteLine($"0. óra: {currentPrice:F2}"); // Kezdeti árfolyam kiírása

// Szimuláció óránként
for (int t = 1; t <= hours; t++)
{
    /*
    A NextDouble() metódus alapértelmezésben egy 0.0 és 1.0 közötti valós számot generál,
    így a [−α, α] intervallumot nem tudjuk közvetlenül megadni neki.
    Azonban a NextDouble() eredményét egyszerűen átskálázhatjuk az [−α, α] intervallumra:
        Szorozzuk meg a NextDouble() értékét az intervallum szélességével (2 * α).
        Majd vonjunk le belőle α-t, hogy a tartomány [-α, α] legyen.

    Ha α=2:

    NextDouble() eredeti tartománya:  [0.0 -------------- 1.0]
                                       x 2α (α = 2)
                                       |
                                       V
    Skálázás után:                    [0.0 -------------- 4.0]
                                       |
                                      - α
                                       |
                                       V
    Eltolás után:                     [-2.0 -------------- 2.0]
    */
    // Véletlen szám generálása [-α, α] intervallumból
    double epsilon = (random.NextDouble() * 2 * alpha) - alpha;

    // Következő árfolyam kiszámítása
    currentPrice = r * currentPrice + epsilon;

    // Árfolyam kiírása az aktuális órában
    Console.WriteLine($"{t}. óra: {currentPrice:F2}");
}
