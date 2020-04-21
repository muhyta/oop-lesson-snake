using System;
using System.Collections.Generic;
using System.Text;

namespace oop_lesson_snake
{
    class Figure
    {
        protected List<Point> pList;

        internal virtual void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach (Point p in pList)
            {
                if (figure.IsHit(p))
                {
                    return true;
                }
            }
            return false;
        }

        internal bool IsHit(Point _p)
        {
            foreach (Point p in pList)
            {
                if (p.IsHit(_p))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
