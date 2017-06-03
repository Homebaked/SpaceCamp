using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SpaceEngine.Interfaces;

namespace SpaceEngine.Models
{
    public class Building : Entity, Clickable
    {
        public Building(int x, int y, int size, Color color, GraphicsDevice graphics) : base(x, y, size, size, color, graphics) { }

        public void HandleClick()
        {
            throw new NotImplementedException();
        }

        override public void Step()
        {
            //Do nothing
        }
    }
}
