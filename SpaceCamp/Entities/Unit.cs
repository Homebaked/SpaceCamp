using Microsoft.Xna.Framework;
using Nez;
using SpaceCamp.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceCamp.Entities
{
    public class Unit : Entity
    {
        private UnitMover mover;
        private Vector2 destination;

        public float Speed { get; set; }

        public Unit(float speed)
        {
            Speed = speed;
            mover = new UnitMover();
            this.addComponent(mover);
        }

        public void SetDestination(Vector2 dest)
        {
            destination = dest;
        }

        public override void update()
        {
            Vector2 direction = (destination - position);
            direction.Normalize();
            mover.Speed = Speed;
            mover.Direction = direction;

            base.update();
        }
    }
}
