using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int lenght, Direction _direction)
        {
            this.direction = _direction;
            pList = new List<Point>();
            for(int i=0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }

        }

        public void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextHead();
            pList.Add(head);

            tail.Clear();
            Draw();
        }


        public void HandleKey(ConsoleKey key)
        {
            if(key == ConsoleKey.LeftArrow)
            {
                direction = Direction.LEFT;
            }
            if (key == ConsoleKey.RightArrow)
            {
                direction = Direction.RIGHT;
            }
            if (key == ConsoleKey.UpArrow)
            {
                direction = Direction.UP;
            }
            if(key == ConsoleKey.DownArrow)
            {
                direction = Direction.DOWN;
            }
        }
        private Point GetNextHead()
        {
            Point head = pList.Last();

            Point nextHead = new Point(head);
            nextHead.Move(1, this.direction);
            return nextHead;
        }

        public bool Eat(Point food)
        {
            Point head = GetNextHead();
            if (head.isHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            return false;
        }

        public bool isHitTail()
        {
            Point head = GetNextHead();
            for(int i=0; i < pList.Count - 2; i++)
            {
                if (head.isHit(pList[i]))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
