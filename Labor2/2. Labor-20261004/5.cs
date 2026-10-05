/*
Írjunk programot, amelynek kezdetén adott egy pozitív egész szám, a „gondolt szám”.
A felhasználónak kikell találnia, hogy mi a gondolt szám.
Ehhez a felhasználó megadhat számokat, melyekről a program megmondja,
hogy a gondolt számnál nagyobbak vagy kisebbek-e.
A program akkor ér véget, ha a felhasználó kitalálta a gondolt
számot. A program jelenítse meg a felhasználó próbálkozásainak számát is.
*/

Random random = new Random();

// Egy véletlen "gondolt szám" 1 és 100 között
int thoughtNumber = random.Next(1, 101);

int guess = 0; // A felhasználó által gondolt szám
int attempts = 0; // Próbálkozások száma

Console.WriteLine("Gondoltam egy számra 1 és 100 között. Találd ki!");

do
{
    Console.Write("Add meg a tippedet: ");
    guess = int.Parse(Console.ReadLine());

    // Próbálkozások száma
    attempts++;

    // Ha a gondolt (random) szám nagyobb.
    if (guess < thoughtNumber)
    {
        Console.WriteLine("A gondolt szám nagyobb.");
    }
    // Ha a gondolt (random) szám kisebb.
    else if (guess > thoughtNumber)
    {
        Console.WriteLine("A gondolt szám kisebb.");
    }
    // Ha a gondolt (random) szám megegyezik a felhasználó által gondolt számra.
    else
    {
        Console.WriteLine($"Gratulálok! Kitaláltad a számot: {thoughtNumber}");
        Console.WriteLine($"Próbálkozások száma: {attempts}");
    }
// A ciklus addig fut amíg a gép által gondolt szám nem egyezik meg a felhasználó által gondolt számmal.
} while (guess != thoughtNumber);
