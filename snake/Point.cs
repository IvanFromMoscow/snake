using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()
        {}

        public Point(int _x, int _y, char _sym)
        {
            this.x = _x;
            this.y = _y;
            this.sym = _sym;
        }
        public Point(Point p):this(p.x, p.y, p.sym)
        {
           
        }
        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.LEFT)
            {
                this.x -= offset;
            }
            else if (direction == Direction.RIGHT)
            {
                this.x += offset;
            }
            else if(direction == Direction.UP)
            {
                this.y -= offset;
            }
            else
            {
                this.y += offset;
            }
        }

        internal void Clear()
        {
            this.sym = ' ';
            Draw();
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }
    }
}
