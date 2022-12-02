namespace TestTaskLibraryFigureSquare;

public class CheckingTriangleForRightAngle: Triangle
{
    public CheckingTriangleForRightAngle(double firstSide, double secondSide, double thirdSide) : base(firstSide, secondSide, thirdSide)
    {
    }
    public bool CheckingRightTriangle()
    {
        if ((Math.Pow(firstSide, 2) == Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2)) ||
            (Math.Pow(secondSide, 2) == Math.Pow(firstSide, 2) + Math.Pow(thirdSide, 2)) ||
            (Math.Pow(thirdSide, 2) == Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2)))
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}