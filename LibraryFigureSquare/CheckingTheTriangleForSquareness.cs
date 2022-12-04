namespace TestTaskLibraryFigureSquare;

public class CheckingTheTriangleForSquareness: Triangle
{
    public CheckingTheTriangleForSquareness(double firstSide, double secondSide, double thirdSide) : base(firstSide, secondSide, thirdSide)
    {
        _firstSide = firstSide;
        _secondSide = secondSide;
        _thirdSide = thirdSide;
    }
    public bool CheckTheRightTriangle()
    {
        if ((Math.Pow(_firstSide, 2) == Math.Pow(_secondSide, 2) + Math.Pow(_thirdSide, 2)) ||
            (Math.Pow(_secondSide, 2) == Math.Pow(_firstSide, 2) + Math.Pow(_thirdSide, 2)) ||
            (Math.Pow(_thirdSide, 2) == Math.Pow(_firstSide, 2) + Math.Pow(_secondSide, 2)))
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}