namespace TestTaskLibraryFigureSquare;

public static class CheckingTriangleIsRight
{
    public static bool IsRight(this Triangle triangle)
    {
        if ((Math.Pow(triangle._firstSide, 2) == Math.Pow(triangle._secondSide, 2) + Math.Pow(triangle._thirdSide, 2)) ||
            (Math.Pow(triangle._secondSide, 2) == Math.Pow(triangle._firstSide, 2) + Math.Pow(triangle._thirdSide, 2)) ||
            (Math.Pow(triangle._thirdSide, 2) == Math.Pow(triangle._firstSide, 2) + Math.Pow(triangle._secondSide, 2)))
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}