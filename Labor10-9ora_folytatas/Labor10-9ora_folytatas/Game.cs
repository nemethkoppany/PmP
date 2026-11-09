using Labor10_9ora_folytatas;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheConsoleSlayer
{
    class Game
    {
        Player player;
        public Player Player { get { return player; } }
        public bool Exited { get; set; }
        // Kesobb kell
        // A játékelemek listáját a 2. fejezetben hozzuk létre.
        public List<GameItem> Items {get;set;}
        public Game()
        {
            player = new Player(0, 0);
            // Kesobb kell
            // A játékelemek inicializálása is a 2. fejezet része.
            List<GameItem> Items = new List<GameItem>();
            
        }

        private void RenderSingleSprite(Position position, ConsoleSprite sprite)
        {
            int x = position.X;
            int y = position.Y;
            if (0 <= x && x < Console.WindowWidth && 0 <= y && y < Console.WindowHeight)
            {
                Console.SetCursorPosition(x, y);
                Console.BackgroundColor = sprite.Background;
                Console.ForegroundColor = sprite.Foreground;
                Console.Write(sprite.Glyph);
            }
        }

        private void RenderGame()
        {
            Console.CursorVisible = false;
            Console.ResetColor();
            Console.Clear();

            foreach (GameItem item in Items)
            {
                RenderSingleSprite(player.Position, player.Sprite);
            }

            
            
            // Kesobb kell ez a foreach
            // A játékelemek kirajzolása a 2. fejezet feladata.

           
        }

        private void CleanUpGameItems()
        {
            List<GameItem> deleteItems = new List<GameItem>();
            foreach(GameItem item in Items)
            {
                if(item.Available == false)
                {
                    deleteItems.Add(item);
                }
            }
            foreach (GameItem item in deleteItems)
            {
                Items.Remove(item);
            }

            deleteItems.Clear();
        }
        private void UserAction()
        {         
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressed = Console.ReadKey(true);
                switch (pressed.Key)
                {
                    case ConsoleKey.Escape:
                        Exited = true;
                        break;
                    // Eloszor csak kiiratas (utana lesz csak a Move metodus megcsinalva)
                    // Eg.:
                    // Console.WriteLine($"Key -> RightArrow ");
                    case ConsoleKey.RightArrow:
                        player.Position.X++;
                        break;
                    case ConsoleKey.LeftArrow:
                        player.Position.X--;
                        break;
                    case ConsoleKey.UpArrow:
                        player.Position.Y--;
                        break;
                    case ConsoleKey.DownArrow:
                        player.Position.Y++;
                        break;
                    // Kesobb kell
                    // A D billentyűs interakció a 2. fejezet része.
                    case ConsoleKey.D:
                        foreach(GameItem item in Items)
                        {
                            item.Interact();
                        }
                        break;
                    default:
                        break;
                }
                
            }
        }

        public void Run()
        {
            while (!Exited)
            {
                RenderGame();
                UserAction();
                CleanUpGameItems();
                // Kesobb kell
                // A játékelemek eltávolítását a 2. fejezetben oldjuk meg.
                Thread.Sleep(25);
            }
        }

        private List<GameItem> GetGameItemsWithinDistance(Position pos, double distance)
        {
            List<GameItem> result = new List<GameItem>();  
            foreach(GameItem item in Items)
            {
                double itemDistance = Position.Distance(pos, item.Position);
                if(itemDistance <= distance)
                {
                    result.Add(item);
                }
            }
            return result;
        }

        private double GetTotalFillingRatio(Position pos)
        {
            double sum = 0;

            foreach(GameItem item in GetGameItemsWithinDistance(pos, 0))
            {
                item.FillingRatio += sum;
            }

            return sum;
        }
    }
}
