using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nez;
using Nez.Sprites;
using Nez.Textures;
using SpaceCamp.Scenes;

namespace SpaceCamp.Entities
{
    public class SpaceEntity : Entity
    {
        private readonly Sprite sprite;

        public int Width { get; }
        public int Height { get; }

        public SpaceEntity(string name, 
                           Texture2D texture, 
                           int width, 
                           int height, 
                           Grid grid)
            : base(name)
        {
            int squareSize = grid.SquareSize;
            Width = width;
            Height = height;

            //Scale the sprite so that it fits the grid size of the entity.
            float scale = calculateScale(texture.Width, 
                                            texture.Height, 
                                            Width * squareSize, 
                                            Height * squareSize);
            base.scale = new Vector2(scale, scale);
            sprite = new Sprite(texture);
            this.addComponent(sprite);
        }

        private float calculateScale(int width, 
                                     int height, 
                                     int maxWidth, 
                                     int maxHeight) {
            float widthScale = (float)maxWidth / width;
            float heightScale = (float)maxHeight / height;

            if (widthScale < heightScale) {
                return widthScale;
            }
            else 
            {
                return heightScale;
            }
        }
    }
}
