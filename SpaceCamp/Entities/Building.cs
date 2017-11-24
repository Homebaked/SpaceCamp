using System;
using Microsoft.Xna.Framework.Graphics;
using Nez;
using Nez.Sprites;
using SpaceCamp.Scenes;

namespace SpaceCamp.Entities
{
    public class Building : SpaceEntity
    {
        public Building(string name, 
                        Texture2D texture, 
                        int width, 
                        int height, 
                        Grid grid) 
            : base(name, 
                   texture, 
                   width, 
                   height, 
                   grid) {}
    }
}
