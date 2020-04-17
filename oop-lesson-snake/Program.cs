using System;

namespace oop_lesson_snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(2, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine hl1 = new HorizontalLine(5, 10, 8, '+');
            hl1.Draw();

            VerticalLine vl1 = new VerticalLine(5, 8, 10, '+');
            vl1.Draw();

            Console.ReadKey();
        }

        
    }
}
