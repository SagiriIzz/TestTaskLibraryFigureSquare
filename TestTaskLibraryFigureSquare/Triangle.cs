namespace TestTaskLibraryFigureSquare;

public static class LibrarySquareTriangle
{
    public static double SquareTriangle (double firstSide, double secondSide , double thirdSide) 
    {
        double semiPerimeter = (firstSide + secondSide + thirdSide)/2;
        
        return Math.Sqrt(semiPerimeter * (semiPerimeter - firstSide)*(semiPerimeter - secondSide)*(semiPerimeter - thirdSide));
    }
}
public static class LibraryRightTriangle
{
    public static double RightTriangle (double firstSide, double secondSide , double thirdSide)
    {
        
        if ((firstSide * firstSide == secondSide * secondSide + thirdSide * thirdSide)|| 
            (secondSide*secondSide == firstSide*firstSide+thirdSide*thirdSide) || 
            (thirdSide * thirdSide == firstSide * firstSide + secondSide * secondSide))
        { 
            return 1;
        }
        else
        {
            return 0;
        }

    }
}
