using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SnakeGame
{
    class Control
    {
        bool WallHit = false;
        char head = 'O';
        int gameSpeed = 100;

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
                WallHit = DidSnakeHitWall(x, y);
                if (WallHit)
                {
                    ISGameON = false;
                    Console.SetCursorPosition(30, 20);
                    Console.WriteLine("Game Over");
                }
                if (Console.KeyAvailable) move = Console.ReadKey().Key;
                Thread.Sleep(gameSpeed);

            } while (ISGameON);
         
        }
        private static bool DidSnakeHitWall(int x, int y)
        {
            if (x == 1  || x == 60 || y == 0 || y == 26) 
            return true; return false;
        }



    }
}
