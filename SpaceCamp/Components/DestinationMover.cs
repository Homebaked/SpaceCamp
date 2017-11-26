using Microsoft.Xna.Framework;
using Nez;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceCamp.Components
{
    public class DestinationMover : Component, IUpdatable
    {
        private List<Vector2> destinations;
        private Vector2 position;

        public float Speed { get; set; }

        public DestinationMover()
        {
            destinations = new List<Vector2>();
        }

        public void AddDestination(Vector2 dest)
        {
            destinations.Add(dest);
        }

        public void update()
        {
            if (destinations.Count > 0)
            {
                Vector2 dest = destinations[0];
                float distance = Speed * Time.deltaTime;
                if ((dest - position).Length() <= distance)
                {
                    position = dest;
                    destinations.RemoveAt(0);
                }
                else
                {
                    Vector2 direction = dest - position;
                    direction.Normalize();
                    position += direction * distance;
                }
                entity.position = this.position;
            }
        }
        public override void onAddedToEntity()
        {
            position = entity.position;
            base.onAddedToEntity();
        }
    }
}