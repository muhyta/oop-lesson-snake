using System;
using System.Threading;

namespace oop_lesson_snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(120, 30);
            Console.CursorVisible = false;
            HorizontalLine hl1 = new HorizontalLine(0, 119, 0, '+');
            hl1.Draw();
            HorizontalLine hl2 = new HorizontalLine(0, 119, 28, '+');
            hl2.Draw();
            VerticalLine vl1 = new VerticalLine(0, 0, 28, '+');
            vl1.Draw();
            VerticalLine vl2 = new VerticalLine(119, 0, 28, '+');
            vl2.Draw();
            
            Point p1 = new Point(3, 4, '*');
            Snake snake = new Snake(p1, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreater = new FoodCreator(118, 27, '@');
            Point food = foodCreater.CreateFood();
            food.Draw();

            while(true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressed_key = Console.ReadKey();
                    if (pressed_key.Key == ConsoleKey.Escape) break;
                    snake.HandleKey(pressed_key.Key);
                }
                if (snake.Eat(food))
                {
                    food = foodCreater.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);
            }
            
            
        }

        
    }
}
