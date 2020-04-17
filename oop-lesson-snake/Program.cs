using System;

namespace oop_lesson_snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(120, 30);
            HorizontalLine hl1 = new HorizontalLine(0, 119, 0, '+');
            hl1.Draw();
            HorizontalLine hl2 = new HorizontalLine(0, 119, 28, '+');
            hl2.Draw();
            VerticalLine vl1 = new VerticalLine(0, 0, 28, '+');
            vl1.Draw();
            VerticalLine vl2 = new VerticalLine(119, 0, 28, '+');
            vl2.Draw();
            Point p1 = new Point(2, 3, '*');
            p1.Draw();
            Point p2 = new Point(4, 5, '#');
            p2.Draw();
            Console.ReadKey();
        }

        
    }
}
