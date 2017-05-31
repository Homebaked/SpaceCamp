using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEngine.Models
{
    public class Grid : GameObject
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public int SquareLength { get; private set; }

        public List<List<GridSquare>> SquaresMatrix { get; private set; }

        public List<GridSquare> SquaresList
        {
            get
            {
                List<GridSquare> list = new List<GridSquare>();
                foreach (List<GridSquare> column in SquaresMatrix)
                {
                    list.AddRange(column);
                }
                return list;
            }
        }

        public Grid(int width, int height, int squareLength, GraphicsDevice graphics)
        {
            Width = width;
            Height = height;
            SquareLength = squareLength;

            initializeSquares(graphics);
        }

        override public void Draw(SpriteBatch sb)
        {
            foreach (GridSquare square in SquaresList)
            {
                square.Draw(sb);
            }
        }

        private void initializeSquares(GraphicsDevice graphics)
        {
            SquaresMatrix = new List<List<GridSquare>>();
            for (int x = 0; x < Width; x += SquareLength)
            {
                List<GridSquare> column = new List<GridSquare>();
                for (int y = 0; y < Height; y += SquareLength)
                {
                    GridSquare square = new GridSquare(x, y, SquareLength, graphics);
                    column.Add(square);
                }
                SquaresMatrix.Add(column);
            }
        }


    }
}
