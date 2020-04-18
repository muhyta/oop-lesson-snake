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

        internal Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        internal Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        internal void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.UP:
                    y = y - offset;
                    break;
                case Direction.DOWN:
                    y = y + offset;
                    break;
                case Direction.LEFT:
                    x = x - offset;
                    break;
                case Direction.RIGHT:
                    x = x + offset;
                    break;
            }
        }

        internal void Clear()
        {
            sym = ' ';
            Draw();
        }

        internal void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
