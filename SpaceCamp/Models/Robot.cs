using System;
using System.Collections.Generic;
using System.Text;
using SpaceEngine.Models;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceCamp.Models
{
    public class Robot : Unit
    {
        public Robot(int x, int y, double speed, int size, GraphicsDevice graphics) : base(x, y, speed, size, Color.Gray, graphics)
        {

        }
    }
}
