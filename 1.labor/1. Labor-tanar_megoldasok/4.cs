/*
Készítsünk programot, amely elkéri a felhasználó születési évét, ez alapján pedig kiszámítja és kiírja az
életkorát. A program írja ki azt is, hány éves lesz a felhasználó a következő évben.
*/

// Felhasználó születési évének bekérése
Console.Write("Kérlek, add meg a születési évedet: ");
int szuletesiEv = int.Parse(Console.ReadLine());

// Az aktuális év meghatározása
// Vagy egyszerűen: int aktualisEv = 2024; (Viszont az alábbi megoldás generikusabb és jövőre is működni fog. :) )
int aktualisEv = DateTime.Now.Year;

// Az életkor kiszámítása
int eletkor = aktualisEv - szuletesiEv;

// Eredmény kiíratása
Console.WriteLine($"Jelenleg {eletkor} éves vagy.");
Console.WriteLine($"A következő évben {eletkor + 1} éves leszel.");

// Program vége
Console.WriteLine("Nyomj meg egy Enter billentyűt a kilépéshez...");
Console.ReadLine();