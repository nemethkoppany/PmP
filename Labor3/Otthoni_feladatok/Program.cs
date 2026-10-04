namespace Otthoni_feladatok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////4.
            //Console.Write("Add meg, hogy milyen szavak között szeretnél keresni: ");

            //List<string> szavak = new List<string>();
            //string szo;
            //do
            //{
            //    szo = Console.ReadLine();
            //    if(szo != "STOP")
            //    {
            //        szavak.Add(szo);
            //    }

            //}

            //while (szo != "STOP");

            //Console.Write("Adj meg egy keresendő szót: ");
            //string keresettSzo = Console.ReadLine();


            //int index = -1;
            //for (int i = 0; i < szavak.Count; i++)
            //{
            //    if (szavak[i] == keresettSzo)
            //    {
            //        index = i;
            //        break;
            //    }
            //}

            //if (index != -1)
            //{
            //    Console.WriteLine($"A(z) \"{keresettSzo}\" szerepel a gyűjteményben, és először a(z) {index + 1}. helyen található.");
            //}
            //else
            //{
            //    Console.WriteLine($"A(z) \"{keresettSzo}\" nem található a gyűjteményben.");

            //}

            //7.
            // 1. Horgászok és halfajták számának bekérése
            //Console.Write("Adja meg a horgászok számát: ");
            //int horgaszokSzama = int.Parse(Console.ReadLine());

            //Console.Write("Adja meg a halfajták számát: ");
            //int halfajtakSzama = int.Parse(Console.ReadLine());

            //// 2. Kétdimenziós tömb (mátrix) létrehozása
            //int[,] F = new int[horgaszokSzama, halfajtakSzama];
            //Random rnd = new Random();

            //// 3. Adatok véletlenszerű generálása (0-10)
            //for (int i = 0; i < F.GetLength(0); i++)
            //{
            //    for (int j = 0; j < F.GetLength(1); j++)
            //    {
            //        F[i, j] = rnd.Next(0, 11);
            //    }
            //}

            //// 4. Formázott megjelenítés
            //Console.WriteLine("\n=== FOGÁSI TÁBLÁZAT (F) ===");

            //Console.Write("          ");
            //for (int j = 0; j < F.GetLength(1); j++)
            //{
            //    Console.Write($"{j + 1}. halfajta\t");
            //}
            //Console.WriteLine("\n---------------------------------------------------------");

            //for (int i = 0; i < F.GetLength(0); i++)
            //{
            //    Console.Write($"{i + 1}. horgász |\t");
            //    for (int j = 0; j < F.GetLength(1); j++)
            //    {
            //        Console.Write($"{F[i, j]}\t\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            //// 5. Oszlopösszegzés (Halfajtánkénti fogások)
            //Console.WriteLine("=== FOGÁSOK HALFAJTÁNKÉNT ===");
            //for (int j = 0; j < F.GetLength(1); j++)
            //{
            //    int oszlopOsszeg = 0;
            //    for (int i = 0; i < F.GetLength(0); i++)
            //    {
            //        oszlopOsszeg += F[i, j];
            //    }
            //    Console.WriteLine($"• {j + 1}. halfajta összesen: {oszlopOsszeg} db");
            //}
            //Console.WriteLine();

            //// 6. Maximumkeresés (Legtöbb halat fogó horgász)
            //int maxHorgaszIndex = 0;
            //int maxHalGyozelem = -1;

            //for (int i = 0; i < F.GetLength(0); i++)
            //{
            //    int horgaszOsszesen = 0;
            //    for (int j = 0; j < F.GetLength(1); j++)
            //    {
            //        horgaszOsszesen += F[i, j];
            //    }

            //    if (horgaszOsszesen > maxHalGyozelem)
            //    {
            //        maxHalGyozelem = horgaszOsszesen;
            //        maxHorgaszIndex = i;
            //    }
            //}

            //Console.WriteLine($"• A legtöbb halat a(z) {maxHorgaszIndex + 1}. horgász fogta (összesen {maxHalGyozelem} db halat).");

            //// 7. Eldöntés (Nullázó horgász)
            //bool voltNullasHorgasz = false;

            //for (int i = 0; i < F.GetLength(0); i++)
            //{
            //    int horgaszOsszesen = 0;
            //    for (int j = 0; j < F.GetLength(1); j++)
            //    {
            //        horgaszOsszesen += F[i, j];
            //    }

            //    if (horgaszOsszesen == 0)
            //    {
            //        voltNullasHorgasz = true;
            //        break;
            //    }
            //}

            //if (voltNullasHorgasz)
            //{
            //    Console.WriteLine("• VOLT olyan horgász, aki egyetlen halat sem fogott.");
            //}
            //else
            //{
            //    Console.WriteLine("• NEM VOLT olyan horgász, aki egyetlen halat sem fogott volna.");
            //}

            //10.
            Random rnd = new Random();
            int[] tomb = new int[rnd.Next(1,11)];

            int[] tomb2 = new int[(tomb.Length+1)/2];

            for(int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(1,101);
            }

            //Válogassuk ki a gyűjtemény minden második elemét egy új gyűjteménybe.
            int j = 0;// A tomb2 saját indexe
            for (int i = 0; i < tomb.Length; i = i + 2)
            {
                tomb2[j] = tomb[i];// A tomb i-edik elemét átmásoljuk a tomb2 j-edik helyére
                j++;// Lépünk a tomb2 következő pozíciójára
            }

            //Fordítsuk meg a gyűjtemény elemeinek sorrendjét.
            for (int i = tomb.Length-1; i >=  0; i--)//a tömbök indexelése 0-tól indul, így az utolsó érvényes index értéke `tomb.Length - 1`
            {
                Console.Write($"{tomb[i]} ");
            }

            //endezzük a lehető legkisebb négyzetes mátrixba a gyűjtemény elemeit (az esetlegesen üresen maradó értékek helyére nulla kerüljön)
            int K = tomb.Length;

            int N = (int)Math.Ceiling(Math.Sqrt(K));

            int[,] matrix = new int[N,N];

            int index = 0;
            for (int i = 0; i < N; i++)
            {
                for(int z = 0; z < N; z++)
                {
                    if(index < K)
                    {
                        matrix[i , z] = tomb[index];
                        index++;
                    }
                }
            }

            Console.WriteLine($"{K} elem elrendezése a legkisebb ({N}x{N}-es) négyzetes mátrixban:\n");
            for (int i = 0; i < N; i++)
            {
                for (int z = 0; z < N; z++)
                {
                    Console.Write($"{matrix[i, z]}\t");
                }
                    Console.WriteLine();            
            }

        }
    }
}
