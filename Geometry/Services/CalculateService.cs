namespace Geometry.Services
{
	using Geometry.Figures;

	public sealed class CalculateService : ICalculateService
	{
		public double GetShapeArea(Shape shape)
		{
			if (shape == null) throw new ArgumentNullException(nameof(shape), "Parameter cannot be null.");

			return shape.GetArea();
		}
	}
}
