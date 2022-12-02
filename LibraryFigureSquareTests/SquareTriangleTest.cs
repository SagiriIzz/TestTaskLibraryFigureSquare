using TestTaskLibraryFigureSquare;
namespace FigureSquareTests;


[TestClass]
public class SquareTriangleTest
{
    [TestMethod]
    public void Side_Triangle_ShouldReturnCorrectResult()
    {
        var triangle = new SquareTriangle(firstSide:7, secondSide:24, thirdSide:25);
        const int expected = 84;
        
        var actual = triangle.GetSquareTriangle();
        
        Assert.AreEqual(expected, actual);
    }
}