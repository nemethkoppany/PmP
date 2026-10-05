/*
Írjunk programot, amely meghatározza, hogy egy szöveg palindrom szöveg-e, vagyis hogy előre olvasva
ugyanazt adja-e, mint visszafelé.

Példa:
A „Géza kék az ég.”, az „Indul a görög aludni.” vagy a „Rád rohan a hordár.” szövegek palindrom szövegek.
*/

Console.Write("Adj meg egy szöveget: ");
string szoveg = Console.ReadLine();
string tisztitottSzoveg = "";

// A megadott szövegen végig iterálunk és megvizsgáljuk a karaktereket.
foreach (char karakter in szoveg)
{
    if (char.IsDigit(karakter) || char.IsLetter(karakter))
    // A "IsLetterOrDigit" metódus ugyanezt csinálja (https://learn.microsoft.com/en-us/dotnet/api/system.char.isletterordigit?view=net-8.0)
    // if (char.IsLetterOrDigit(karakter))
    {
        // Csak az alfanumerikus karakterek megtartása és kisbetűssé alakítás.
        // A kisbetűssé konvertált karaktert hozzáfűzzük a változóhoz.
        tisztitottSzoveg += char.ToLower(karakter);
    }
}

// Visszafelé olvasott szöveg összeállítása
string visszafeleSzoveg = "";
for (int i = tisztitottSzoveg.Length - 1; i >= 0; i--) // A tömb végétől iterálunk visszafelé
{
    visszafeleSzoveg += tisztitottSzoveg[i];
}

// Eredeti és fordított szöveg összehasonlítása
if (tisztitottSzoveg == visszafeleSzoveg)
{
    Console.WriteLine("A szöveg palindrom.");
}
else
{
    Console.WriteLine("A szöveg nem palindrom.");
}