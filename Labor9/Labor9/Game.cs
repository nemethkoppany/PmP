using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor9
{
    internal class Game
    {


        public Player Player;
        public bool Exited { get; set; }

        public Game()
        {
            Player player = new Player(0, 0);
        }

        private void RenderSingleSpire(Position pos, ConsoleSprite sprite)
        {
            if (0 <= pos.X && pos.X <= Console.WindowWidth && 0 <= pos.Y && pos.Y <= Console.WindowHeight)
            {
                Console.SetCursorPosition(pos.X, pos.Y);
                Console.BackgroundColor = sprite.Background;
                Console.ForegroundColor = sprite.Foreground;
                Console.WriteLine(sprite.Glyph);
            }
        }

        private void RenderGame()
        {
            Console.CursorVisible = false;
            Console.ResetColor();
            Console.Clear();
            RenderSingleSpire(Player.Position, Player.Skin);
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
                    case ConsoleKey.W:
                        Player.Position.Y++;
                        break;
                    case ConsoleKey.A:
                        Player.Position.X--;
                        break;
                    case ConsoleKey.D:
                        Player.Position.X++;
                        break;
                    case ConsoleKey.S:
                        Player.Position.Y--;
                        break;
                }
            }
        }

        public void Run()
        {
            while(Exited != true)
            {
                RenderGame();
                UserAction();
                Thread.Sleep(25);
            }
        }
    }
}
