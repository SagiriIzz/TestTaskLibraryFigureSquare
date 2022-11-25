using System.Security.Cryptography.X509Certificates;
using TestTaskLibraryFigureSquare;


namespace ConsoleApp1
{
    class ResultFigure
    {
        static void Main()
        {
            double resultCircle = LibrarySquareCircle.SquareCircle(12);
            Console.WriteLine(resultCircle);
            double resultTriangle = LibrarySquareTriangle.SquareTriangle(3, 4, 5);
            Console.WriteLine(resultTriangle);
        }
    }
}

   

