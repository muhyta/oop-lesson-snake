using System;
using System.Collections.Generic;

namespace oop_lesson_snake
{
    internal class Walls 
    {

        List<Figure> fList;

        public Walls(int mapWidth, int mapHeight)
        {
            fList = new List<Figure>();
            HorizontalLine hl1 = new HorizontalLine(0, mapWidth-1, 0, '+');
            HorizontalLine hl2 = new HorizontalLine(0, mapWidth-1, mapHeight-2, '+');
            VerticalLine vl1 = new VerticalLine(0, 0, mapHeight-2, '+');
            VerticalLine vl2 = new VerticalLine(mapWidth-1, 0, mapHeight-2, '+');
            fList.Add(hl1);
            fList.Add(hl2);
            fList.Add(vl1);
            fList.Add(vl2);
        }

        internal bool IsHit(Figure figure)
        {
            foreach (Figure f in fList)
            {
                if (figure.IsHit(f))
                {
                    return true;
                }
            }
            return false;
        }

        internal void Draw()
        {
            foreach (var f in fList)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                f.Draw();
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        
    }
}