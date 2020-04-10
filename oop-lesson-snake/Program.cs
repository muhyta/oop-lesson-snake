using System;

namespace oop_lesson_snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(2, 3, '*');
            p1.Draw();

            Point p2 = new Point(4,5,'#');
            p2.Draw();

            Console.ReadKey();
        }

        
    }
}
