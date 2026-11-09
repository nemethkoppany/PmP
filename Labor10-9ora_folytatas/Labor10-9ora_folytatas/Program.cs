namespace TheConsoleSlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // Test 1
            Position pos1 = new Position(1, 2);
            Position pos2 = new Position(4, 6);
            Position result = Position.Add(pos1, pos2);
            Console.WriteLine($"Összeg: ({result.X}, {result.Y})");

            double distance = Position.Distance(pos1, pos2);
            Console.WriteLine($"Távolság: {distance}");
            */

            /*
            // Test 2
            ConsoleSprite sprite = new ConsoleSprite(ConsoleColor.Black, ConsoleColor.Green, '&');
            Console.BackgroundColor = sprite.Background;
            Console.ForegroundColor = sprite.Foreground;
            Console.Write(sprite.Glyph);
            Console.ResetColor();
            */

            /*
            // Test 3
            Player player = new Player(2, 3);
            Console.SetCursorPosition(player.Position.X, player.Position.Y);
            Console.BackgroundColor = player.Sprite.Background;
            Console.ForegroundColor = player.Sprite.Foreground;
            Console.Write(player.Sprite.Glyph);
            Console.ResetColor();
            */

            /*
            // Test 4
            Game game = new Game();
            game.Run();
            */

            
            // Final Game
            Game game = new Game();
            game.Run();
            
        }
    }
}
