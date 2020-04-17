using System;
using System.Collections.Generic;
using System.Text;

namespace oop_lesson_snake
{
    class Figure
    {
        protected List<Point> pList;

        internal void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
