using System;
using System.Collections.Generic;
using System.Text;

namespace oop_lesson_snake
{
    class HorizontalLine
    {
        List<Point> pList;

        internal HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        internal void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
