/*
Készítsünk programot, amely elkéri a felhasználó nevét, majd név szerint köszönti őt.
*/
// Felhasználó nevének bekérése
Console.Write("Kérlek, add meg a neved: ");
string nev = Console.ReadLine();

// Név szerinti köszöntés
Console.WriteLine($"Üdvözöllek, {nev}!");

// Program vége
Console.WriteLine("Nyomj meg egy Enter billentyűt a kilépéshez...");
Console.ReadLine();