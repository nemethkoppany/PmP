using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheConsoleSlayer
{
    public class ConsoleSprite
    {
        public ConsoleColor Background { get; private set; }
        public ConsoleColor Foreground { get; private set; }
        public char Glyph { get; private set; }

        public ConsoleSprite(ConsoleColor background, ConsoleColor foreground, char glyph)
        {
            Background = background;
            Foreground = foreground;
            Glyph = glyph;
        }
    }
}
