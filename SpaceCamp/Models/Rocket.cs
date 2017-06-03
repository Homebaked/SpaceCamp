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
        public List<Unit> Passengers { get; private set; }

        public Rocket(int x, int y, int size, int robots, GraphicsDevice graphics) : base(x, y, size, Color.Green, graphics)
        {
            Name = "Rocket";
            Passengers = new List<Unit>();
            for (int i = 0; i < robots; i++)
            {
                Passengers.Add(new Robot(x, y, 2, 10, graphics));
            }
        }
    }
}
