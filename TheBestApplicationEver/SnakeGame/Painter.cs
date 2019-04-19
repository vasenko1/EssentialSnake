using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Painter
    {
        private int verticalAreaSize;
        private int horizontalAreaSize;
         //постройка границ

       public Painter(int verticalAreaSize, int horizontalAreaSize)
        {
            this.verticalAreaSize = verticalAreaSize;
            this.horizontalAreaSize = horizontalAreaSize;
        }
        
        public void BuildBoundary()
        {
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(new string('-', horizontalAreaSize));

            for (int i = 0; i < verticalAreaSize + 1; i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write("|");
                Console.SetCursorPosition(horizontalAreaSize, i);
                Console.WriteLine("|");
            }

            Console.WriteLine(new string('-', horizontalAreaSize + 1));
        }
    }
}
