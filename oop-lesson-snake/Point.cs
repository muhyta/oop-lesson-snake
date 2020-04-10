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

        internal void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
