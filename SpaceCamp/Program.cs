using OpenTK;
using System;

namespace SpaceCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            GameWindow game = new GameWindow();
            game.Run(60);
        }
    }
}