using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor9
{
    internal class Player
    {
        public Position Position {  get; set; }
        public ConsoleSprite Skin { get; private set; }

        public Player(int x, int y)
        {
            Position = new Position(x,y);
            Skin = new ConsoleSprite(ConsoleColor.Black,ConsoleColor.Green,'O');
        }
    }
}
