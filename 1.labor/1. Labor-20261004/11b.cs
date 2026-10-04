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

// Szám ellenőrzése (Int típussá konvertálható valamint a szám 0-9 között van)
if (int.TryParse(input, out int szam) && szam >= 0 && szam <= 9)
{
    // Ha a szám megegyezik a switch ágának valamelyikáóével, akkor az eredményét a szovegesSzam változóba tölti.
    string szovegesSzam = szam switch
    {
        0 => "nulla",
        1 => "egy",
        2 => "kettő",
        3 => "három",
        4 => "négy",
        5 => "öt",
        6 => "hat",
        7 => "hét",
        8 => "nyolc",
        9 => "kilenc",
        _ => throw new ArgumentOutOfRangeException()  // Kivétel (Exception) dobása hiba esetén (Egyik ág sem érvényesül)
    };
    Console.WriteLine($"Az általad megadott szám: {szovegesSzam}");
}
else
{
    Console.WriteLine("Hiba: Kérlek, adj meg egy számot 0 és 9 között.");
}

// Program vége
Console.WriteLine("Nyomj meg egy Enter billentyűt a kilépéshez...");
Console.ReadLine();