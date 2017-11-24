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
            int scale = (int)calculateScale(texture.Width, 
                                            texture.Height, 
                                            Width * squareSize, 
                                            Height * squareSize);
            Rectangle rect = new Rectangle(0, 
                                           0, 
                                           scale * texture.Width, 
                                           scale * texture.Height);
            this.addComponent(new Sprite(new Subtexture(texture, rect)));
        }

        private float calculateScale(int width, 
                                     int height, 
                                     int maxWidth, 
                                     int maxHeight) {
            float widthScale = 1, heightScale = 1;

            if (width > maxWidth) {
                widthScale = width / maxWidth;
            }

            if (height > maxHeight) {
                heightScale = height / maxHeight;
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
