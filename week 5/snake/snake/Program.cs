using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        public static Snake snake;
        public static wall wall;
        int d=0;
        enum Direction { right, left, up, down };
        static void Move()
        {
            while (true)
            {
                if (d == 0)
                    snake.Move(1, 0);
                if (d == 1)
                    snake.Move(-1, 0);
                if (d == 2)
                    snake.Move(0, -1);
                if (d == 3)
                    snake.Move(0, 1);
                break;
            }
        }

        static void Main(string[] args)
        {
            Snake Snake = new Snake();
            wall wall = new wall();
            Move();
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
