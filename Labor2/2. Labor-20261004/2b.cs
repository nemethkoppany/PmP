/*
Módosítsuk úgy a programot, hogy a felhasználó
három sikertelen próbálkozás után kapjon hibaüzenetet.
*/

string storedPassword = "TitkosJelszo";  // Az eltárolt jelszó
string inputPassword; // A felhasználó által megadott jelszó
int attempts = 0; // A felhasználó általi próbálkozások
int maxAttempts = 3; // A maximum megengedett próbálkozások száma

// Amíg a felhasználói próbálkozások száma meg nem haladja a maximum
// próbálkozások számát.
while (attempts < maxAttempts)
{
    Console.Write("Add meg a jelszót: ");
    inputPassword = Console.ReadLine();

    // Ha a felhasználó és az eltárolt jelszó megegyezik.
    if (inputPassword == storedPassword)
    {
        Console.WriteLine("Sikeres bejelentkezés.");
        return;
    }

    // Növeljük a felhasználó próbálkozásainak a számát (inkrementálás)
    // Ugyanaz, mint a "attempts = attempts + 1" kifejzés
    attempts++;
    Console.WriteLine($"Rossz jelszó. Hátralévő próbálkozások száma: {maxAttempts - attempts}");
}

Console.WriteLine("Hiba: Három sikertelen próbálkozás.");