using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SpaceCamp.Models;
using SpaceCamp.UI;
using SpaceEngine.Models;
using System.Collections.Generic;

namespace SpaceCamp
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class SpaceCamp : Game
    {
        //Test
        #region Properties

        private Grid grid;

        private CampUI ui;

        private Layer foregroundLayer;
        private Layer backgroundLayer;

        private List<Entity> entities;

        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        private SpriteFont defaultFont;

        private int screenWidth
        {
            get { return GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width; }
            set
            {
                graphics.PreferredBackBufferWidth = value;
                graphics.ApplyChanges();
            }
        }
        private int screenHeight
        {
            get { return GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height; }
            set
            {
                graphics.PreferredBackBufferHeight = value;
                graphics.ApplyChanges();
            }
        }

        #endregion

        public SpaceCamp(int width, int height)
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            screenWidth = width;
            screenHeight = height;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            base.Initialize();

            entities = new List<Entity>();
            initializeLayers();

            grid = new Grid(screenWidth, screenHeight, 20, graphics.GraphicsDevice);
            ui = new CampUI(screenWidth, screenHeight, defaultFont);

            Robot robot = new Robot(0, 0, 2, 20, graphics.GraphicsDevice);
            robot.AssignDestination(new Vector2(500, 500));
            entities.Add(robot);

            Rocket rocket = new Rocket(300, 300, 40, 0, graphics.GraphicsDevice);
            entities.Add(rocket);

            backgroundLayer.Add(grid);
            foregroundLayer.Add(robot);
            foregroundLayer.Add(rocket);

            ui.SetSelectedEntity(rocket);
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            defaultFont = Content.Load<SpriteFont>("Fonts/Default");
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            foreach(Entity entity in entities)
            {
                entity.Step();
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            spriteBatch.Begin();

            backgroundLayer.Draw(spriteBatch);
            foregroundLayer.Draw(spriteBatch);
            ui.Draw(spriteBatch);

            spriteBatch.End();

            base.Draw(gameTime);
        }

        protected void initializeLayers()
        {
            backgroundLayer = new Layer();
            foregroundLayer = new Layer();
        }
    }
}
