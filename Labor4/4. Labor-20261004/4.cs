/*
Írjunk programot, amely képes adott számú, különböző, az előző feladatban megadott formátumú véletlen
rendszámot generálni.
*/

Console.Write("Add meg, hány véletlen rendszámot szeretnél generálni: ");
int rendszamokSzama = int.Parse(Console.ReadLine());

List<string> rendszamok = new List<string>();
Random random = new Random();
// Csak a nagybetűk kellenek, mivel a rendszámban csak nagybetűk vannak.
// Ha nem akarjuk kiírni a karaktereket, akkor tudjuk használni az ASCII karaktereket is
// Hint: https://www.techiehook.com/articles/convert-ascii-to-character-in-csharp
string betuk = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string szamok = "0123456789";

// A ciklus addig fut amíg a generált rendszámok száma nem éri el
// a felhasználó által megadott darab számot.
while (rendszamok.Count < rendszamokSzama)
{
    char[] rendszam = new char[9];

    // Két betű az elején
    rendszam[0] = betuk[random.Next(betuk.Length)];
    rendszam[1] = betuk[random.Next(betuk.Length)];

    // Szóköz
    rendszam[2] = ' ';

    // Két betű a közepén
    rendszam[3] = betuk[random.Next(betuk.Length)];
    rendszam[4] = betuk[random.Next(betuk.Length)];

    // Kötőjel
    rendszam[5] = '-';

    // Három számjegy a végén
    rendszam[6] = szamok[random.Next(szamok.Length)];
    rendszam[7] = szamok[random.Next(szamok.Length)];
    rendszam[8] = szamok[random.Next(szamok.Length)];

    // A generált rendszámot karakterlánccá (string) alakítjuk
    string rendszamStr = new string(rendszam);

    // Ellenőrizzük, hogy a rendszám már létezik-e, ha nem, hozzáadjuk
    if (!rendszamok.Contains(rendszamStr))
    {
        rendszamok.Add(rendszamStr);
    }
}

// Eredmény kiírása
Console.WriteLine($"{rendszamokSzama} véletlen rendszám generálva:");
foreach (string rendszam in rendszamok)
{
    Console.WriteLine(rendszam);
}