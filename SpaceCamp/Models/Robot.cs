using System;
using System.Collections.Generic;
using System.Text;
using SpaceEngine.Models;

namespace SpaceCamp.Models
{
    public class Robot : Unit
    {
        public Robot(int x, int y, double speed, int size) : base(x, y, speed, size, Color.Gray)
        {

        }
    }
}
