/*
Készítsünk egy alkalmazást, amely eldönti,
hogy N játékos közül ki kezdjen.
Minden játékosnál az Enter leütésére dobjunk
egy véletlen számot 1 és 6 között,
majd ha az nem hatos, ugorjunk a következő játékosra.
Ha körbeértünk, a folyamat induljon újra, egészen addig,
amíg valaki hatost nem dob.
*/

// Random objektum létrehozása.
// Ezen objektum metódusával fogunk véletlen számot generálni.
// https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-8.0
Random random = new Random();

Console.Write("Add meg a játékosok számát: ");
int numberOfPlayers = int.Parse(Console.ReadLine());

// Minimum 1 játékosnak kell lenni.
if (numberOfPlayers < 1)
{
    Console.WriteLine("A játékosok száma legalább 1 kell legyen.");
    return;
}

int currentPlayer = 1; // A jelenleg dobó játékos
bool isGameOn = true; // Folyik-e még a játék (Igen/Nem)

while (isGameOn)
{
    Console.WriteLine($"Játékos {currentPlayer}: Nyomd meg az Enter-t a dobáshoz...");
    Console.ReadLine(); // Várakozás az Enter billentyű lenyomására

    int diceRoll = random.Next(1, 7); // Véletlen szám 1 és 6 között

    Console.WriteLine($"Játékos {currentPlayer} dobott: {diceRoll}");

    // Ha a játékos hatost dobott, akkor a játék befejeződik (isGameOn = false;)
    if (diceRoll == 6)
    {
        Console.WriteLine($"Játékos {currentPlayer} kezd!");
        isGameOn = false;
    }

    // Az alábbi sorok helyett a kövezkező kód is használható a következő játékos számolásához:
    // currentPlayer = (currentPlayer + 1) % numberOfPlayers; // Következő játékos

    currentPlayer = currentPlayer % numberOfPlayers; // Következő játékos

    // Következő játékos (Szükséges, mert a játékosok nem nullától indexelődnek)
    currentPlayer++;

    // Ha a fent kikalkulált játékosszám több, mint a valós játékosok száma
    // akkor a kör újra indul, tehát: currentPlayer = 1
    if (currentPlayer > numberOfPlayers)
    {
        currentPlayer = 1;
    }
}