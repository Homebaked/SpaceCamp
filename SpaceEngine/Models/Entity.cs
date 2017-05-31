using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceEngine.Models
{
    abstract public class Entity : GameObject
    {
        #region Properties

        public Texture2D Texture { get; protected set; }

        public Vector2 Position { get; protected set; }

        public Color Color { get; protected set; }
        #endregion

        #region Constructors
        protected Entity(int x, int y, int width, int height, Color color, GraphicsDevice graphics)
        {
            Texture = new Texture2D(graphics, width, height);
            Color = color;
        }
        #endregion

        #region Methods
        abstract public void Step();
        #endregion
    }
}
