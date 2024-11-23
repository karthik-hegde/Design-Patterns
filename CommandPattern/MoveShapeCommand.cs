using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class MoveShapeCommand : ICommand
    {
        private Canvas Canvas;
        private Shape Shape;
        private int X;
        private int Y;

        private int _previousX;
        private int _previousY;
        public MoveShapeCommand(Canvas canvas, Shape shape, int x, int y)
        {
            Canvas = canvas;
            Shape = shape;
            X = x;
            Y = y;
        }

        public void Execute()
        {

            _previousX = Shape.X;
            _previousY = Shape.Y;
            Shape.X = X;
            Shape.Y = Y;
            Console.WriteLine($"Shape moved ID: {Shape.Id} to new co-ords {Shape.X}, {Shape.Y}");
        }

        public void Undo()
        {
            Shape.X = _previousX;
            Shape.Y = _previousY;
        }
    }
}