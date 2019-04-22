using System;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Painter painter = new Painter(20, 80);


            Control control = new Control();
            control.Move(true, 30, 20);
            
            Console.ReadKey();
        }
    }
}
