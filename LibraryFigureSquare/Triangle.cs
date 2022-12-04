namespace TestTaskLibraryFigureSquare;

public class Triangle : Shape
{
    protected double firstSide, secondSide, thirdSide;

    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        this.firstSide = firstSide;
        this.secondSide = secondSide;
        this.thirdSide = thirdSide;  
    }

    public override double GetSquare()
    {
        var semiPerimeter = (firstSide + secondSide + thirdSide) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - firstSide) * (semiPerimeter - secondSide) *
                         (semiPerimeter - thirdSide));      
    }
}


