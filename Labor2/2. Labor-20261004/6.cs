/*
Kérjünk el a felhasználótól egy N pozitív egész számot, majd írjuk ki az alábbiakat:
• N páros vagy páratlan
• N valódi pozitív osztóinak száma (1-et és N-et nem kell beleszámolnunk)
• N prímszám vagy összetett szám
*/

Console.Write("Add meg a pozitív egész számot (N): ");
int N = int.Parse(Console.ReadLine());

/*
if (!int.TryParse(Console.ReadLine(), out int N) || N <= 0)
{
    Console.WriteLine("Kérlek, érvényes pozitív egész számot adj meg.");
    return;
}
*/

// 1. N páros vagy páratlan
if (N % 2 == 0)  // Ha a 2-vel való osztásnak a maradéka egyenló nullával
{
    Console.WriteLine($"{N} páros.");
}
else
{
    Console.WriteLine($"{N} páratlan.");
}

// 2. N valódi pozitív osztóinak száma (1-et és N-et nem számítva)
int divisorCount = 0;
for (int i = 2; i < N; i++)
{
    if (N % i == 0)
    {
        divisorCount++;
    }
}
Console.WriteLine($"A valódi pozitív osztók száma: {divisorCount}");

// 3. N prímszám vagy összetett szám
bool isPrime = N > 1;
// A for ciklusban elegendő a felhasználó által beírt szám négyzetgyökéig vizsgálni a tartományt
// Természetesen a negyzetgyök feletti tartományban már nem lehet osztója a számnak.
for (int i = 2; i <= Math.Sqrt(N); i++)
{
    if (N % i == 0)
    {
        isPrime = false;
        break;
    }
}
if (isPrime)
{
    Console.WriteLine($"{N} prímszám.");
}
else
{
    Console.WriteLine($"{N} összetett szám.");
}