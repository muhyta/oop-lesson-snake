using System;
using System.Collections.Generic;
using System.Text;

namespace oop_lesson_snake
{
    class Snake : Figure
    {
        internal Snake(Point tail, int length, Direction direction)
        {
            pList = new List<Point>();

            for (int i = 0; i< length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }
    }
}
