using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nez;
using SpaceCamp.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceCamp.Entities
{
    class GridSquare : Entity
    {
        private readonly int squareSize;
        private readonly Drawer drawer;

        public bool DrawSquare
        {
            get
            {
                return drawer.Draw;
            }
            set
            {
                drawer.Draw = value;
            }
        }

        public GridSquare(Vector2 position, int squareSize)
        {
            this.position = position;
            this.squareSize = squareSize;

            drawer = addComponent(new Drawer(squareSize, squareSize));
            drawer.AddDrawAction(drawSquare);
        }

        private void drawSquare(SpriteBatch batch)
        {
            batch.drawHollowRect(position, squareSize, squareSize, Color.Black);
        }
    }
}
