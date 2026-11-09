using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheConsoleSlayer
{
    class Player
    {
        public Position Position { get; set; }
        public ConsoleSprite Sprite { get; private set; }
        // Kesobb kell
        // A FillingRatio tulajdonságot a 3. fejezetben vezetjük be.
        public double FillingRatio {  get; private set; }
        

        public Player(int x, int y)
        {
            Position = new Position(x, y);
            Sprite = new ConsoleSprite(ConsoleColor.Black, ConsoleColor.Green, 'O');
            // Kesobb kell
            // A FillingRatio kezdőértékét a 3. fejezetben állítjuk majd be.
            FillingRatio = 0.4;
        }
    }
}
