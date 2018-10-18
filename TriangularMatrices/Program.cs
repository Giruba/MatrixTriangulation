using System;

namespace TriangularMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triangular Matrices!");
            Console.WriteLine("---------------------");
            new ProcessInput().GetMatrix();
            Console.ReadLine();
        }
    }
}
