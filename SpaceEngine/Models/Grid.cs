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

        public Grid(int width, int height, int squareLength)
        {
            Width = width;
            Height = height;
            SquareLength = squareLength;

            initializeSquares();
        }

        override public void Draw(Graphics graphics)
        {
            foreach (GridSquare square in SquaresList)
            {
                square.Draw(graphics);
            }
        }

        private void initializeSquares()
        {
            SquaresMatrix = new List<List<GridSquare>>();
            for (int x = 0; x < Width; x += SquareLength)
            {
                List<GridSquare> column = new List<GridSquare>();
                for (int y = 0; y < Height; y += SquareLength)
                {
                    GridSquare square = new GridSquare(x, y, SquareLength);
                    column.Add(square);
                }
                SquaresMatrix.Add(column);
            }
        }


    }
}
