using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Nez;
using Nez.Sprites;
using SpaceCamp.Entities;

namespace SpaceCamp
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Core
    {
        private Scene gameScene;

        public Game1() : base() {}

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            base.Initialize();

            Window.AllowUserResizing = true;
            gameScene = Scene.createWithDefaultRenderer(Color.CornflowerBlue);

            Texture2D blueRobot = gameScene.content.Load<Texture2D>("images/Robots/Side view/robot_blueDrive1");
            Texture2D redRobot = gameScene.content.Load<Texture2D>("images/Robots/Side view/robot_redDrive1");

            Unit robot1 = new Unit(5);
            Unit robot2 = new Unit(5);

            gameScene.addEntity(robot1);
            robot1.addComponent(new Sprite(blueRobot));

            gameScene.addEntity(robot2);
            robot2.addComponent(new Sprite(redRobot));

            robot2.position = new Vector2(200, 200);

            scene = gameScene;

            robot1.SetDestination(new Vector2(700, 300));
        }
    }
}
