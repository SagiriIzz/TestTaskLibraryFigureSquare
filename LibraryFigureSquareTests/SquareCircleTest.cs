using TestTaskLibraryFigureSquare;
namespace FigureSquareTests;

[TestClass]
public class SquareCircleTest
{
    [TestMethod]
    public void Circle_Radius_ShouldReturnCorrectResult()
    {
        var circle = new CircleSquare(radius: 12);
        const double expected = 452.3893421169302;

        var actual = circle.GetSquare();
        
        Assert.AreEqual(expected, actual);
    }
}

