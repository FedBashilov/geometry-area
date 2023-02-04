namespace Geometry.Figures
{
    public class Triangle : Shape
    {
        public readonly double A;

        public readonly double B;

        public readonly double C;

        public Triangle(double a, double b, double c)
        {
            ValidateTriangleParams(a, b, c);

            this.A = a;
            this.B = b;
            this.C = c;
        }

        public bool IsRightTriangle()
        {
            return
                this.A == Math.Sqrt(Math.Pow(this.B, 2) + Math.Pow(this.C, 2)) ||
                this.B == Math.Sqrt(Math.Pow(this.A, 2) + Math.Pow(this.C, 2)) ||
                this.C == Math.Sqrt(Math.Pow(this.A, 2) + Math.Pow(this.B, 2));
        }

        public override double GetArea()
        {
            var semiPrmtr = (this.A + this.B + this.C) / 2;

            var area = Math.Sqrt(semiPrmtr * (semiPrmtr - this.A) * (semiPrmtr - this.B) * (semiPrmtr - this.C));

            return area;
        }

        private static void ValidateTriangleParams(double a, double b, double c)
        {
            if (a <= 0) throw new ArgumentOutOfRangeException(nameof(a), a, "Parameter must be positive.");
            if (b <= 0) throw new ArgumentOutOfRangeException(nameof(b), b, "Parameter must be positive.");
            if (c <= 0) throw new ArgumentOutOfRangeException(nameof(c), c, "Parameter must be positive.");

            if( !(a < b + c && b < a + c && c < a + b) )
            {
                throw new Exception("The sum of two side lengths has to exceed the length of the third side.");
            }
        }
    }
}