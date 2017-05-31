using System;
using System.Collections.Generic;
using System.Text;
using SpaceEngine.Models;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceCamp.Models
{
    public class Rocket : Building
    {
        public List<Unit> Passangers { get; private set; }

        public Rocket(int x, int y, int size, int robots, GraphicsDevice graphics) : base(x, y, size, Color.Green, graphics)
        {
            Passangers = new List<Unit>();
            for (int i = 0; i < robots; i++)
            {
                Passangers.Add(new Robot(x, y, 2, 10, graphics));
            }
        }
    }
}
