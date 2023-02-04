namespace Geometry.Figures
{
    public class Circle : Shape
    {
        public readonly double Radius;

        public Circle(double radius)
        {
            ValidateCircleParams(radius);

            this.Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }

        private static void ValidateCircleParams(double radius)
        {
            if (radius <= 0) throw new ArgumentOutOfRangeException(nameof(radius), radius, "Parameter must be positive.");
        }
    }
}