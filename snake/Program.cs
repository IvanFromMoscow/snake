using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(800, 800);
            Walls walls = new Walls(26, 80);
            walls.Draw();

            Snake sn = new Snake(new Point(4, 5, '*'), 3, Direction.RIGHT);
            sn.Draw();
            CreatorFood cf = new CreatorFood(50, 15, '$');
            Point food = cf.Create();
            food.Draw();
            while (true)
            {
                if(walls.isHit(sn) || sn.isHitTail())
                {
                    break;
                }
                if (sn.Eat(food))
                {

                    food = cf.Create('$');
                    food.Draw();
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    sn.HandleKey(key.Key);
                }

                Thread.Sleep(100);
                sn.Move();
            }
            Fin();
        }
        static void Fin()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            new HorizontalLine(20, 60, 5, '+').Draw();
            new VerticalLine(5, 15, 20, '+').Draw();
            new VerticalLine(5, 15, 60, '+').Draw();
            new HorizontalLine(20, 60, 15, '+').Draw();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(35, 7);
            Console.WriteLine("GAME OVER!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }
    }
}
