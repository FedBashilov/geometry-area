namespace UnitTests.Figures
{
	using Geometry.Figures;

	public class TriangleTests
    {
        [Theory]
        [InlineData(-1d, 1d, 1d, "Parameter must be positive. (Parameter 'a')\r\nActual value was -1.")]
        [InlineData(1d, -1d, 1d, "Parameter must be positive. (Parameter 'b')\r\nActual value was -1.")]
        [InlineData(1d, 1d, -1d, "Parameter must be positive. (Parameter 'c')\r\nActual value was -1.")]
        [InlineData(0d, 1d, 1d, "Parameter must be positive. (Parameter 'a')\r\nActual value was 0.")]
        [InlineData(1d, 0d, 1d, "Parameter must be positive. (Parameter 'b')\r\nActual value was 0.")]
        [InlineData(1d, 1d, 0d, "Parameter must be positive. (Parameter 'c')\r\nActual value was 0.")]
        [InlineData(1d, 2d, 3d, "The sum of two side lengths has to exceed the length of the third side.")]
        public void Ctor_Should_Throw_ArgumentException(double a, double b, double c, string expectedMessage)
        {
            try
            {
                //Arrange & Act
                var triangle = new Triangle(a, b, c);

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
        [InlineData(2d, 3d, 4d, 2.9047375096555625)]
        public void GetArea_Should_Return_Triangle_Area(double a, double b, double c, double expectedArea)
        {
            //Arrange
            var triangle = new Triangle(a, b, c);

            //Act
            var area = triangle.GetArea();

            //Assert
            Assert.Equal(expectedArea, area);
        }

        [Theory]
        [InlineData(3d, 4d, 5d)]
        public void IsRightTriangle_Should_Return_True(double a, double b, double c)
        {
            //Arrange
            var triangle = new Triangle(a, b, c);

            //Act
            var isRight = triangle.IsRightTriangle();

            //Assert
            Assert.True(isRight);
        }

        [Theory]
        [InlineData(5d, 6d, 7d)]
        public void IsRightTriangle_Should_Return_False(double a, double b, double c)
        {
            //Arrange
            var triangle = new Triangle(a, b, c);

            //Act
            var isRight = triangle.IsRightTriangle();

            //Assert
            Assert.False(isRight);
        }
    }
}