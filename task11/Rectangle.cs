namespace task11
{
    internal class Rectangle:Shape
    {
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double Height { get; set; }
        public double Width { get; set; }
        public override double CalculateArea()
        {
            return Height * Width;
        }
    }
}
