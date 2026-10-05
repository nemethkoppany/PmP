/*
Bit műveletek:

Balra tolás:

int number = 5; // 5 a bináris formájában: 0000 0101
int result = number << 1; // Balra tolás 1 hellyel
Console.WriteLine(result); // Kimenet: 10

A 5 bináris formában 0000 0101.
A balra tolás (<<) operátor 1 hellyel balra tolja a biteket.
Tehát 0000 0101 -> 0000 1010, ami 10-et jelent a decimális rendszerben.
Ez a művelet a számot 2-vel megszorozza (mivel a bitek balra tolása a szám értékét megduplázza).

Jobbra tolás:

int number = 20; // 20 a bináris formájában: 0001 0100
int result = number >> 1; // Jobbra tolás 1 hellyel
Console.WriteLine(result); // Kimenet: 10

A 20 bináris formában 0001 0100.
A jobbra tolás (>>) operátor 1 hellyel jobbra tolja a biteket.
Tehát 0001 0100 -> 0000 1010, ami 10-et jelent a decimális rendszerben.
Ez a művelet a számot 2-vel osztja (mivel a bitek jobbra tolása a szám értékét felezi).

OR (|):

int a = 12; // 12 a bináris formájában: 0000 1100
int b = 5;  // 5 a bináris formájában: 0000 0101
int result = a | b; // Bit-OR
Console.WriteLine(result); // Kimenet: 13

A 12 bináris formában 0000 1100, míg a 5 bináris formában 0000 0101.
A bit-OR operátor (|) az összehasonlított biteket egyesíti.
Tehát:
0 | 0 = 0
0 | 1 = 1
1 | 0 = 1
1 | 1 = 1

Szóval az eredmény:

0000 1100
0000 0101
---------
0000 1101 (ami 13 decimálisan)

AND (&)

int a = 12; // 12 a bináris formájában: 0000 1100
int b = 5;  // 5 a bináris formájában: 0000 0101
int result = a & b; // Bit-AND
Console.WriteLine(result); // Kimenet: 4

A 12 és 5 bit-AND művelete az összehasonlított bitek közül csak azokat tartja meg, ahol mindkét bit 1.
Tehát:
0 & 0 = 0
0 & 1 = 0
1 & 0 = 0
1 & 1 = 1

Szóval az eredmény:

0000 1100
0000 0101
---------
0000 0100 (ami 4 decimálisan)
*/

// A "StringBuilder" használatához importálni kell a modult.
using System.Text;

// A felhasználótól kérjük be a szöveget
Console.WriteLine("Adj meg egy tetszőleges szöveget:");
string input = Console.ReadLine();

// Kódoló karakterek: az angol nagy- és kisbetűk, számjegyek és két speciális karakter
string base64Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";

// Kódolt szöveg tárolására szolgáló StringBuilder
// https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder?view=net-8.0
StringBuilder output = new StringBuilder();

// A bemeneti szöveg byte tömbbé alakítása UTF-8 kódolással
// https://learn.microsoft.com/en-us/dotnet/api/system.text.encoding.getbytes?view=net-8.0
byte[] inputBytes = Encoding.UTF8.GetBytes(input);

// A bemeneti byte tömb feldolgozása 3 bájtos egységekben
for (int i = 0; i < inputBytes.Length; i += 3)
{
    // Az aktuális 3 bájtot tartalmazó változók
    byte byte1 = inputBytes[i]; // Első bájt
    byte byte2 = (byte)((i + 1 < inputBytes.Length) ? inputBytes[i + 1] : 0); // Második bájt (ha van)
    byte byte3 = (byte)((i + 2 < inputBytes.Length) ? inputBytes[i + 2] : 0); // Harmadik bájt (ha van)

    // A 3 bájt 24 bitre alakítása (a bájtok balra tolásával (<<) és a bit-OR (|) operátorral)
    // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/bitwise-and-shift-operators
    int combined = (byte1 << 16) | (byte2 << 8) | byte3;

    // Az 24 bitet 4 darab 6 bites szegmensre bontjuk
    // Az első két szegmens a legmagasabb értékű biteket tartalmazza.
    output.Append(base64Chars[(combined >> 18) & 0x3F]); // Első 6 bit: a legmagasabb érték
    output.Append(base64Chars[(combined >> 12) & 0x3F]); // Második 6 bit
    // A kódolt szöveg végén, ha az utolsó egység nem tartalmaz elegendő bájtokat, a = karakterek adjuk hozzá a Base64 kódolás szabályainak megfelelően.
    output.Append((i + 1 < inputBytes.Length) ? base64Chars[(combined >> 6) & 0x3F] : '='); // Harmadik 6 bit, ha van második bájt, különben '='
    output.Append((i + 2 < inputBytes.Length) ? base64Chars[combined & 0x3F] : '='); // Negyedik 6 bit, ha van harmadik bájt, különben '='
}

// Az eredmény kiírása a konzolra
Console.WriteLine($"A kódolt Base64 szöveg: {output}");