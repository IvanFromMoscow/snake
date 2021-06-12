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
            //console.clear();
            //console.setwindowsize(1, 1);
            //console.setbuffersize(80, 80); 
            Console.SetBufferSize(800, 800);
           
            HorizontalLine hl_up = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine hl_down = new HorizontalLine(0, 78, 24, '+');
            
            hl_up.Draw();
            hl_down.Draw();

            VerticalLine vl_left = new VerticalLine(0, 24, 0, '+');
            VerticalLine vl_right = new VerticalLine(0, 24, 78, '+');
            vl_left.Draw();
            vl_right.Draw();

            Point p = new Point(4, 5, '*');
            Snake sn = new Snake(p, 3, Direction.RIGHT);
            sn.Draw();
            CreatorFood cf = new CreatorFood(78, 24, '$');
            Point food = cf.Create();
            food.Draw();
            while (true)
            {
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
        }
        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }
    }
}
