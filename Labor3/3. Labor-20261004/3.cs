/*
Kérjünk el a felhasználótól előre megadott darabszámú szót, amelyeket tároljunk el egy tömbben.
Ezután kérjünk el a felhasználótól egy további szót, és válaszoljuk meg az alábbiakat.
• Benne van-e a gyűjteményben a megadott szó?
• Ha benne van, hol található először?
*/

// Szavak bekérése a felhasználótól
Console.Write("Add meg, hány szót szeretnél megadni: ");

// pozitív egész szám bekérése hiba kezeléssel
if (!int.TryParse(Console.ReadLine(), out int darabszam) || darabszam < 0)
{
    Console.WriteLine("HIBA: Pozitív egész számot kell megadni!");
    return;
}

// Szavak tömb létrehozása. A hossza megegyezik a szavak számával.
string[] szavak = new string[darabszam];

// Bekérjük az N darab szót.
for (int i = 0; i < darabszam; i++)
{
    Console.Write($"Add meg a(z) {i + 1}. szót: ");
    szavak[i] = Console.ReadLine();
}

// Keresendő szó bekérése
Console.Write("Adj meg egy keresendő szót: ");
string keresettSzo = Console.ReadLine();

// Szó keresése a tömbben for ciklussal
int index = -1; // Az értéke csak átmeneti a ciklusban felülírásra kerül.
for (int i = 0; i < szavak.Length; i++)
{
    if (szavak[i] == keresettSzo)
    {
        index = i;
        break; // Megáll, ha megtalálta az első előfordulást

        // Az alábbi megoldás is jó a feladat leírás alapján,
        // viszont ebben az esetben a for cikloson kívül nem fogjuk tudni
        // megállapítani, hogy a szót megtaláltuk-e és, ha igen melyik indexen.
        // Console.WriteLine($"A(z) \"{keresettSzo}\" szerepel a gyűjteményben, és először a(z) {i}. helyen található.");
        // break;
    }
}

/*
// Szó keresése a tömbben for ciklussal
int index = -1;
int szoSzamlalo = 0;
while (szoSzamlalo < szavak.Length)
{
    if (szavak[szoSzamlalo] == keresettSzo)
    {
        index = szoSzamlalo;
        break; // Megáll, ha megtalálta az első előfordulást
    }
    szoSzamlalo++;
}
*/

// Eredmény kiírása
if (index != -1)
{
    // A string-ben a "\" karakter egy escape-character.
    // Hint: https://www.w3schools.com/cs/cs_strings_chars.php
    Console.WriteLine($"A(z) \"{keresettSzo}\" szerepel a gyűjteményben, és először a(z) {index + 1}. helyen található.");
}
else
{
    Console.WriteLine($"A(z) \"{keresettSzo}\" nem található a gyűjteményben.");
}