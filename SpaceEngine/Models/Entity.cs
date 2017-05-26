using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEngine.Models
{
    abstract public class Entity : GameObject
    {
        #region Properties

        public Rectangle Rect { get; protected set; }

        private Vector2 _position;
        public Vector2 Position
        {
            get
            {
                return _position;
            }
            protected set
            {
                _position = value;
                Rect = new Rectangle((int)_position.X, (int)_position.Y, Rect.Width, Rect.Height);
            }
        }

        public Color Color { get; protected set; }
        #endregion

        #region Constructors
        protected Entity(int x, int y, int width, int height, Color color)
        {
            Rect = new Rectangle(x, y, width, height);
            Color = color;
        }

        protected Entity(Rectangle rect)
        {
            Rect = rect;
        }
        #endregion

        #region Methods
        abstract public void Step();
        #endregion
    }
}
