using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Control
    {
        bool WallHit = false;
        char head = '*';

       ConsoleKey move = Console.ReadKey().Key;

        public void Move(bool ISGameON, int x,int y)
        {
            do
            {
                switch (move)
                {
                    case ConsoleKey.LeftArrow:
                        Console.SetCursorPosition(x, y);
                        Console.Write(" ");
                        x--;
                        break;
                    case ConsoleKey.UpArrow:
                        Console.SetCursorPosition(x, y);
                        Console.Write(" ");
                        y--;
                        break;
                    case ConsoleKey.RightArrow:
                        Console.SetCursorPosition(x, y);
                        Console.Write(" ");
                        x++;
                        break;
                    case ConsoleKey.DownArrow:
                        Console.SetCursorPosition(x, y);
                        Console.Write(" ");
                        y++;
                        break;

                }
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(head);
                                     
            } while (ISGameON);
        }


        //приватный метод если змейка ударилсь об границу
        //значения по координатам

    }
}
