using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Nez;
namespace SpaceCamp.Scenes
{
    public class Grid : Scene
    {
        List<List<GridSquare>> squares;
        int width, height, squareSize;

        public Entity selectedEntity { get; private set; }

        public Grid(int width, int height, int squareSize, Color? background = null) : base() {
            if (background.HasValue) { base.clearColor = background.Value; }
            base.addRenderer(new DefaultRenderer());

            this.width = width;
            this.height = height;
            this.squareSize = squareSize;

            squares = new List<List<GridSquare>>();
            for (int i = 0; i < width; i++) {
                List<GridSquare> column = new List<GridSquare>();
                for (int j = 0; j < height; j++) {
                    column.Add(new GridSquare());
                }
                squares.Add(column);
            }
        }
    }

    public struct GridSquare { };
}
