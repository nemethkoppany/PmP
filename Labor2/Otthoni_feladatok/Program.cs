using System.Xml;
namespace Otthoni_feladatok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //    //3.
            //   Random random = new Random();
            //    Console.Write("Adj meg egy számot 1 és 1000 között ");
            //    int bekert = int.Parse(Console.ReadLine());
            //    int probalkozasok = 0;
            //    int x;

            //    do
            //    {
            //        x = random.Next(1, 1001);
            //        probalkozasok++;
            //    }
            //    while (x != bekert);

            //    Console.WriteLine($"{probalkozasok} próbálkozás volt de sikerült.");


            //5.
            //int gondolt_szam = 45;
            //Console.WriteLine("Gondoltam egy számra 1 és 100 között. Találd ki!");
            //int megadott_szam;
            //int probalkozasok = 0;
            //do
            //{
            //    megadott_szam = int.Parse(Console.ReadLine());
            //    if(megadott_szam > gondolt_szam)
            //    {
            //        Console.WriteLine("A szám ennél kisebb");
            //    }
            //    else if(megadott_szam < gondolt_szam)
            //    {
            //        Console.WriteLine("A szám ennél nagyobb!");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Gratulálok. sikerült kitalálni! A gondolt szám a {gondolt_szam} volt és {probalkozasok} probálkozás volt kitalálni.");
            //    }
            //    probalkozasok++;
            //}
            //while (gondolt_szam != megadott_szam);


            //8.
            //Console.WriteLine("\t1\t2\t3\t4\t5\t6\t7\t8\t9");
            //for(int i = 1; i < 10; i++) //sorok
            //{
            //    Console.Write($"{i}\t");
            //    for (int j = 1; j < 10; j++)//oszlopok
            //    {
            //        Console.Write($"{i*j} " + "\t");//A két sor szorzása

            //    }
            //    Console.WriteLine();//Új sor

            //}


            //10
            ///*A kód elején bekérünk egy számot amit eltárolunk a "bekert" változóban
            //  Mivel a bináris konverziót 32 bitben szeretnénk kiírni ezért  a for ciklust 31-től 0-ig kell futtatni (jobbról balra mert a legkisebbnek, azaz a 0. bitnek jobb oldalon kell lennie mivel a bináris számokat jobbról balra olvassuk)
            //  Mindig az "i"-edik számnál i-vel eltoljik a bitet (pl.: 1010-nál 1-el kezdtünk (a legbaloldali pozícióban) és a >>operátorral eltoljuk pontosan annyi pozíciót ahányadik pozícióban van hogy a legjobboldalibb pozícióba kerüljön, és azt maradékosan elosztjuk kettővel, ha az a szám 0 akkor a maradék 0, ha pedig 1 akkor a maradék 1 és így megkapjuk a számot)
            //  Tehát ha a 31. pozícióban van egy szám, azt 31 lépéssel jobbra toljuk, hogy legjobboldalon legyen, ekkor elosztjuk maradékosan kettővel és megkapjuk a helyes számot.
            // */
            //Console.WriteLine("Adj meg egy számot");
            //uint bekert = uint.Parse(Console.ReadLine());
            //Console.Write($"{bekert} (10) = ");
            //for (int i = 31; i >= 0; i--)
            //{
            //    Console.Write($"{(bekert >> i) % 2}");//A bekért szám számjegyeit annyival léptetjük ahányadik pozícióban vannak és azt maradékosan osutjuk 2-vel
            //    if(i % 8 == 0)
            //    {
            //        Console.Write(" ");
            //    }

            //}
            //Console.Write("(2)");

            //12.
            //int credits = 100;
            //int bet = 1;
            //Random random = new Random();
            //ConsoleKey key;

            //Console.WriteLine("Félkarú rabló");
            //Console.WriteLine("Space: pörgetés, fel/le nyilak: tét növelés/csökkentés, Esc: kilépés");
            //Console.WriteLine($"Elérhető kreditek: {credits}");
            //Console.WriteLine($"Tét: {bet}");



            //do
            //{
            //    key = Console.ReadKey(true).Key;

            //    if (key == ConsoleKey.UpArrow)
            //    {
            //        if (bet < credits)
            //        {
            //            bet++;
            //            Console.WriteLine($"Tét: {bet}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("A tét nem lehet nagyobb, mint az elérhető kredit!");
            //        }
            //    }
            //    else if (key == ConsoleKey.DownArrow)
            //    {
            //        if (bet > 1)
            //        {
            //            bet--;
            //            Console.WriteLine($"Tét: {bet}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("A tét nem lehet 1-nél kisebb!");
            //        }
            //    }
            //    else if (key == ConsoleKey.Spacebar)
            //    {
            //        int szam1 = random.Next(0, 10);
            //        int szam2 = random.Next(0, 10);
            //        int szam3 = random.Next(0, 10);

            //        Console.WriteLine("+---+ +---+ +---+");
            //        KirajzolKartyaKozep(szam1);
            //        Console.Write(" ");
            //        KirajzolKartyaKozep(szam2);
            //        Console.Write(" ");
            //        KirajzolKartyaKozep(szam3);
            //        Console.WriteLine(" ");
            //        Console.WriteLine("+---+ +---+ +---+");

            //        Console.WriteLine($"Pörgetés: {szam1} {szam2} {szam3}");

            //        credits -= bet;

            //        if (szam1 == szam2 && szam2 == szam3)
            //        {
            //            int nyeremeny = bet * 50;
            //            credits += nyeremeny;
            //            Console.WriteLine($"Három egyforma! Nyeremény: {nyeremeny} kredit");
            //        }
            //        else if (szam1 == szam2 || szam1 == szam3 || szam2 == szam3)
            //        {
            //            int nyeremeny = bet * 10;
            //            credits += nyeremeny;
            //            Console.WriteLine($"Két egyforma! Nyeremény: {nyeremeny} kredit");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Nincs nyeremény.");
            //        }

            //        Console.WriteLine($"Elérhető kreditek: {credits}");

            //        if (credits <= 0)
            //        {
            //            Console.WriteLine("Elfogyott a kredited! Játék vége.");
            //            break;
            //        }

            //        if (bet > credits)
            //        {
            //            bet = credits;
            //        }
            //    }

            //} while (key != ConsoleKey.Escape);

            //Console.WriteLine("Köszönjük a játékot!");


            //13.

            double Pt = 100;

            Console.Write("Add meg, hogy hanyadik órában szeretnéd megnézni az árfolyamot. ");
            int bekert_ora = int.Parse(Console.ReadLine());
            if(bekert_ora <= 0 || 24 < bekert_ora)
            {
                Console.WriteLine("Csak 24- órás intervallumot néz a program!");
            }
            else
            {
                Random random = new Random();
                double r = 0.8 + random.NextDouble() * (2.01 - 0.8);

                Console.WriteLine($"A kezdő árfolyam: {Pt}Ft");
                Console.WriteLine();

                for (int i = 1; i <= 24; i++)
                {
                    Double zaj = (random.NextDouble() * 20) - 10;
                    Pt = r * Pt + zaj;

                    if (Pt < 0)
                    {
                        Pt = 0;
                        Console.WriteLine("Rug pull!!!!!");
                    }
                    if (i == bekert_ora)
                    {
                        Console.WriteLine($"{i}-edik órában az árfolyam {Pt:F2}Ft");
                    }

                }
            }

            
        }

        //12. feladat segédfüggvény
        //static void KirajzolKartyaKozep(int szam)
        //{
        //    string szimbolum = ""; 
        //    ConsoleColor szin = ConsoleColor.White; 
        //        switch (szam) 
        //    { 
        //        case 0: szimbolum = "♠"; szin = ConsoleColor.DarkGray; break; 
        //        case 1: szimbolum = "♥"; szin = ConsoleColor.Red; break; 
        //        case 2: szimbolum = "♣"; szin = ConsoleColor.DarkGray; break; 
        //        case 3: szimbolum = "♦"; szin = ConsoleColor.Red; break;
        //        default: szimbolum = szam.ToString(); szin = ConsoleColor.White; break;
        //    }
        //    Console.Write("| "); Console.ForegroundColor = szin; 
        //    Console.Write(szimbolum); Console.ResetColor(); 
        //    Console.Write(" |");
        //}
    }
}
