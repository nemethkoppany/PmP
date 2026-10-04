/*
Keverjük meg a korábban készített kártyapaklit a Fisher–Yates keveréssel.
A módszer lényege, hogy a tömb elemein végighaladva mindegyikhez kiválaszt
egy véletlen helyen lévő elemet a korábban még nem vizsgáltak közül,
amelyeket utána megcserél.
Az algoritmus pszeudokóddal az alábbi formában adható meg (1-alapú indexelést használva).

ciklus i ← 1-től (n − 1)-ig
j ← véletlen egész; i ≤ j ≤ n
x[i] ↔ x[j]
ciklus vége
*/

string[] szinek = { "Kőr", "Káró", "Treff", "Pikk" };
string[] magassagok = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jumbó", "Dáma", "Király", "Ász" };
string[] kartyaLapok = new string[52];

int index = 0;

for (int i = 0; i < szinek.Length; i++)
{
    for (int j = 0; j < magassagok.Length; j++)
    {
        kartyaLapok[index] = szinek[i] + " " + magassagok[j];
        index++;
    }
}

// Fisher-Yates keverés
Random rand = new Random();
for (int i = 0; i < kartyaLapok.Length - 1; i++)
{
    int j = rand.Next(i, kartyaLapok.Length); // Véletlen szám i és n (a kartyaLapok mérete) között
                                              // Csere x[i] és x[j] között
    string temp = kartyaLapok[i]; // Az aktuális kártya elmentése egy átmeneti változóba
    kartyaLapok[i] = kartyaLapok[j]; // Az aktuális kártya cseréje egy random kártyával
    kartyaLapok[j] = temp; // A random kártya cseréje az aktuális kártyával
}

// Megkevert kártyalapok kiírása
for (int i = 0; i < kartyaLapok.Length; i++)
{
    Console.WriteLine(kartyaLapok[i]);
}