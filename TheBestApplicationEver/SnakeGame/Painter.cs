using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Painter
    {
         //постройка границ
        
        public void BuildBoundary()
        {

            for (int i = 0; i < 31; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(1, i);
                Console.Write("|");
                Console.SetCursorPosition(80, i);
                Console.WriteLine("|");
            }
            for (int i = 0; i < 81; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(i,1);
                Console.Write("-");
                Console.SetCursorPosition(i, 30);
                Console.WriteLine("-");
            }

        }

    }
}
