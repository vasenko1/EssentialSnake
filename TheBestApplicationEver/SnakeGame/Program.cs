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

                             
            //draw
            Painter painter = new Painter(25, 60);
            painter.BuildBoundary();

            //move
            Control control = new Control();
            control.Move(true, 35, 10);
            Console.ReadKey();
        }
    }
}
