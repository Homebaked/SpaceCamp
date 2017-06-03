using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SpaceEngine.Models;
using SpaceEngine.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceCamp.UI
{
    public class CampUI : MainUI
    {
        private TextBox SelectedEntityTitle;

        public CampUI(int screenWidth, int screenHeight, SpriteFont font) : base(screenWidth, screenHeight)
        {
            SelectedEntityTitle = new TextBox(new Rectangle(5, (screenHeight - 30), 100, 25), "", font);
            Elements.Add(SelectedEntityTitle);
        }

        public void SetSelectedEntity(Entity entity)
        {
            SelectedEntityTitle.SetText(entity.Name);
        }
    }
}
