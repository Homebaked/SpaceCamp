using Microsoft.Xna.Framework;
using Nez;
using SpaceCamp.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nez.Sprites;

namespace SpaceCamp.Entities
{
    public class Unit : Entity
    {
        private DestinationMover mover;

        public float Speed
        {
            get { return mover.Speed; }
            set { mover.Speed = value; }
        }

        public Unit(string name, Sprite sprite, float speed) : base(name)
        {
            this.addComponent(sprite);
            mover = new DestinationMover();
            this.addComponent(mover);
            Speed = speed;
        }

        public void AddDestination(Vector2 dest)
        {
            mover.AddDestination(dest);
        }
    }
}
