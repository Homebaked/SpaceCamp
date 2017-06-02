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

        public int Width
        {
            get { return Texture.Width; }
        }
        public int Height
        {
            get { return Texture.Height; }
        }

        public GridSquare(int x, int y, int length, GraphicsDevice graphics)
        {
            Texture = new Texture2D(graphics, length, length);
            Texture.SetData(HelperMethods.GenerateColorData(Color.Black, Texture));
            
            Position = new Vector2(x, y);
        }

        public void Draw(SpriteBatch sb)
        {
            int borderWidth = 1;

            Point pos = Position.ToPoint();
            Rectangle topLine = new Rectangle(pos.X, pos.Y, Width, borderWidth);
            Rectangle bottomLine = new Rectangle(pos.X, pos.Y + Height, Width, borderWidth);
            Rectangle leftLine = new Rectangle(pos.X, pos.Y, borderWidth, Height);
            Rectangle rightLine = new Rectangle(pos.X + Width, pos.Y, borderWidth, Height);
            
            sb.Draw(Texture, topLine, Color.Black);
            sb.Draw(Texture, bottomLine, Color.Black);
            sb.Draw(Texture, leftLine, Color.Black);
            sb.Draw(Texture, rightLine, Color.Black);
        }
    }
}
