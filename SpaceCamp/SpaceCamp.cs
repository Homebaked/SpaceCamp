using OpenTK;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceCamp
{
    class SpaceCamp : GameWindow
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Title = "Space Camp";
        }
    }
}
