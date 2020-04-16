using System;

namespace oop_lesson_snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            Func2(x);
            Console.WriteLine("Call Func2. x = "+x);

            x = 1;
            Func3(x);
            Console.WriteLine("Call Func3. x = " + x);

            Point p1 = new Point(1,3,'*');
            Move(p1,10,10);
            Console.WriteLine("Call Move. p1.x = " + p1.x + ", p1.y = " + p1.y);

            Point p2 = new Point(3, 5, '#');
            p1 = p2;
            p2.x = 8;
            p2.y = 8;
            Console.WriteLine("p1.x = " + p1.x + ", p1.y = " + p1.y);

            p1 = new Point(1, 3, '*');
            Reset(p1);
            Console.WriteLine("Call Reset. p1.x = " + p1.x + ", p1.y = " + p1.y);

            Console.ReadKey();
        }

        private static void Reset(Point p)
        {
            p = new Point();
        }

        private static void Move(Point p, int dx, int dy)
        {
            p.x += dx;
            p.y += dy;
        }

        private static void Func3(int x)
        {
            x = x + 1;
        }

        private static void Func2(int value)
        {
            value = value + 1;
        }
    }
}
