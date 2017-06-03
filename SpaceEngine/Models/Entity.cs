using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SpaceEngine.Utilities;

namespace SpaceEngine.Models
{
    abstract public class Entity : GameObject
    {
        #region Properties

        public string Name { get; protected set; }
        public Texture2D Texture { get; protected set; }
        public Vector2 Position { get; protected set; }
        public Color Color { get; protected set; }
        #endregion

        #region Constructors
        protected Entity(int x, int y, int width, int height, Color color, GraphicsDevice graphics)
        {
            Texture = new Texture2D(graphics, width, height);
            Color = color;

            Position = new Vector2(x, y);
        }
        #endregion

        #region Methods
        abstract public void Step();

        public override void Draw(SpriteBatch sb)
        {
            Texture.SetData(HelperMethods.GenerateColorData(Color, Texture));
            sb.Draw(Texture, Position, Color);
        }
        #endregion
    }
}
