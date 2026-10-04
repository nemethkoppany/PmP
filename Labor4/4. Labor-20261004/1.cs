/*
Írjunk programot, amely meghatározza egy szövegben a betűk, a számjegyek és a magánhangzók számát
kategóriánként.
*/

Console.Write("Adj meg egy szöveget: ");
// Kisbetűssé alakítjuk a felhasználó által beírt szöveget.
string szoveg = Console.ReadLine().ToLower();

// Változók amik a különböző karaktereket számlálják a kapott szövegben.
int betukSzama = 0;
int szamjegyekSzama = 0;
int maganhangzokSzama = 0;

string maganhangzok = "aeiouáéíóöőúüű"; // Magánhangzók

// Végig iterálunk a kapott szöveg karakterein
foreach (char karakter in szoveg)
{
    // Ha az aktuális karakter betű
    if (char.IsLetter(karakter))
    {
        betukSzama++;
        // Ha az aktuális karakter magánhangzó
        if (maganhangzok.Contains(karakter))
        {
            maganhangzokSzama++;
        }
    }
    // Ha az aktuális karakter szám.
    // Azért nem simán "else" ág van, mert előfordulhatnak speciális karakterek is
    // amiket "ki kell szűrni".
    else if (char.IsDigit(karakter))
    {
        szamjegyekSzama++;
    }
}

// Eredmények kiírása
Console.WriteLine($"Betűk száma: {betukSzama}");
Console.WriteLine($"Számjegyek száma: {szamjegyekSzama}");
Console.WriteLine($"Magánhangzók száma: {maganhangzokSzama}");