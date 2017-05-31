using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceEngine.Interfaces
{
    interface Clickable
    {
        Texture2D Texture { get; }

        void HandleClick();
    }
}
