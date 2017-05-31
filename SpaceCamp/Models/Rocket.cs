using System;
using System.Collections.Generic;
using System.Text;
using SpaceEngine.Models;

namespace SpaceCamp.Models
{
    class Rocket
    {
        public List<Unit> Passangers { get; private set; }

        public Rocket(int x, int y, int size, int robots) : base(x, y, size, Color.Green)
        {
            Passangers = new List<Unit>();
            for (int i = 0; i < robots; i++)
            {
                Passangers.Add(new Robot(x, y, 2, 10));
            }
        }
    }
}
