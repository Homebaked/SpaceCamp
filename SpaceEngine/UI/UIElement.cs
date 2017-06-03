using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceEngine.UI
{
    public class UIElement
    {
        public Rectangle Rect { get; private set; }
        public List<UIElement> Elements { get; private set; }

        public UIElement(Rectangle rect)
        {
            Rect = rect;
            Elements = new List<UIElement>();
        }

        public virtual void Draw(SpriteBatch sb)
        {
            foreach(UIElement element in Elements)
            {
                element.Draw(sb);
            }
        }
    }
}
