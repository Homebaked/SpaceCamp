using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEngine.Interfaces
{
    interface Clickable
    {
        Rectangle Rect { get; }

        void HandleClick();
    }
}
