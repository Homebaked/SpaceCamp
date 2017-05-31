using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SpaceEngine.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEngine.Models
{
    public class GridSquare
    {
        public Texture2D Texture { get; private set; }
        public Vector2 Position { get; private set; }

        public GridSquare(int x, int y, int length, GraphicsDevice graphics)
        {
            Texture = new Texture2D(graphics, length, length);
            Position = new Vector2(x, y);
        }

        public void Draw(SpriteBatch sb)
        {
            Texture.SetData(HelperMethods.GenerateColorData(Color.Black, Texture));
            sb.Draw(Texture, Position, Color.White);
        }
    }
}
