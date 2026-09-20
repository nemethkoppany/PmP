/*
Kérjünk egy a felhasználótól egy 0 és 9 közötti értéket, majd írjuk ki a számot szövegesen. Ha a tartományon
kívüli értéket ad meg, tájékoztassuk hibaüzenettel.
Példa
Adj meg egy számot: 9
Az általad megadott szám: kilenc
*/

// Felhasználótól szám bekérése
Console.Write("Adj meg egy számot (0-9): ");
string input = Console.ReadLine();

// Szám szöveges formátumának meghatározása
string szamSzovegessen = "";

// Szám ellenőrzése és szöveges formában való átkonvertálás
if (input == "0")
{
    szamSzovegessen = "nulla";
}
else if (input == "1")
{
    szamSzovegessen = "egy";
}
else if (input == "2")
{
    szamSzovegessen = "kettő";
}
else if (input == "3")
{
    szamSzovegessen = "három";
}
else if (input == "4")
{
    szamSzovegessen = "négy";
}
else if (input == "5")
{
    szamSzovegessen = "öt";
}
else if (input == "6")
{
    szamSzovegessen = "hat";
}
else if (input == "7")
{
    szamSzovegessen = "hét";
}
else if (input == "8")
{
    szamSzovegessen = "nyolc";
}
else if (input == "9")
{
    szamSzovegessen = "kilenc";
}
else
{
    Console.WriteLine("Hiba: Kérlek, adj meg egy számot 0 és 9 között.");
    return;
}

// Szöveges szám kiírása
Console.WriteLine($"Az általad megadott szám: {szamSzovegessen}");

// Program vége
Console.WriteLine("Nyomj meg egy Enter billentyűt a kilépéshez...");
Console.ReadLine();