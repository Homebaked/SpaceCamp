using Microsoft.Xna.Framework;
using Nez;
using SpaceCamp.Entities;
using SpaceCamp.Scenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceCamp.Components
{
    public class GridMover : Component, IUpdatable
    {
        private readonly Grid grid;

        private List<GridSquare> destinations;
        private Vector2 position;

        public float Speed { get; set; }

        public GridMover(Grid grid)
        {
            this.grid = grid;
            destinations = new List<GridSquare>();
        }

        public void AddDestination(GridSquare dest)
        {
            destinations.Add(dest);
        }

        public void update()
        {
            if (destinations.Count > 0)
            {
                Vector2 dest = destinations[0].GetCenter();
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