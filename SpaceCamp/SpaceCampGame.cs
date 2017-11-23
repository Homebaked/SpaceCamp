using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Nez;
using Nez.Sprites;
using Nez.UI;
using SpaceCamp.Entities;
using SpaceCamp.Scenes;
using SpaceCamp.UI;

namespace SpaceCamp
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Core
    {
        private Grid grid;

        public Game1(int width, int height) : base(width: width, height: height) { }

        protected override void Initialize()
        {
            base.Initialize();

            Window.AllowUserResizing = true;
            grid = new Grid(0, 0, 0, Color.CornflowerBlue);

            Texture2D blueRobotTexture = grid.content.Load<Texture2D>("images/Robots/Side view/robot_blueDrive1");
            Texture2D redRobotTexture = grid.content.Load<Texture2D>("images/Robots/Side view/robot_redDrive1");
            Texture2D rocketTexture = grid.content.Load<Texture2D>("images/rocket");

            Unit lenny = new Unit("Lenny", new Sprite(blueRobotTexture), 100);
            Unit chuck = new Unit("Chuck", new Sprite(redRobotTexture), 200);

            Building rocket = new Building(new Sprite(rocketTexture));

            grid.addEntity(lenny);
            grid.addEntity(chuck);
            grid.addEntity(rocket);
           
            chuck.position = new Vector2(200, 200);
            lenny.AddDestination(new Vector2(700, 300));
            chuck.AddDestination(new Vector2(900, 1500));
            rocket.position = new Vector2(1200, 700);

            //UICanvas gridInterface = new GridInterface(grid);
            //grid.addSceneComponent(gridInterface);

            scene = grid;
        }
    }
}