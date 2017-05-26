using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEngine.Models
{
    public class GridSquare
    {
        public Rectangle Rect { get; private set; }

        public GridSquare(int x, int y, int length)
        {
            Rect = new Rectangle(x, y, length, length);
        }

        public void Draw(Graphics graphics)
        {
            graphics.FillRectangle(Pens.White.Brush, Rect);
            graphics.DrawRectangle(Pens.Black, Rect);
        }
    }
}
