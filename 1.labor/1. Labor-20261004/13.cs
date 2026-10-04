/*
Adott egy V térfogatú tartály, amit két csővezetéken keresztül töltünk fel fel. Ismerjük a vezetékekben a
térfogatáramot (az egy óra alatt átfolyó térfogatot). A két vezetéket egyszerre nyitjuk meg, majd T óráig folyni
hagyjuk. Adjuk meg, hogy az időtartam végén mennyire telt meg a tartály.

Példa
V = 1000
R1 = 100
R2 = 120
T = 3
--> A tartály 66%-ban lesz tele.

Példa
V = 100
R1 = 100
R2 = 100
T = 2.5
--> A tartály 400 m3-rel lesz túltöltve.
*/

// Felhasználótól adatok bekérése
Console.Write("Adja meg a tartály térfogatát (V): ");
double V = double.Parse(Console.ReadLine());

Console.Write("Adja meg az első cső térfogatáramát (R1): ");
double R1 = double.Parse(Console.ReadLine());

Console.Write("Adja meg a második cső térfogatáramát (R2): ");
double R2 = double.Parse(Console.ReadLine());

Console.Write("Adja meg a töltési időt (T): ");
double T = double.Parse(Console.ReadLine());

// Töltött térfogat számítása
double toltottTérfogat = (R1 + R2) * T;

// Töltöttség arány és túltöltés kiszámítása
double toltottSzakasz = (toltottTérfogat / V) * 100;
double tulterheles = toltottTérfogat - V;

if (toltottTérfogat <= V)
{
    Console.WriteLine($"A tartály {toltottSzakasz:F2}%-ban lesz tele.");
}
else
{
    Console.WriteLine($"A tartály {tulterheles:F2} m³-rel lesz túltöltve.");
}

// Program vége
Console.WriteLine("Nyomj meg egy Enter billentyűt a kilépéshez...");
Console.ReadLine();