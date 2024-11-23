using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class RemoveShapeCommand : ICommand

    {
        private Canvas Canvas;
        private Shape Shape;

        public RemoveShapeCommand(Canvas canvas, Shape shape)
        {
            Canvas = canvas;
            Shape = shape;
        }
        public void Execute()
        {
            Canvas.RemoveShape(Shape);
            Console.WriteLine($"Shape removed ID: {Shape.Id} : {Shape.GetType()}");
        }

        public void Undo()
        {
            Canvas.AddShape(Shape);
        }
    }
}