using System;
using System.Collections.Generic;
using System.Text;

namespace oop_lesson_snake
{
    class VerticalLine : Figure
    {
        internal VerticalLine(int x, int yUp, int yDown, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}
