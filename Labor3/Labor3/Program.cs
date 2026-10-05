namespace Labor3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            //string[] szinek = { "Kör", "káró", "treff", "pikk" };
            //string[] magassagok = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "jumbó", "dáma", "király", "ász" };
            //string[] kartyalapok = new string[52];

            //int kartyaLapokIndex = 0;

            //for (int i = 0; i < szinek.Length; i++)
            //{
            //    for (int j = 0; j < magassagok.Length; j++)
            //    {
            //        kartyalapok[kartyaLapokIndex] = szinek[i] + " " + magassagok[j];
            //        kartyaLapokIndex++;
            //    }
            //}

            //foreach (string lap in kartyalapok)
            //{
            //    Console.WriteLine(lap);
            //}
            //Thread.Sleep(3000);
            //Console.Clear();


            ////2. (kell hozzá az 1.)
            //Console.WriteLine("Fisher-Yates keverés");
            //Random rnd = new Random();
            //for(int i = 0; i< kartyalapok.Length-1; i++)
            //{
            //    int j = rnd.Next(i, kartyalapok.Length);
            //    string temp = kartyalapok[i];
            //    kartyalapok[i] = kartyalapok[j];
            //    kartyalapok[j] = temp;
            //}
            //for(int i = 0;i< kartyalapok.Length; i++)
            //{
            //    Console.WriteLine(kartyalapok[i]);
            //}

            //3.

            // Szavak bekérése a felhasználótól
            Console.Write("Add meg, hány szót szeretnél megadni: ");

            // pozitív egész szám bekérése hiba kezeléssel
            if (!int.TryParse(Console.ReadLine(), out int darabszam) || darabszam < 0)
            {
                Console.WriteLine("HIBA: Pozitív egész számot kell megadni!");
                return;
            }

            // Szavak tömb létrehozása. A hossza megegyezik a szavak számával.
            string[] szavak = new string[darabszam];

            // Bekérjük az N darab szót.
            for (int i = 0; i < darabszam; i++)
            {
                Console.Write($"Add meg a(z) {i + 1}. szót: ");
                szavak[i] = Console.ReadLine();
            }

            // Keresendő szó bekérése
            Console.Write("Adj meg egy keresendő szót: ");
            string keresettSzo = Console.ReadLine();

            // Szó keresése a tömbben for ciklussal
            int index = -1; // Az értéke csak átmeneti a ciklusban felülírásra kerül.
            for (int i = 0; i < szavak.Length; i++)
            {
                if (szavak[i] == keresettSzo)
                {
                    index = i;
                    break; // Megáll, ha megtalálta az első előfordulást

                    // Az alábbi megoldás is jó a feladat leírás alapján,
                    // viszont ebben az esetben a for cikloson kívül nem fogjuk tudni
                    // megállapítani, hogy a szót megtaláltuk-e és, ha igen melyik indexen.
                    // Console.WriteLine($"A(z) \"{keresettSzo}\" szerepel a gyűjteményben, és először a(z) {i}. helyen található.");
                    // break;
                }
            }

            /*
            // Szó keresése a tömbben for ciklussal
            int index = -1;
            int szoSzamlalo = }0;
            while (szoSzamlalo < szavak.Length)
            {
                if (szavak[szoSzamlalo] == keresettSzo)
                {
                    index = szoSzamlalo;
                    break; // Megáll, ha megtalálta az első előfordulást
                }
                szoSzamlalo++;
            }
            */

            // Eredmény kiírása
            if (index != -1)
            {
                // A string-ben a "\" karakter egy escape-character.
                // Hint: https://www.w3schools.com/cs/cs_strings_chars.php
                Console.WriteLine($"A(z) \"{keresettSzo}\" szerepel a gyűjteményben, és először a(z) {index + 1}. helyen található.");
            }
            else
            {
                Console.WriteLine($"A(z) \"{keresettSzo}\" nem található a gyűjteményben.");




                //    //4.
                //    Console.WriteLine("Add meg a neved");
                //string nev = Console.ReadLine();
                //Console.WriteLine("Add meg az életkorod?");
                //int eletkor = int.Parse(Console.ReadLine());

                //Console.WriteLine("Van programozói tapasztalatod?(i,n)");
                //bool tapasztalat = bool.Parse(Console.ReadLine());

                //List<string> nevek = new List<string>();
                //List<int> eletkorok = new List<int>();
                //List<bool> tapasutalatok= new List<bool>();
            }

            

        }
    }
}
