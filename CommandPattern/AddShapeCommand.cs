using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class AddShapeCommand : ICommand
    {
        private Canvas Canvas;
        private Shape Shape;

        public AddShapeCommand(Canvas canvas, Shape shape)
        {
            Canvas = canvas;
            Shape = shape;
        }

        public void Execute()
        {
            Canvas.AddShape(Shape);
            Console.WriteLine($"Shape added ID: {Shape.Id} : {Shape.GetType()}");
        }

        public void Undo()
        {
            Canvas.RemoveShape(Shape);
        }
    }
}