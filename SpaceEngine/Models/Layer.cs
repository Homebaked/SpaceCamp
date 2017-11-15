﻿using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEngine.Models
{
    public class Layer : GameObject
    {
        public List<GameObject> Objects { get; private set; }

        public Layer()
        {
            Objects = new List<GameObject>();
        }

        public override void Draw(SpriteBatch sb)
        {
            foreach (GameObject ob in Objects)
            {
                ob.Draw(sb);
            }
        }

        public bool HandleClick()
        {
            return false;
        }

        public void Add(GameObject ob)
        {
            Objects.Add(ob);
        }

        public void Remove(GameObject ob)
        {
            if (Objects.Contains(ob))
            {
                Objects.Remove(ob);
            }
            else
            {
                throw new ArgumentException("GameObject not found in Layer.");
            }
        }
    }
}