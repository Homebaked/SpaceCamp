using Microsoft.Xna.Framework;
using Nez;
using SpaceCamp.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nez.Sprites;
using Microsoft.Xna.Framework.Graphics;
using SpaceCamp.Scenes;

namespace SpaceCamp.Entities
{
    public class Unit : SpaceEntity
    {
        private GridMover mover;

        public float Speed
        {
            get { return mover.Speed; }
            set { mover.Speed = value; }
        }

        public Unit(string name, 
                    Texture2D texture, 
                    float speed,
                    Grid grid) 
            : base(name, texture, 1, 1, grid)
        {
            mover = new GridMover(grid);
            this.addComponent(mover);
            Speed = speed;
        }

        public void AddDestination(GridSquare dest)
        {
            mover.AddDestination(dest);
        }
    }
}
