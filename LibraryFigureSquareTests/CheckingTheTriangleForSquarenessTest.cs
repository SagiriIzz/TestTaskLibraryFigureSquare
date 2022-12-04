using TestTaskLibraryFigureSquare;
namespace FigureSquareTests;

[TestClass]
public class CheckingTheTriangleForSquarenessTest
{
    [TestMethod]
    public void  Right_Triangle_ShouldReturnTrue()
    {
        var rightTriangle = new CheckingTheTriangleForSquareness(firstSide:7, secondSide:24, thirdSide:25);
        const bool expected = true;
        
        var actual = rightTriangle.CheckTheRightTriangle();
        
        Assert.AreEqual(expected, actual);
    }
}