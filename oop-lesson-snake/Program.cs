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
            Walls walls = new Walls(120, 30);
            walls.Draw();
           
            Point p1 = new Point(3, 4, '*');
            Snake snake = new Snake(p1, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreater = new FoodCreator(118, 27, '@');
            Point food = foodCreater.CreateFood();
            food.Draw();

            while(true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
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
