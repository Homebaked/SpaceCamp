using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceEngine.UI
{
    public class TextBox : UIElement
    {
        public string Text { get; private set; }
        public SpriteFont Font { get; private set; }

        public TextBox(Rectangle rect, string text, SpriteFont font) : base(rect)
        {
            Text = text;
            Font = font;
        }

        public override void Draw(SpriteBatch sb)
        {
            sb.DrawString(Font, Text, new Vector2(Rect.X, Rect.Y), Color.Black);
        }
        public void SetText(string text)
        {
            Text = text;
        }
    }
}
