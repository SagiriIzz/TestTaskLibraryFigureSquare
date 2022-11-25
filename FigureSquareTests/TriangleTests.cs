using TestTaskLibraryFigureSquare;
namespace FigureSquareTests;


[TestClass]
public class SquareTriangleTest
{
    [TestMethod]
    public void firstSide3_secondSide4_thirdSide5_return6()
    {
        double expected = 6;
        
        double actual = LibrarySquareTriangle.SquareTriangle(3, 4, 5);
        
        Assert.AreEqual(expected, actual);
    }
}

[TestClass]
public class RightTriangleTest
{
    [TestMethod]
    public void firstSide3_secondSide4_thirdSide5_return6()
    {
        double expected = 1;
        
        double actual = LibraryRightTriangle.RightTriangle(7, 24, 25);
        
        Assert.AreEqual(expected, actual);
    }
}