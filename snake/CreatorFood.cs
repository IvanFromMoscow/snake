using System;

namespace snake
{
    internal class CreatorFood
    {
        private int windowWidth;
        private int windowHeight;
        private char sym;

        Random rnd = new Random();
        public CreatorFood(int winWidth, int winHeight, char _sym)
        {
            this.windowHeight = winHeight;
            this.windowWidth = winWidth;
            this.sym = _sym;
        }

        public Point Create()
        {
            int x = rnd.Next(2, this.windowWidth - 2);
            int y = rnd.Next(2, this.windowHeight - 2);
            return new Point(x, y, this.sym);
        }
        public Point Create(char _sym)
        {
            this.sym = _sym;
            return this.Create();
        }
    }
}