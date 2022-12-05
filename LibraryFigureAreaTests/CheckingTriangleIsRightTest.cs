using TestTaskLibraryFigureSquare;
namespace FigureSquareTests;

[TestClass]
public class CheckingTriangleIsRightTest
{
    [TestMethod]
    public void  Right_Triangle_ShouldReturnTrue()
    {
        var tringle = new Triangle(firstSide:7, secondSide:24, thirdSide:25);
        const bool expected = true;
        
        var actual =  tringle.IsRight();
        
        Assert.AreEqual(expected, actual);
    }
}