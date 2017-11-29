using Microsoft.Xna.Framework.Graphics;
using Nez;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceCamp.Components
{
    class Drawer : RenderableComponent
    {
        private SpriteBatch spriteBatch;

        private readonly List<Action<SpriteBatch>> drawActions;

        public Drawer()
        {
            drawActions = new List<Action<SpriteBatch>>();
        }

        public void AddDrawAction(Action<SpriteBatch> action)
        {
            drawActions.Add(action);
        }

        public override void render(Graphics graphics, Camera camera)
        {
            spriteBatch = new SpriteBatch(graphics.batcher.graphicsDevice);
            foreach(Action<SpriteBatch> drawAction in drawActions)
            {
                drawAction(spriteBatch);
            }
        }
    }
}
