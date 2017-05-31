using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;
using SpaceEngine.Utilities;

namespace SpaceEngine.Models
{
    public class Unit : Entity
    {
        public double Speed { get; protected set; }
        public Vector2 Destination { get; protected set; }

        public Unit(int x, int y, double speed, int size, Color color, GraphicsDevice graphics) : base(x, y, size, size, color, graphics)
        {
            Speed = speed;

            Destination = Position;
        }

        override public void Step()
        {
            if (Destination != Position)
            {
                if ((Destination - Position).Length() < Speed)
                {
                    Position = Destination;
                }
                else
                {
                    Vector2 direction = Vector2.Normalize(Destination - Position);
                    Vector2 velocity = (float)Speed * direction;
                    Position = Position + velocity;
                }
            }

        }

        override public void Draw(SpriteBatch sb)
        {
            Texture.SetData(HelperMethods.GenerateColorData(Color, Texture));
            sb.Draw(Texture, Position, Color);
        }

        public void AssignDestination(Vector2 destination)
        {
            Destination = destination;
        }
    }
}
