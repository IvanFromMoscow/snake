using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Walls
    {
        List<Figure> walls;

        public Walls(int winHeight, int winWidth)
        {
            walls = new List<Figure>();
            HorizontalLine up = new HorizontalLine(0, winWidth - 2, 0, '-');
            HorizontalLine down = new HorizontalLine(0, winWidth - 2, winHeight - 2, '-');
            VerticalLine left = new VerticalLine(0, winHeight - 2, 0, '+');
            VerticalLine right = new VerticalLine(0, winHeight - 2, winWidth - 2, '+');
            walls.Add(up);
            walls.Add(down);
            walls.Add(left);
            walls.Add(right);
        }
        public bool isHit(Figure fig)
        {
            foreach(Figure w in walls)
            {
                if(w.isHit(fig))
                {
                    return true;
                }
            }
            return false;
        }
        public void Draw()
        {
            foreach(Figure w in walls)
            {
                w.Draw();
            }
        }
    }
}
