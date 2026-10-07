using System.Runtime.InteropServices;

namespace JatekAdatFeldolgozas_ZH_Gyakorlo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = "genre.txt";

            if (!File.Exists(filename))
            {
                Console.WriteLine("Ez a fájl nem létezik!");
                return;
            }

            string[] lines = File.ReadAllLines(filename);

            List<string> genres = new List<string>();

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                foreach (string part in parts)
                {
                    string[] genre = part.Split("=");
                    genres.Add(genre[0]);
                }
            }

            //foreach (string genre in genres)
            //{
            //    Console.WriteLine(genre);
            //}


            string filename2 = "games_dataset.csv";

            if (!File.Exists(filename2))
            {
                Console.WriteLine("Ez a fájl nem létezik!");
                return;
            }

            string[] lines2 = File.ReadAllLines(filename2);

            List<Game> games = new List<Game>();

            for (int i = 1; i < lines2.Length; i++)
            {
                string[] parts = lines2[i].Split(";");

                Game g = new Game();
                g.Title = parts[0];
                g.Genre = genres[int.Parse(parts[1])];
                g.Publisher = parts[2];
                g.ReleaseDate = parts[3];
                g.OriginalReleaseDate = parts[4];

                games.Add(g);
            }

            foreach (Game g in games)
            {
                Console.WriteLine($"{g.Title} | {g.Genre} | {g.Publisher} | {g.ReleaseDate} | {g.OriginalReleaseDate}");
            }

            
        }
    }

    class Game
    {
        public string Title;
        public string Genre;
        public string Publisher;
        public string ReleaseDate;
        public string OriginalReleaseDate;
    }
}
