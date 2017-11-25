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
        public int Width { get; }
        public int Height { get; }

        public SpaceEntity(string name, 
                           Texture2D texture, 
                           int width, 
                           int height, 
                           Grid grid)
            : base(name)
        {
            int squareSize = grid.squareSize;
            Width = width;
            Height = height;

            //Scale the sprite so that it fits the grid size of the entity.
            float scale = calculateScale(texture.Width, 
                                            texture.Height, 
                                            Width * squareSize, 
                                            Height * squareSize);
            int subTextureWidth = (int)(texture.Width * scale);
            int subTextureHeight = (int)(texture.Height * scale);
            Rectangle rect = new Rectangle(0, 
                                           0, 
                                           subTextureWidth, 
                                           subTextureHeight);
            this.addComponent(new Sprite(new Subtexture(texture, rect)));
        }

        private float calculateScale(int width, 
                                     int height, 
                                     int maxWidth, 
                                     int maxHeight) {
            float widthScale = 1, heightScale = 1;

            if (width > maxWidth) {
                widthScale = (float)maxWidth / width;
            }

            if (height > maxHeight) {
                heightScale = (float)maxHeight / height;
            }

            if (widthScale < 1 && widthScale < heightScale) {
                return widthScale;
            }
            else 
            {
                return heightScale;
            }
        }
    }
}
