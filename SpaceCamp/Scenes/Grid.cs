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
        List<List<GridSquare>> squares;
        int width, height;

        public readonly int squareSize;

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

    public struct GridSquare { };
}
