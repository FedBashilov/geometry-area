namespace UnitTests.Figures
{
    using Geometry.Figures;
    using Geometry.Services;

    public class CalculateServiceTests
    {
        [Fact]
        public void GetShapeArea_Should_Be_Used_For_Unknown_Shape()
        {
            //Arrange
            var firstShape = new Circle(2d);
			var secondShape = new Triangle(3d, 4d, 5d);

            var calculateService = new CalculateService();

            //Act & Assert
            _ = calculateService.GetShapeArea(firstShape);
            _ = calculateService.GetShapeArea(secondShape);
        }

		[Theory]
		[InlineData(null, "Parameter cannot be null. (Parameter 'shape')")]
		public void GetShapeArea_Should_Throw_ArgumentException(Shape shape, string expectedMessage)
		{
			//Arrange
			var calculateService = new CalculateService();

            try
            {
				//Act & Assert
				_ = calculateService.GetShapeArea(shape);

				//Assert
				Assert.Fail("There are no exception throws.");
			}
			catch (Exception ex)
			{
				//Assert
				Assert.Equal(expectedMessage, ex.Message);
			}
		}
	}
}