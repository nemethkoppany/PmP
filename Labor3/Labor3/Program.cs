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
            //Console.WriteLine("Add meg hány szót szeretnél megadni: ");

            //4.
            Console.WriteLine("Add meg a neved");
            string nev = Console.ReadLine();
            Console.WriteLine("Add meg az életkorod?");
            int eletkor = int.Parse(Console.ReadLine());

            Console.WriteLine("Van programozói tapasztalatod?(i,n)");
            bool tapasztalat = bool.Parse(Console.ReadLine());

            List<string> nevek = new List<string>();
            List<int> eletkorok = new List<int>();
            List<bool> tapasutalatok= new List<bool>();

            

        }
    }
}
