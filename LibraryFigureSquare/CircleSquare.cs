namespace TestTaskLibraryFigureSquare;

public class CircleSquare : Сircle
{
    public CircleSquare(double radius): base(radius)
    {
    }

    public double GetSquare()
    {
        return Math.PI * Math.Pow(radius, 2);
    }
}