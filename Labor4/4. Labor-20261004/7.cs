/*
Írjunk programot, amely egy adott szöveget SpongeCase formátumúra alakít. Az átalakítás során a szöveg
karakterei véletlenszerűen legyenek kis- és nagybetűk.

Példa:
Bemenet: Well, a Big Mac's a Big Mac, but they call it le Big-Mac.
Kimenet: WeLl, A BiG MaC'S A BiG MaC, bUt tHeY CaLl iT Le bIg-mAc.
*/

Console.Write("Adj meg egy szöveget: ");
string bemenet = Console.ReadLine();
Random random = new Random();
string kimenet = "";

// Végig iterálunk a bemeneti szöveg karakterein
for (int i = 0; i < bemenet.Length; i++)
{
    // Az aktuális karakter a string-ből.
    char karakter = bemenet[i];

    // Csak betűket alakítunk át
    if (char.IsLetter(karakter))
    {
        // Véletlenszerűen eldöntjük, hogy nagy- vagy kisbetűt használunk
        if (random.Next(2) == 0) // 0 vagy 1
        {
            kimenet += char.ToUpper(karakter);
        }
        else
        {
            kimenet += char.ToLower(karakter);
        }
    }
    else
    {
        // Egyéb (pl.: speciális vagy számok) karakterek változatlanok maradnak
        kimenet += karakter;
    }
}

Console.WriteLine("SpongeCase formátumú szöveg:");
Console.WriteLine(kimenet);