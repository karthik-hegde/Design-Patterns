using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandPattern
{
    public abstract class Shape
    {
        public int Id;
        public int X;
        public int Y;

        public Shape(int id, int x, int y)
        {
            this.Id = id;
            this.X = x;
            this.Y = y;
        }

    }
}