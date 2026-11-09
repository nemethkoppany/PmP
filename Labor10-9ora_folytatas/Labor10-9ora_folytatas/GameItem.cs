using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheConsoleSlayer;

namespace Labor10_9ora_folytatas
{
    enum ItemType { Ammo, BFGCell, Door, LevelExit, Medikit, ToxicWaste, Wall }
    internal class GameItem
    {
        public Position Position { get; set; }
        public ConsoleSprite Sprite { get; set; }
        public ItemType Type { get; set; }  
        public double FillingRatio {  get; set; }
        public bool Available {  get; set; }

        private void SetInitialProperties()
        {
            switch (Type)
            {
                case ItemType.Ammo:
                    FillingRatio = 0.0;
                    Sprite = new ConsoleSprite(ConsoleColor.Red, ConsoleColor.Yellow, 'A');
                    break;
                case ItemType.BFGCell:
                    FillingRatio = 0.0;
                    Sprite = new ConsoleSprite(ConsoleColor.Green, ConsoleColor.White, 'B');
                    break;
                case ItemType.Door:
                    //if(Available)
                    //{
                    //    FillingRatio = 1.0;
                    //    Sprite = new ConsoleSprite(ConsoleColor.Gray, ConsoleColor.Yellow, '/');
                    //}
                    //else
                    //{
                        FillingRatio = 0.0;
                        Sprite = new ConsoleSprite(ConsoleColor.Gray, ConsoleColor.Red, '/');
                    //}
                    break;
                case ItemType.LevelExit:
                    FillingRatio = 1.0;
                    Sprite = new ConsoleSprite(ConsoleColor.Blue, ConsoleColor.Black, 'E');
                    break;
                case ItemType.Medikit:
                    FillingRatio = 1.0;
                    Sprite = new ConsoleSprite(ConsoleColor.Gray, ConsoleColor.Red, '+');
                    break;
                case ItemType.ToxicWaste:
                    FillingRatio = 0.0;
                    Sprite = new ConsoleSprite(ConsoleColor.DarkGreen, ConsoleColor.White, ':');
                    break;
                case ItemType.Wall:
                    FillingRatio = 1.0;
                    Sprite = new ConsoleSprite(ConsoleColor.Gray, ConsoleColor.Gray, ' ');
                    break;

            }
        }

        public GameItem(int x,int y,ItemType type)
        {
            Position = new Position(x,y);
            Type = type;
            Available = true;
            //Sprite = new ConsoleSprite(ConsoleColor.Black, ConsoleColor.White, '?');
            SetInitialProperties();
        }

        public void Interact()
        {
            switch (Type)
            {
                case ItemType.Ammo:
                case ItemType.BFGCell:
                case ItemType.Medikit:
                    Available = false;
                    break;

                case ItemType.Door:
                    if(FillingRatio == 0.0)
                    {
                        FillingRatio = 1.0;
                        Sprite = new ConsoleSprite(ConsoleColor.Gray, ConsoleColor.Yellow, '/');
                    }
                    else if(FillingRatio == 1.0)
                    {
                        FillingRatio = 0.0;
                        Sprite = new ConsoleSprite(ConsoleColor.Gray, ConsoleColor.Red, '/');
                    }
                    break;


                default:
                    break;
            }
        }
    }
}
