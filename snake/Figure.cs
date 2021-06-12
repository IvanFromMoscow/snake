using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Figure
    {
        protected List<Point> pList;

        public virtual void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

        public bool isHit(Figure f)
        {
            foreach(Point p in pList)
            {
                if(f.isHit(p))
                {
                    return true;
                }
            }
            return false;
        }

        public bool isHit(Point p)
        {
            foreach (Point _p in pList)
            {
                if(_p.isHit(p))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
