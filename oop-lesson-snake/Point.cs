using System;
using System.Collections.Generic;
using System.Text;

namespace oop_lesson_snake
{
    class Point
    {
        internal int x;
        internal int y;
        internal char sym;

        internal Point()
        {

        }

        internal Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        internal void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
