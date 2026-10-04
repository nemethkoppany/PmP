/*
Tároljuk egy változóban a felhasználó jelszavát.
Addig kérjük el tőle a jelszót a parancssorról, amíg az nem
egyezik az eltárolttal. Módosítsuk úgy a programot, hogy a
felhasználó három sikertelen próbálkozás után kapjon
hibaüzenetet.
*/

string storedPassword = "TitkosJelszo";  // Az eltárolt jelszó
string inputPassword = "";

// While (és do-while) loop dokumentáció:
//   - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements
while (inputPassword != storedPassword)
{
    Console.Write("Add meg a jelszót: ");
    inputPassword = Console.ReadLine();
}

/*
// Megoldás do-while ciklussal
do
{
    Console.Write("Add meg a jelszót: ");
    inputPassword = Console.ReadLine();
}
while (inputPassword != storedPassword);
*/

Console.WriteLine("Sikeres bejelentkezés.");