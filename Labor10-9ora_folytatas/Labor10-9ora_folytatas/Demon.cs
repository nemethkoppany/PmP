using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheConsoleSlayer;

namespace Labor10_9ora_folytatas
{
    public enum DemonType { Zombieman, Imp, Mancubus }
    public class Demon
    {
        

        public Position Position {  get; set; }
        public ConsoleSprite Sprite { get;private set; }
        public DemonType Type { get; private set; }
        public double FillingRatio {  get; private set; }
        private int health;
        public int Health {  get { return health; } set
            {
                if(value >= 0)
                {
                    this.health = value;
                }
            }
        }

        public bool Alive {  get; private set; }
        public int SightRange {  get; private set; }
        public int AttackRange {  get; private set; }

        private void SetInitialProperties()
        {
            switch (Type)
            {
                case DemonType.Zombieman:
                    FillingRatio = 0.4;
                    Health = 20;
                    SightRange = 3;
                    AttackRange = 1;
                    Sprite = new ConsoleSprite(ConsoleColor.Black, ConsoleColor.Yellow, 'o');
                    break;
                case DemonType.Imp:
                    FillingRatio = 0.4;
                    Health = 60;
                    SightRange = 6;
                    AttackRange = 3;
                    Sprite = new ConsoleSprite(ConsoleColor.Black, ConsoleColor.Red, 'o');
                    break;
                case DemonType.Mancubus:
                    FillingRatio = 0.9;
                    Health = 600;
                    SightRange = 9;
                    AttackRange = 6;
                    Sprite = new ConsoleSprite(ConsoleColor.Black, ConsoleColor.Red, 'O');
                    break;
            }
        }

        public Demon(int x, int y, DemonType type)
        {
            Position = new Position(x, y);
            Type = type;
            Alive = true;
            SetInitialProperties();
        }
    }
}
