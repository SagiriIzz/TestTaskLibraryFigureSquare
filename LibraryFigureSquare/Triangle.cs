namespace TestTaskLibraryFigureSquare;

public class Triangle : Shape
{
    protected double _firstSide;
    protected double _secondSide; 
    protected double _thirdSide;

    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        _firstSide = firstSide;
        _secondSide = secondSide;
        _thirdSide = thirdSide;  
    }

    public override double GetSquare()
    {
        var semiPerimeter = (_firstSide + _secondSide + _thirdSide) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - _firstSide) * (semiPerimeter - _secondSide) *
                         (semiPerimeter - _thirdSide));      
    }
}


