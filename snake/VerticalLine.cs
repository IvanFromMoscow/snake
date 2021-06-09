using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class VerticalLine : Figure
    {
     
        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int i = yUp; i <= yDown; i++)
            {
                pList.Add(new Point(x, i, sym));
            }
        }
    }
}
