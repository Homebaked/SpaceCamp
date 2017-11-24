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
    public class SpaceCampGame : Core
    {
        private const int SQUARE_SIZE = 10;

        private Grid grid;
        private int width, height;

        public SpaceCampGame(int width, int height) : base(width: width, height: height) {
            this.width = width;
            this.height = height;
        }

        protected override void Initialize()
        {
            base.Initialize();

            Window.AllowUserResizing = true;

            int gridWidth = width / SQUARE_SIZE;
            int gridHeight = height / SQUARE_SIZE;

            grid = new Grid(gridWidth, gridHeight, SQUARE_SIZE, Color.CornflowerBlue);

            Texture2D blueRobotTexture = grid.content.Load<Texture2D>("images/Robots/Side view/robot_blueDrive1");
            Texture2D redRobotTexture = grid.content.Load<Texture2D>("images/Robots/Side view/robot_redDrive1");
            Texture2D rocketTexture = grid.content.Load<Texture2D>("images/rocket");

            Unit lenny = grid.AddUnit("Lenny", blueRobotTexture, 100);
            Unit chuck = grid.AddUnit("Chuck", redRobotTexture, 200);

            Building rocket = grid.AddBuilding("Rocket", rocketTexture, 1, 2);

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