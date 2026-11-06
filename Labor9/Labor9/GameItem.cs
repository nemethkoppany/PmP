using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor9
{
    enum ItemType
    {
        Ammo,
        BFGCell, 
        Door,
        LevelExit,
        Medikit,
        ToxicWaste,
        Wall
    }
    internal class GameItem
    {
        public Position Position;
        public ConsoleSprite Sprite;
    }
}
