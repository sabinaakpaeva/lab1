using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Snake Snake = new Snake();
            wall wall = new wall();
            while (true)
            {
              ConsoleKeyInfo pressKey =  Console.ReadKey();
                if (pressKey.Key == ConsoleKey.UpArrow)
                    Snake.Move(0, -1);
                if (pressKey.Key == ConsoleKey.DownArrow)
                    Snake.Move(0, 1);
                if (pressKey.Key == ConsoleKey.RightArrow)
                    Snake.Move(1, 0);
                if (pressKey.Key == ConsoleKey.LeftArrow)
                    Snake.Move(-1, 0);
                if (pressKey.Key == ConsoleKey.Escape)
                    break;

                Console.Clear();
                Snake.Draw();
                wall.Draw();
                    
            }
        }
    }
}
