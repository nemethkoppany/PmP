/*
Kérjünk el egy pozitív egész számot, majd írjuk ki a faktoriálisát.
N! = N × (N − 1) × (N − 2) × . . . × 3 × 2 × 1

Példa
N = 5
5! = 5×4×3×2×1 = 120
*/

Console.Write("Add meg a pozitív egész számot (N): ");
// A program csak pozitív egész számot fogad el!
if (!int.TryParse(Console.ReadLine(), out int N) || N < 0)
{
    Console.WriteLine("Kérlek, érvényes pozitív egész számot adj meg.");
    return;
}

// long típus:
//      - 64 bites egész típus
//      - signed, azaz pozitív és negatív értékek tárolására is alkalmas
//      - nagyobb egész számok tárolására használható
//      - amikor az int nem elég nagy a tárolandó értékek számára
//          (az int maximális értéke: 2,147,483,647)
//          (long: -9,223,372,036,854,775,808-tól (azaz -2^63) 9,223,372,036,854,775,807-ig (azaz 2^63 - 1))
long factorial = 1;
string factorialExpression = ""; // A kiíratáshoz használatos string

// 1-től N-ig iterálunk (N is benne van)
for (int i = 1; i <= N; i++)
{
    // factorial változó értékét megszorozza az i változó aktuális értékével,
    //      és az eredményt visszaírja a factorial változóba.
    // Rövidített formája a "factorial = factorial * i;" kifejezésnek
    factorial *= i;
    if (i > 1)
    {
        factorialExpression += "×";
    }
    factorialExpression += i.ToString();  // Az int típusból string-et képzünk és hozzáfűzzük a változóhoz.
}

Console.WriteLine($"{N}! = {factorialExpression} = {factorial}");