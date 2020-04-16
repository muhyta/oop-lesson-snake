using System;
using System.Collections.Generic;

namespace oop_lesson_snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(2, 3, '*');
            Point p2 = new Point(4, 5, '#');
            Point p3 = new Point(6, 7, '@');
            Point p4 = new Point(8, 9, '%');

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            foreach (Point p in pList)
            {
                p.Draw();
            }

            pList.RemoveAt(0);
            pList.RemoveAt(0);
            pList.RemoveAt(0);
            pList.RemoveAt(0);

            Console.ReadKey();
        }

        
    }
}
