using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceEngine.Utilities
{
    static public class HelperMethods
    {
        public static Color[] GenerateColorData(Color color, int width, int height)
        {
            Color[] data = new Color[width * height];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = color;
            }
            return data;
        }
        public static Color[] GenerateColorData(Color color, Texture2D texture)
        {
            return GenerateColorData(color, texture.Width, texture.Height);
        }
    }
}
