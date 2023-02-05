using System;
using System.Collections.Generic;
using System.Linq;
namespace Geometry
{
	internal static class DoubleExtensions
	{
		const double Tolerance = 1e-10;

		public static bool EqualsApproximately(this double x, double y, double tolerance = Tolerance)
		{
			return (Math.Abs(x - y) <= tolerance);
		}

		public static int CompareApproximately(this double x, double y, double tolerance = Tolerance)
		{
			if (x.EqualsApproximately(y)) 
			{
				return 0;
			}
			if (x - y < tolerance)
			{
				return -1;
			}
			return 1;
		}
	}
}
