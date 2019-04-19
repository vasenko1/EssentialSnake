using System;

namespace SnakeGame
{
    class Painter : Fruits
    {
        private int verticalAreaSize;
        private int horizontalAreaSize;
        private int counter;

        public Painter(int verticalAreaSize, int horizontalAreaSize)
        {
            this.verticalAreaSize = verticalAreaSize;
            this.horizontalAreaSize = horizontalAreaSize;

            BuildBoundary();
            DrawFruits();
        }

        //постройка границ
        private void BuildBoundary()
        {
            Console.SetCursorPosition(0,0);
            Console.WriteLine(new string(' ', horizontalAreaSize - 8) + "Score: " + counter);
            Console.WriteLine(new string('-', horizontalAreaSize + 2));

            for (int i = 0; i < verticalAreaSize + 1; i++)
            {
                Console.WriteLine("|" + new string(' ', horizontalAreaSize) + "|");
            }

            Console.WriteLine(new string('-', horizontalAreaSize + 2));
        }

        // отрисовка фруктов на игровом поле
        private void DrawFruits()
        {
            if(isGoodFruitDisplayed == false)
            {
                ShowGoodFruit(horizontalAreaSize, verticalAreaSize - 1);
            }

            if(isBadFruitDisplayed == false)
            {
                ShowBadFruit(horizontalAreaSize, verticalAreaSize - 1);
            }

            counter++;
        }
    }
}
