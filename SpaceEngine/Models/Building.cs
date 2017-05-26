using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEngine.Models
{
    public class Building : Entity, Clickable
    {
        public Building(int x, int y, int size, Color color) : base(x, y, size, size, color) { }

        override public void Step()
        {
            //Do nothing
        }

        override public void Draw(Graphics graphics)
        {
            graphics.FillRectangle(new SolidBrush(Color), Rect);
        }

        public void HandleClick()
        {
            throw new NotImplementedException();
        }
    }
}
