/*
Kérjük el a felhasználótól a jelszavát, majd kérjük el még egyszer megerősítésképp. Ha egyezik a két
megadott jelszó, nyugtázzuk egy zöld színnel kiírt üzenettel, ellenkező esetben jelenítsünk meg egy piros színű
hibaüzenetet.
*/

// Első jelszó bekérése
Console.Write("Kérlek, add meg a jelszavadat: ");
string jelszo1 = Console.ReadLine();

// Második jelszó (megerősítés) bekérése
Console.Write("\nKérlek, add meg újra a jelszavadat: ");
string jelszo2 = Console.ReadLine();

// Jelszavak összehasonlítása
if (jelszo1 == jelszo2)
{
    // Zöld szín beállítása és sikeres üzenet
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("A jelszavak egyeznek!");
}
// Ha a jelszavak nem egyeznek meg
else
{
    // Piros szín beállítása és hibaüzenet
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Hiba: A megadott jelszavak nem egyeznek!");
}

// Szín visszaállítása az alapértelmezett színre
Console.ResetColor();

// Program vége
Console.WriteLine("Nyomj meg egy Enter billentyűt a kilépéshez...");
Console.ReadLine();