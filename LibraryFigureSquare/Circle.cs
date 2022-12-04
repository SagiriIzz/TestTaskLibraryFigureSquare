namespace TestTaskLibraryFigureSquare;

public class Сircle : Shape
{
    private double _radius;

    public Сircle(double radius)
    {
        _radius = radius;
    }
    public override double GetSquare()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}
