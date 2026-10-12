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

            //3.
            Console.WriteLine("Add meg az egyik kiadó nevét!");
            string kiado = Console.ReadLine().Trim();

                int kiado_jatekai = 0;

            foreach (Game game in games)
            {
                if(game.Publisher.ToLower() == kiado.ToLower())
                {
                    kiado_jatekai++;
                }
            }
            Console.WriteLine($"A {kiado} kiadónak összesen {kiado_jatekai} darab játéka van");


            //4.
            foreach(Game game in games)
            {
                if(game.ReleaseDate.Substring(0,4) == game.OriginalReleaseDate.Substring(0,4))
                {
                    Console.WriteLine($"{game.Title} | {game.Genre} | {game.ReleaseDate.Substring(0,4)}");
                }
            }


            //5.
            int[] Counts = new int[genres.Count];//Olyan hosszú ahány műfaj van

            foreach(Game game in games)
            {
                int index = genres.IndexOf(game.Genre);//Megadja, hogy az aktuális műfaj hanyas indexen van
                Counts[index]++;//Az az indexet növeljük egyel
            }
            for(int i = 0; i < genres.Count; i++)
            {
                Console.WriteLine($"{genres[i]}: {Counts[i]}");
            }




            // foreach (Game g in games)
            // {
            //     Console.WriteLine($"{g.Title} | {g.Genre} | {g.Publisher} | {g.ReleaseDate} | {g.OriginalReleaseDate}");
            // }

            

            

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
