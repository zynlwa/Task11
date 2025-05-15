namespace task11
{
    internal class Circle : Shape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; set; }
        public override double CalculateArea()
        {
            return 3.14 * Radius * Radius;
        }

        
    }
}
