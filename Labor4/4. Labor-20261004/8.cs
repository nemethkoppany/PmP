/*
Írjunk programot, amely egyetlen formázott s karakterlánc tartalmát egy táblázatba (kétdimenziós tömbbe)
rendezi. Az s karakterláncban az egyes sorokat sortörés ('\n') karakterek, az egyes oszlopokat pontosvesszők
(';') választják el.

Példa:
A "Vincent;Vega;Vince\nMarsellus;Wallace;Big Man\nWinston;Wolf;The Wolf" karakterlánc
feldolgozása után az alábbi kétdimenziós tömböt kapjuk.

Vincent Vega Vince
Marsellus Wallace Big Man
Winston Wolf The Wolf
*/

string s = "Vincent;Vega;Vince\nMarsellus;Wallace;Big Man\nWinston;Wolf;The Wolf";

// A sorokat a sortörések alapján bontjuk
string[] sorok = s.Split('\n');

// A kétdimenziós tömb méretének meghatározása
int sorokSzama = sorok.Length;
int oszlopokSzama = sorok[0].Split(';').Length; // Az első sor alapján meghatározzuk az oszlopok számát

// Kétdimenziós tömb létrehozása
string[,] tabla = new string[sorokSzama, oszlopokSzama];

// A tartalom feltöltése a tömbbe
for (int i = 0; i < sorokSzama; i++)
{
    // Az i. sort elvágjuk a ";" karakter mentén
    string[] oszlopok = sorok[i].Split(';');
    // Végig iterálunk a oszlopokon
    for (int j = 0; j < oszlopokSzama; j++)
    {
        // A tömbben az i. sor j-ik oszlopába betöltjük az adatot.
        tabla[i, j] = oszlopok[j];
    }
}

// A táblázat kiírása
Console.WriteLine("Kétdimenziós tömb tartalma:");
for (int i = 0; i < sorokSzama; i++) // Sorok
{
    for (int j = 0; j < oszlopokSzama; j++) // Oszlopok
    {
        Console.Write(tabla[i, j]);
        if (j < oszlopokSzama - 1)
        {
            Console.Write(" "); // Oszlopok közötti szóköz
        }
    }
    Console.WriteLine(); // Új sor
}