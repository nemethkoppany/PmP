/*
Írjunk programot, amely helyesség szempontjából ellenőrzi a felhasználó által megadott email címet.
Az email cím helyes, ha az alábbiak mindegyike teljesül.
a) pontosan egy @ karaktert tartalmaz
b) tartalmaz legalább egy betű karaktert a @ előtt
c) tartalmaz legalább egy . karaktert a @ után
d) a @ és az utolsó . karakter között kell legyen legalább egy betű vagy szám karakter
e) ha tartalmaz . karaktert a @ előtt is, akkor a . előtt és után is betű vagy szám karakter kell álljon
f) az utolsó . karakter után legalább két betűt kell tartalmazzon
*/

Console.Write("Adj meg egy email címet: ");
string email = Console.ReadLine();

// a) pontosan egy @ karaktert tartalmaz
int kukacIndex = email.IndexOf('@');
if (kukacIndex == -1 || email.IndexOf('@', kukacIndex + 1) != -1)
{
    Console.WriteLine("Az email cím helytelen. Pontosan 1 db '@' karaktert kell tartalmaznia!");
    return;
}

// b) tartalmaz legalább egy betű karaktert a @ előtt
string elotte = email.Substring(0, kukacIndex);
// Nincs karakter a @ előtt
if (string.IsNullOrEmpty(elotte))
{
    Console.WriteLine("Az email cím helytelen. Legalább 1 db betű karaktert kell tartalmaznia a '@' előtt!");
    return;
}

// Van karakter a @ előtt, de meg kell vizsgálni, hogy betű-e
bool vanBetuElotte = false;
for (int i = 0; i < elotte.Length; i++)
{
    if (char.IsLetter(elotte[i]))
    {
        vanBetuElotte = true;
        break;
    }
}
if (!vanBetuElotte)
{
    Console.WriteLine("Az email cím helytelen. Legalább 1 db betű karaktert kell tartalmaznia a '@' előtt!");
    return;
}

// c) tartalmaz legalább egy . karaktert a @ után
string utana = email.Substring(kukacIndex + 1);
// LastIndexOf visszaadja az utolsó indexet, ahol a megadott karakter található a string-ben.
int utolsoPontIndex = utana.LastIndexOf('.');
if (utolsoPontIndex == -1)
{
    Console.WriteLine("Az email cím helytelen. Legalább 1 db '.' karaktert kell tartalmaznia a '@' után!");
    return;
}

// d) a @ és az utolsó . karakter között kell legyen legalább egy betű vagy szám karakter
string kozott = utana.Substring(0, utolsoPontIndex);
bool vanBetuVagySzam = false;
for (int i = 0; i < kozott.Length; i++)
{
    if (char.IsLetterOrDigit(kozott[i]))
    {
        vanBetuVagySzam = true;
        break;
    }
}
if (!vanBetuVagySzam)
{
    Console.WriteLine("Az email cím helytelen. A '@' és az utolsó '.' karakter között kell legyen legalább 1 db betű vagy szám karakter");
    return;
}

// e) ha tartalmaz . karaktert a @ előtt is, akkor a . előtt és után is betű vagy szám karakter kell álljon
int pontIndex = elotte.IndexOf('.');
if (pontIndex != -1)
{
    if (pontIndex == 0 || pontIndex == elotte.Length - 1 ||
        !char.IsLetterOrDigit(elotte[pontIndex - 1]) ||
        !char.IsLetterOrDigit(elotte[pontIndex + 1]))
    {
        Console.WriteLine("Az email cím helytelen. A '@' előtti '.' karakter előtt és után kell betű vagy szám karakternek állni!");
        return;
    }
}

// f) az utolsó . karakter után legalább két betűt kell tartalmazzon
string utolsoResz = utana.Substring(utolsoPontIndex + 1);
if (utolsoResz.Length < 2)
{
    Console.WriteLine("Az email cím helytelen. A cím végén található '.' után legalább két betűnek kell állni.");
    return;
}

bool csakBetuk = true;
for (int i = 0; i < utolsoResz.Length; i++)
{
    if (!char.IsLetter(utolsoResz[i]))
    {
        csakBetuk = false;
        break;
    }
}
if (!csakBetuk)
{
    Console.WriteLine("Az email cím helytelen. A cím végén található '.' után legalább két betűnek (Csak betűnek) kell állni.");
    return;
}

Console.WriteLine("Az email cím helyes.");
