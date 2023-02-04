namespace UnitTests.Figures
{
	using Geometry.Figures;

	public class CircleTests
    {
        [Theory]
        [InlineData(-1d, "Parameter must be positive. (Parameter 'radius')\r\nActual value was -1.")]
        [InlineData(0d, "Parameter must be positive. (Parameter 'radius')\r\nActual value was 0.")]
        public void Ctor_Should_Throw_ArgumentException(double radius, string expectedMessage)
        {
            try
            {
                //Arrange & Act
                var circle = new Circle(radius);

				//Assert
				Assert.Fail("There are no exception throws.");
			}
			catch (Exception ex)
			{
				//Assert
				Assert.Equal(expectedMessage, ex.Message);
			}
		}

        [Theory]
        [InlineData(19.634954084936208, 1211.1826828242117)]
        public void GetArea_Should_Return_Circle_Area(double radius, double expectedArea)
        {
            //Arrange
            var circle = new Circle(radius);

            //Act
            var area = circle.GetArea();

            //Assert
            Assert.Equal(expectedArea, area);
        }
    }
}