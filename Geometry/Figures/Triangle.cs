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

            (this.A, this.B, this.C) = (a, b, c);
        }

        public bool IsRightTriangle()
        {
			var sideSquares = new double[] { Math.Pow(this.A, 2), Math.Pow(this.B, 2), Math.Pow(this.C, 2) };

			return Math.Abs(sideSquares[0] - (sideSquares[1] + sideSquares[2])) < double.Epsilon ||
				   Math.Abs(sideSquares[1] - (sideSquares[0] + sideSquares[2])) < double.Epsilon ||
				   Math.Abs(sideSquares[2] - (sideSquares[0] + sideSquares[1])) < double.Epsilon;
		}

        public override double GetArea()
        {
            var semiPrmtr = (this.A + this.B + this.C) / 2d;

            var area = Math.Sqrt(semiPrmtr * (semiPrmtr - this.A) * (semiPrmtr - this.B) * (semiPrmtr - this.C));

            return area;
        }

        private static void ValidateTriangleParams(double a, double b, double c)
        {
            if (a <= 0) throw new ArgumentOutOfRangeException(nameof(a), a, "Parameter must be positive.");
            if (b <= 0) throw new ArgumentOutOfRangeException(nameof(b), b, "Parameter must be positive.");
            if (c <= 0) throw new ArgumentOutOfRangeException(nameof(c), c, "Parameter must be positive.");

            if( !( a - b - c < double.Epsilon && b - a - c < double.Epsilon && c - a - b < double.Epsilon) )
            {
                throw new Exception("The sum of two side lengths has to exceed the length of the third side.");
            }
        }
    }
}