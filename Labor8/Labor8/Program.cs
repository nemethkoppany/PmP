using System.Globalization;

namespace Labor8
{
    internal class Program
    {
        static string[] firstnames = { "Józsi", "Béla", "Miklós", "Jónás", "Attila","jakab","Péter","Balázs","Milán" };
        static string[] lastnames = { "Kovács", "Tóth", "Balázs", "Kis", "Nagy", "Papp" };
        static void Main(string[] args)
        {
            RandomPlayer(5);
        }
        static Player[] RandomPlayer(int num)
        {
            Random rnd = new Random();
            Player[] result = new Player[num];

            for (int i = 0; i < result.Length; i++)
            {
                string rndName = $"{firstnames[rnd.Next(firstnames.Length)]} {lastnames[rnd.Next(lastnames.Length)]}";
                Position rndPos = (Position)rnd.Next(Enum.GetNames(typeof(Position)).Length);
                
                result[i] = new Player(rndName,rndPos);
            }
            return result;
        }
    } 
}
