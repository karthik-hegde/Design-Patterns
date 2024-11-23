namespace CommandPattern
{
    public class Circle : Shape
    {
        public int Radius;
        public Circle(int id, int x, int y, int radius) : base(id, x, y)
        {
            Radius = radius;
        }
    }
}