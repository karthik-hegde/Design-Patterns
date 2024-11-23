using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Canvas
    {
        private List<Shape> Shapes = new List<Shape>();

        public void AddShape(Shape shape)
        {
            Shapes.Add(shape);
        }

        public void RemoveShape(Shape shape)
        {
            if (Shapes.Contains(shape))
            {
                Shapes.Remove(shape);
            }
        }
    }
}