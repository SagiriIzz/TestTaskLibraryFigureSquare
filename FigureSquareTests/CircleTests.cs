using TestTaskLibraryFigureSquare;
namespace FigureSquareTests;

[TestClass]
public class SquareCircleTest
{
    [TestMethod]
    public void radius12_return452()
    {
        double expected = 452.3893421169302;
        
        double actual = LibrarySquareCircle.SquareCircle(12);
        
        Assert.AreEqual(expected, actual);
    }
}

