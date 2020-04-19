using System;
using System.Collections.Generic;
using System.Text;

namespace oop_lesson_snake
{
    class Snake : Figure
    {
        Direction direction;

        internal Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();

            for (int i = 0; i< length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList[0];
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        private Point GetNextPoint()
        {
            Point head = pList[pList.Count - 1];
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        internal void HandleKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    direction = Direction.UP;
                    break;
                case ConsoleKey.DownArrow:
                    direction = Direction.DOWN;
                    break;
                case ConsoleKey.LeftArrow:
                    direction = Direction.LEFT;
                    break;
                case ConsoleKey.RightArrow:
                    direction = Direction.RIGHT;
                    break;
            }
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.AbsorbBy(head);
                pList.Add(food);
                return true;
            }
            else 
                return false;
        }
    }
}
