namespace JatekAdatBeolvasas_ZH_Gyakorlo_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string genreTXT = "genre.txt";

            if (!File.Exists(genreTXT))
            {
                Console.WriteLine("Ez a fájl nem létezik!");
                return;
            }

            string[] lines = File.ReadAllLines(genreTXT);

            List<string> genres = new List<string>();

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                foreach (string part in parts)
                {
                    string[] genre = part.Split("=");
                    genres.Add(genre[0]);
                }
            }

            string games_dataset = "games_dataset.csv";

            if (!File.Exists(games_dataset))
            {
                Console.WriteLine("Ez a fájl nem létezik!");
                return;
            }

            string[] lines2 = File.ReadAllLines(games_dataset);

            List<Game> Game = new List<Game>();

            for(int i = 1; i < lines2.Length; i++)
            {
                string[] parts = lines2[i].Split(";");

                Game g = new Game();    
                g.Title = parts[0];
                g.Genre = genres[int.Parse(parts[1])];
                g.Publisher = parts[2];
                g.Release_Date = parts[3];
                g.Original_Release_Date = parts[4];

                Game.Add(g);

            }

            //Console.WriteLine("Add meg az egyik kiadó nevét!");
            //string kiado = Console.ReadLine();

            //int kiado_db = 0;

            //foreach (Game games in Game)
            //{
            //    if(games.Publisher ==  kiado) kiado_db++;
            //}

            //Console.WriteLine($"A {kiado} kiadónak {kiado_db} játéka van!");

            //foreach (Game game in Game)
            //{
            //    if(game.Release_Date.Substring(0,4) == game.Original_Release_Date.Substring(0, 4))
            //    {
            //        Console.WriteLine($"{game.Title} | {game.Genre} {game.Original_Release_Date.Substring(0, 4)}");
            //    }
            //}

            int[] Counts = new int[genres.Count];

            foreach(Game games in Game)
            {
                int index = genres.IndexOf(games.Genre);
                Counts[index]++;
            }

            for(int i = 0; i < genres.Count; i++)
            {
                Console.WriteLine($"{genres[i]}: {Counts[i]}");
            }


        }
    }
    class Game
    {
        public string Title;
        public string Genre;
        public string Publisher;
        public string Release_Date;
        public string Original_Release_Date;

    }
}
