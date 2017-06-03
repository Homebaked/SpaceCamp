using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace SpaceEngine.UI
{
    public class MainUI : UIElement
    {
        public MainUI(int screenWidth, int screenHeight) : base(new Rectangle(0, 0, screenWidth, screenHeight))
        {
        }
    }
}
