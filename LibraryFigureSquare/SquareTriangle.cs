namespace TestTaskLibraryFigureSquare;

public class SquareTriangle : Triangle
{
    public SquareTriangle(double firstSide, double secondSide, double thirdSide) : base(firstSide, secondSide, thirdSide)
    {
    }
    public double GetSquareTriangle()
    {
        double semiPerimeter = (firstSide + secondSide + thirdSide) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - firstSide) * (semiPerimeter - secondSide) *
                         (semiPerimeter - thirdSide));      
    }
    
}