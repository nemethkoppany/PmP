/*
Kérjünk el a felhasználótól egy másodpercben megadott időtartamot, majd írjuk ki azt perc:másodperc formátumban.
Példa
Az időtartam másodpercben: 123
Az időtartam formázva: 2:03
*/

// Időtartam bekérése másodpercben
Console.Write("Kérlek, add meg az időtartamot másodpercben: ");
int masodperc = int.Parse(Console.ReadLine());

// Perc és másodperc kiszámítása
int percek = masodperc / 60; // -> Osztás
int maradekMasodperc = masodperc % 60; // -> Modulóképzés

// Az időtartam kiírása perc:másodperc formátumban
Console.WriteLine($"Az időtartam formázva: {percek}:{maradekMasodperc:D2}");

// Ha a percet is formázni szeretnénk (2 helyi érték)
// Console.WriteLine($"Az időtartam formázva: {percek:D2}:{maradekMasodperc:D2}");

// Program vége
Console.WriteLine("Nyomj meg egy Enter billentyűt a kilépéshez...");
Console.ReadLine();