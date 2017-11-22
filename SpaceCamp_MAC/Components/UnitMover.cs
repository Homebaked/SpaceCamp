using Microsoft.Xna.Framework;
using Nez;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceCamp.Components
{
    public class UnitMover : Component, IUpdatable
    {
        public float Speed { get; set;}
        public Vector2 Direction { get; set; }

        public UnitMover()
        {
            Speed = 0;
            Direction = Vector2.Zero;
        }

        public void update()
        {
            entity.position += Direction * Speed * Time.deltaTime;
        }
    }
}
