using TestTaskLibraryFigureSquare;
namespace FigureSquareTests;


[TestClass]
public class TriangleTest
{
    [TestMethod]
    public void Side_Triangle_ShouldReturnCorrectResult()
    {
        var triangle = new Triangle(firstSide:7, secondSide:24, thirdSide:25);
        const int expected = 84;
        
        var actual = triangle.GetArea();
        
        Assert.AreEqual(expected, actual);
    }
}