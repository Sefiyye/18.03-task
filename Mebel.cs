using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    abstract class Mebel
    {
        public string Color;
        public string Materials;

        public Mebel(string color, string materials)
        {
            Color = color;
            Materials = materials;
        }
        public abstract void Lifeless();

        public abstract void Movement();

    }
}
