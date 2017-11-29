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
        private readonly float _width, _height;

        private SpriteBatch spriteBatch;

        private readonly List<Action<SpriteBatch>> drawActions;

        public override float width
        {
            get
            {
                return _width;
            }
        }

        public override float height
        {
            get
            {
                return _height;
            }
        }

        public Drawer(float width, float height)
        {
            this._width = width;
            this._height = height;
            drawActions = new List<Action<SpriteBatch>>();
        }

        public void AddDrawAction(Action<SpriteBatch> action)
        {
            drawActions.Add(action);
        }

        public override void render(Graphics graphics, Camera camera)
        {
            spriteBatch = new SpriteBatch(graphics.batcher.graphicsDevice);
            spriteBatch.Begin();
            foreach(Action<SpriteBatch> drawAction in drawActions)
            {
                drawAction(spriteBatch);
            }
            spriteBatch.End();
        }
    }
}
