using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor9
{
    internal class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Position Add(Position p_1, Position p_2)
        {
          int x = p_1.X + p_2.X;
          int y = p_1.Y + p_2.Y;

          return new Position(x, y);
        }

        public static double Distance(Position p_1, Position p_2)
        {
            return Math.Sqrt(Math.Pow(p_1.X - p_2.X, 2) + Math.Pow(p_1.Y - p_2.Y, 2));
        }
    }
}
