namespace TestTaskLibraryFigureSquare;

public class Triangle : Shape
{
    public double _firstSide;
    public double _secondSide; 
    public double _thirdSide;

    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        _firstSide = firstSide;
        _secondSide = secondSide;
        _thirdSide = thirdSide;  
    }

    public override double GetArea()
    {
        var semiPerimeter = (_firstSide + _secondSide + _thirdSide) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - _firstSide) * (semiPerimeter - _secondSide) *
                         (semiPerimeter - _thirdSide));      
    }
    
}


