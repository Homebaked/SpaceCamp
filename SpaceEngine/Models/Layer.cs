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

        public override void Draw(Graphics graphics)
        {
            foreach (GameObject ob in Objects)
            {
                ob.Draw(graphics);
            }
        }

        public bool HandleClick(MouseEventArgs args)
        {
            foreach (GameObject ob in Objects)
            {
                if (ob is Clickable)
                {
                    bool clicked = (ob as Clickable).Rect.Contains(args.Location);
                    if (clicked)
                    {
                        (ob as Clickable).HandleClick();
                        return true;
                    }
                }
            }
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
