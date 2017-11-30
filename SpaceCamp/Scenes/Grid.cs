using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nez;
using SpaceCamp.Entities;

namespace SpaceCamp.Scenes
{
    public class Grid : Scene
    {
        private List<List<GridSquare>> squares;
        private int width, height;
        private bool draw;

        public readonly int SquareSize;

        public Entity selectedEntity { get; private set; }

        public Grid(int width, int height, int squareSize, Color? background = null, bool draw = false) : base() {
            this.draw = draw;

            if (background.HasValue) { base.clearColor = background.Value; }
            base.addRenderer(new DefaultRenderer());

            this.width = width;
            this.height = height;
            this.SquareSize = squareSize;

            squares = new List<List<GridSquare>>();
            Vector2 position = new Vector2();
            for (int i = 0; i < width; i++) {
                position.X = i * SquareSize;
                List<GridSquare> column = new List<GridSquare>();
                for (int j = 0; j < height; j++) {
                    position.Y = j * SquareSize;
                    GridSquare square = new GridSquare(position, SquareSize);
                    square.DrawSquare = draw;
                    this.addEntity(square);
                    column.Add(square);
                }
                squares.Add(column);
            }
        }

        public GridSquare GetSquare(int x, int y)
        {
            return squares[x][y];
        }

        public Unit AddUnit(string name, Texture2D texture, float speed) {
            Unit unit = new Unit(name, texture, speed, this);
            this.addEntity(unit);
            return unit;
        }
        public Building AddBuilding(string name, Texture2D texture, int width, int height) {
            Building building = new Building(name, texture, width, height, this);
            this.addEntity(building);
            return building;
        }
    }
}
