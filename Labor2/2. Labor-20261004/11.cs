/*
Készítsünk egyszerű félkarú rabló játékot. A játék elején a játékos 100 kredittel rendelkezik, a tét alapesetben
1 kredit. A Spacebar billentyű lenyomásakor a játék három véletlen számjegyet pörget. Két egyforma szám esetén
a tét 10-szeresét, három egyforma esetén a tét 50-szeresét nyeri a felhasználó. Pörgetés előtt a tétet a Fel és Le
kurzorbillentyűkkel lehet módosítani. A játék véget ér Escape nyomáskor, vagy ha a játékosnak elfogy a kreditje.
*/

int credits = 100; // Kezdő kreditek
int bet = 1; // Alaptét

// Random objektum létrehozása.
// Ezen objektum metódusával fogunk véletlen számot generálni.
// https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-8.0
Random random = new Random();

// Egy ConsoleKey típusú key változó létrehozása.
// A lenyomott billentyűk beolvasására fogjuk használni.
ConsoleKey key;

Console.WriteLine("Félkarú rabló játék!");
Console.WriteLine("Spacebar: Pörgetés, Fel/Le nyilak: Tét növelése/csökkentése, Escape: Kilépés");
Console.WriteLine($"Kezdő kreditek: {credits}");

// Amíg a kreditek el nem fogynak
while (credits > 0)
{
    Console.WriteLine($"Jelenlegi tét: {bet} kredit | Kreditek: {credits}");
    key = Console.ReadKey(true).Key; // Vár billentyűlenyomásra

    if (key == ConsoleKey.Escape) // ESC esetén kilépünk a játékból.
    {
        Console.WriteLine("Kilépés a játékból.");
        break;
    }

    // Fel billentyű és az alaptét és kredit arányának vizsgálata (Több kredit, mint alaptét)
    if (key == ConsoleKey.UpArrow && bet < credits)
    {
        bet++; // Alaptét növelése
        Console.WriteLine($"Tét növelve: {bet} kredit");
    }
    // Le billentyű és az alaptét vizsgálata (Nem lehet kevesebb, mint 1)
    else if (key == ConsoleKey.DownArrow && bet > 1)
    {
        bet--; // Alaptét csökkentése
        Console.WriteLine($"Tét csökkentve: {bet} kredit");
    }
    // Space billentyű lenyomása
    else if (key == ConsoleKey.Spacebar)
    {
        // Levonjuk a tétet a kreditből
        credits -= bet;

        // Pörgetés: három véletlenszám 0-9 között
        int reel1 = random.Next(0, 10);
        int reel2 = random.Next(0, 10);
        int reel3 = random.Next(0, 10);

        Console.WriteLine($"Pörgetés eredménye: {reel1} {reel2} {reel3}");

        // Nyeremény ellenőrzése
        if (reel1 == reel2 && reel2 == reel3)
        {
            int win = bet * 50; // Tétet megszorozzuk 50-el
            credits += win; // A nyereményt hozzáadjuk a kreditekhez
            Console.WriteLine($"Három egyforma! Nyeremény: {win} kredit!");
        }
        else if (reel1 == reel2 || reel2 == reel3 || reel1 == reel3)
        {
            int win = bet * 10; // Tétet megszorozzuk 10-el
            credits += win; // A nyereményt hozzáadjuk a kreditekhez
            Console.WriteLine($"Két egyforma! Nyeremény: {win} kredit!");
        }
        else
        {
            Console.WriteLine("Nincs nyeremény.");
        }

        // Ellenőrizzük, hogy elfogyott-e a kredit
        if (credits <= 0)
        {
            Console.WriteLine("Elfogytak a kreditjeid! Játék vége.");
            break;
        }
    }

    Thread.Sleep(100); // Egy kis szünet a következő kör előtt
}