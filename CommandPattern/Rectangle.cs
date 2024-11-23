using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Rectangle : Shape
    {
        public int Width;
        public int Height;
        public Rectangle(int id, int x, int y, int width, int height) : base(id, x, y)
        {
            Width = width;
            Height = height;
        }
    }
}