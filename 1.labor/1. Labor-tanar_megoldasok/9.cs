/*
Kérjünk el a felhasználótól kettő számot és egy műveleti jelet, majd írjuk ki a képernyőre az adott művelet
eredményét a két szám között elvégezve.
Példa
Add meg az első számot: 3
Add meg a második számot: 7
Add meg a műveletet: *
3 * 7 = 21
*/

// Első szám bekérése
Console.Write("Add meg az első számot: ");
double szam1 = double.Parse(Console.ReadLine());

// Második szám bekérése
Console.Write("\nAdd meg a második számot: ");
double szam2 = double.Parse(Console.ReadLine());

// Műveleti jel bekérése
Console.Write("\nAdd meg a műveletet (+, -, *, /): ");
string muvelet = Console.ReadLine();

// Művelet végrehajtása és eredmény kiírása
double eredmeny = 0;
bool szamitasSikeres = true;

switch (muvelet)
{
    case "+":
        eredmeny = szam1 + szam2;
        break;
    case "-":
        eredmeny = szam1 - szam2;
        break;
    case "*":
        eredmeny = szam1 * szam2;
        break;
    case "/":
        if (szam2 != 0)
        {
            eredmeny = szam1 / szam2;
        }
        else
        {
            Console.WriteLine("Hiba: Nullával való osztás nem megengedett.");
            szamitasSikeres = false;
        }
        break;
    default:
        Console.WriteLine("Hiba: Érvénytelen művelet.");
        szamitasSikeres = false;
        break;
}

if (szamitasSikeres)
{
    Console.WriteLine($"{szam1} {muvelet} {szam2} = {eredmeny}");
}

// Program vége
Console.WriteLine("Nyomj meg egy Enter billentyűt a kilépéshez...");
Console.ReadLine();