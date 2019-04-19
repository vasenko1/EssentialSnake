using System;

namespace SnakeGame
{
    class Fruits
    {
        protected bool isGoodFruitDisplayed = false;
        protected bool isBadFruitDisplayed = false;
        private int positionX;
        private int positionY;
        private Random random = new Random();

        // создание хорошего фрукта
        protected void ShowGoodFruit(int positionX, int positionY)
        {
            this.positionX = random.Next(1, positionX - 1);
            this.positionY = random.Next(1, positionY - 1);

            Console.SetCursorPosition(this.positionX, this.positionY);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("@");
            Console.ForegroundColor = ConsoleColor.White;

            isGoodFruitDisplayed = true;
        }

        // создание плохого фрукта
        protected void ShowBadFruit(int positionX, int positionY)
        {
            this.positionX = random.Next(1, positionX - 1);
            this.positionY = random.Next(1, positionY - 1);

            Console.SetCursorPosition(this.positionX, this.positionY);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("@");
            Console.ForegroundColor = ConsoleColor.White;

            isBadFruitDisplayed = true;
        }
    }
}
