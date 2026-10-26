using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor8
{
    public enum Position
    {
        Gaolkeeper,
        Forward, 
        Winger,
        Defender
    }
    public class Player
    {
        string name;
        Position pos;

        public Position Pos => pos;

        public Player(string name, Position pos)
        {
            this.name = name;
            this.pos = pos;
        }

        public override string ToString()
        {
            return $"{name} ({pos})";
        }

        public override bool Equals(object? obj)
        {
            Player otherPlayer = obj as Player;
            return this.name == otherPlayer.name && this.pos == otherPlayer.pos ;
        }
    }
}
