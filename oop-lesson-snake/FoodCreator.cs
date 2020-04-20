using System;

namespace oop_lesson_snake
{
    internal class FoodCreator
    {
        private int maxWidth;
        private int maxHeight;
        private char sym;

        Random random = new Random();

        public FoodCreator(int maxWidth, int maxHeight, char sym)
        {
            this.maxWidth = maxWidth;
            this.maxHeight = maxHeight;
            this.sym = sym;
        }

        internal Point CreateFood()
        {
            return new Point(random.Next(2,maxWidth), random.Next(2,maxHeight), sym);
        }
    }
}