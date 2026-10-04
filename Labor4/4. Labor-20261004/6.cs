/*
Készítsünk programot Neptun-kódhoz hasonló szöveg generálására. Egy Neptun-kód pontosan hat karak-
terből áll, véletlenszerű betűkből és számokból, de az első karakter mindig betű.
Számoljuk meg, hogy hányadik véletlenszerűen generált Neptun-kód egyezik meg a saját azonosítónkkal.
*/

// Saját azonosító beolvasása
Console.Write("Add meg a saját Neptun-kódodat: ");
string sajatNeptunKod = Console.ReadLine().ToUpper();

// A felhasználó által beírt Neptunkód ellenörzése
//     - 6 karakter hosszú
//     - Az első karakter betű (nem szám)
if (sajatNeptunKod.Length != 6 || !char.IsLetter(sajatNeptunKod[0]))
{
    Console.WriteLine("Érvénytelen Neptun-kód! A Neptun-kódnak 6 karakter hosszúnak kell lenni és az első karakter betű");
    return;
}

// Végig iterálunk a Neptun-kód karakterein
foreach (char c in sajatNeptunKod)
{
    if (!char.IsLetterOrDigit(c)) // Vagy if(!char.IsLetter(c) || !char.IsDigit(c)){...}
    {
        Console.WriteLine("Érvénytelen Neptun-kód! A Neptun-kód csak betűket és számokat tartalmazhat.");
        return;
    }
}

// Random objektum létrehozása.
Random random = new Random();
int probalkozasokSzama = 0;  // Számláló a próbálkozásokhoz.
string generaltNeptunKod; // A generált Neptun-kód ebben a változóban lesz tárolva.

// Generálás és összehasonlítás
do
{
    char[] neptunKod = new char[6];  // 6 elem hosszúságú char típusú tömb
    string betuk = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    string szamok = "0123456789";

    // Az első karakter mindig (random) betű
    neptunKod[0] = betuk[random.Next(betuk.Length)];

    // A többi karakter lehet betű vagy szám (Az utolsó 5 karakter meghatározása)
    for (int i = 1; i < 6; i++)
    {
        if (random.Next(2) == 0) // 50% eséllyel betű vagy szám (Mivel a random 0-t vagy 1-et fog visszaadni)
        {
            neptunKod[i] = betuk[random.Next(betuk.Length)];
        }
        else
        {
            neptunKod[i] = szamok[random.Next(szamok.Length)];
        }
    }

    // A char tömböt átkonvertáljuk string típussá.
    generaltNeptunKod = new string(neptunKod);
    // Inkrementáljuk a próbálkozások számát.
    probalkozasokSzama++;

    // Kiírja minden 10000. futásnál, hogy hol tart a számláló
    /*
    if (probalkozasokSzama % 10000 == 0)
    {
        Console.WriteLine($"{probalkozasokSzama}. próbálkozás lefutott. A generált Neptun-kód: {generaltNeptunKod}!");
    }
    */

    // Addig maradunk a ciklusban amíg a random generált Neptun-kód nem egyezik meg a sajátunkal.
} while (generaltNeptunKod != sajatNeptunKod);

// Eredmény kiírása
Console.WriteLine($"A(z) {probalkozasokSzama}. generált Neptun-kód egyezett meg a saját kódoddal: {generaltNeptunKod}");
