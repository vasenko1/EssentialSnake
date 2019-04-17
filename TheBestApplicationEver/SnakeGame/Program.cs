using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Program
    {
        
        static void Main(string[] args)
        {

            int xPosition = 35;
            int yPosition = 20;
           
            Console.SetCursorPosition(xPosition, yPosition);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*");

            //draw
            Painter painter = new Painter();
            painter.BuildBoundary();

            //move
            Control control = new Control();
            control.Move(true, 35, 20);
            Console.ReadKey();
        }
    }
}
