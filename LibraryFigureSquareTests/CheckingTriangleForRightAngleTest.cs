using TestTaskLibraryFigureSquare;
namespace FigureSquareTests;

[TestClass]
public class CheckingTriangleForRightAngleTest
{
    [TestMethod]
    public void  Right_Triangle_ShouldReturnTrue()
    {
        var rightTriangle = new CheckingTriangleForRightAngle(firstSide:7, secondSide:24, thirdSide:25);
        const bool expected = true;
        
        var actual = rightTriangle.CheckingRightTriangle();
        
        Assert.AreEqual(expected, actual);
    }
}