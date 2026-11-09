using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheConsoleSlayer
{
    class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        // A statikus metódus egy olyan függvény egy osztályban,
        // amely nem egy konkrét objektumhoz (példányhoz) tartozik,
        // hanem magához az osztályhoz. Ez azt jelenti, hogy statikus
        // metódust anélkül is meg lehet hívni, hogy létrehoznánk az osztályból egy példányt.
        public static double Distance(Position p1, Position p2)
        {
            // Az euklideszi távolság kiszámítása két pont között egy matematikai módszer,
            // amelyet úgy határozunk meg, hogy két pont (itt: p_1 és p_2) koordinátáit felhasználva
            // megkapjuk a közöttük lévő "egyenes" távolságot.
            // SQRT(POW(x_2-x_1)+POW(y_2-y_1))
            // Igy is lehet:
            //  int deltaX = p1.X - p2.X;
            //  int deltaY = p1.Y - p2.Y;
            //  return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }

        public static Position Add(Position p1, Position p2)
        {
            return new Position(p1.X + p2.X, p1.Y + p2.Y);
        }        
    }
}
