namespace TestTaskLibraryFigureSquare;

public class Сircle : Shape
{
    protected double radius;

    public Сircle(double radius)
    {
        this.radius = radius;
    }
    public override double GetSquare()
    {
        return Math.PI * Math.Pow(radius, 2);
    }
}
