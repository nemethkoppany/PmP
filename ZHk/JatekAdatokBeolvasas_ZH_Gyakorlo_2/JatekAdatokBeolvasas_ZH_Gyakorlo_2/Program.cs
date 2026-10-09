using System.Text.RegularExpressions;

namespace JatekAdatokBeolvasas_ZH_Gyakorlo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string genresTXT = "genre.txt";

            if (!File.Exists(genresTXT))
            {
                Console.WriteLine("Ez a fájl nem létezik!");
            }
            string[] lines = File.ReadAllLines(genresTXT);

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

            //foreach (string genre in genres)
            //{
            //    Console.WriteLine($"{genre}");
            //}

            string GamesDataSet = "games_dataset.csv";

            string[] lines2 = File.ReadAllLines(GamesDataSet);

            List<Game> games = new List<Game>();

            for(int i = 1; i < lines2.Length; i++)
            {
                string[] parts = lines2[i].Split(";");

                Game g = new Game();    
                g.Title = parts[0];
                g.ID = genres[int.Parse(parts[1])];
                g.Publisher = parts[2];
                g.Release_Date = parts[3];
                g.Original_Release_Date = parts[4];

                games.Add(g);
            }

            Console.WriteLine("Adj meg egy kiadót");

            string kiado = Console.ReadLine();

            int kiado_jatekai_db = 0;

            foreach (Game game in games)
            {
                if(game.Publisher.ToLower() == kiado.ToLower())
                {
                    kiado_jatekai_db++;
                }
            }

            Console.WriteLine($"A {kiado} kiadónak {kiado_jatekai_db} darab játéka van");

            foreach (Game game in games)
            {
                if(game.Release_Date.Substring(0,4) == game.Original_Release_Date.Substring(0, 4))
                {
                    Console.WriteLine($"{game.Title} | {game.ID} | {game.Original_Release_Date.Substring(0,4)}");
                }
            }

            int[] genreArray = new int[genres.Count];

            foreach(Game game in games)
            {
                int index = genres.IndexOf(game.ID);
                genreArray[index]++;
            }
            for(int i = 0; i <genres.Count; i++)
            {
                Console.WriteLine($"{genres[i]}: {genreArray[i]}");
            }

        }
    }

    class Game
    {
        public string Title;
        public string ID;
        public string Publisher;
        public string Release_Date;
        public string Original_Release_Date;
    }
}
