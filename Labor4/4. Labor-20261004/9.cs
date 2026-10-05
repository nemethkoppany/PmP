/*
Készítsünk programot, amely egy szöveg formájában adott zárójel-sorozatról eldönti, hogy az szabályos-e.
Egy ilyen sorozatot szabályosnak nevezünk, ha benne a zárójelek párosíthatóak úgy, hogy minden párban legyen
egy összetartozó kezdő- és egy végzárójel.
Példa
A [()][()()]() például szabályos zárójelezés, de például a [(]) nem az, mivel a kerek nyitó zárójel
végzárójel párja szögletes zárójelen kívül található.
*/

Console.WriteLine("Adj meg egy zárójel-sorozatot:");
string input = Console.ReadLine();

// A zárójelek veremének létrehozása
Stack<char> verem = new Stack<char>();
bool szabalyos = true; // Feltételezzük, hogy szabályos

foreach (char karakter in input)
{
    // Ha nyitó zárójelet találunk, hozzáadjuk a veremhez
    if (karakter == '(' || karakter == '[')
    {
        verem.Push(karakter);
    }
    // Ha záró zárójelet találunk
    else if (karakter == ')' || karakter == ']')
    {
        // Ellenőrizzük, hogy a verem üres-e
        if (verem.Count == 0)
        {
            szabalyos = false;
            break; // Kijövünk a ciklusból
        }

        // Kivesszük a legfelső elemet a veremből
        char nyitoZaro = verem.Pop();

        // Ellenőrizzük, hogy a nyitó zárójel megfelel-e a zárónak
        if ((karakter == ')' && nyitoZaro != '(') ||
            (karakter == ']' && nyitoZaro != '['))
        {
            szabalyos = false;
            break; // Kijövünk a ciklusból
        }
    }
}

// A végén ellenőrizzük, hogy a verem üres-e
if (szabalyos && verem.Count == 0)
{
    Console.WriteLine("A zárójel-sorozat szabályos.");
}
else
{
    Console.WriteLine("A zárójel-sorozat nem szabályos.");
}
