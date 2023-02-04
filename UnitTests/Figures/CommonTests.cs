namespace UnitTests.Figures
{
	using Geometry;
	using Geometry.Figures;

	public class CommonTests
    {
        [Fact]
        public void Should_Invoke_GetArea_For_Unknown_Figure()
        {
            //Arrange
            IFigure firstFigure = new Circle(2);
            IFigure secondFigure = new Triangle(3, 4, 5);

            //Act & Assert
            _ = firstFigure.GetArea();
            _ = secondFigure.GetArea();
        }
    }
}