using System;
using Nez;
using Nez.Sprites;

namespace SpaceCamp.Entities
{
    public class Building : Entity
    {
        public Building(Sprite sprite)
        {
            this.addComponent(sprite);
        }
    }
}
