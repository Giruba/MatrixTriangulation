using System;
using System.Collections.Generic;
using System.Text;

namespace TriangularMatrices
{
    class ProcessInput
    {
        public ProcessInput() { }

        public void GetMatrix() {
            int input = 0;
            int optionToContinue = 0;
            int[,] square_matrix;
            do
            {
                Console.WriteLine("Enter the dimension of the square matrix");
                try
                {
                    int dimension = int.Parse(Console.ReadLine());
                    square_matrix = new int[dimension, dimension];
                    for (int i = 0; i < dimension; i++)
                    {
                        for (int j = 0; j < dimension; j++)
                        {
                            Console.WriteLine("Enter the element");
                            square_matrix[i, j] = int.Parse(Console.ReadLine());
                        }
                    }
                    do
                    {
                        input = GetInput();
                        if (input < 5 && input > 0) { 
                            Tirangulator.PrintRequiredMatrix(input, square_matrix);
                        }
                    } while (input < 5 && input > 0);
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Exception thrown is" + exception.Message);
                }
                Console.WriteLine("Press 1 to continue 0 to stop");
                optionToContinue = int.Parse(Console.ReadLine());
            } while (optionToContinue != 0);
        }

        public int GetInput() {

            try
            {
                Beautifier.UnderlineHeading("Enter one of teh following");
                Beautifier.OneLine("1 for Lower Triangular Matrix");
                Beautifier.OneLine("2 for Upper Triangular Matrix");
                Beautifier.OneLine("3 for Strictly Lower Triangular Matrix");
                Beautifier.OneLine("4 for Strictly Upper Triangular Matrix");
                return int.Parse(Console.ReadLine());
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is"+exception.Message);
            }
            Console.WriteLine("Enter only one of the given options!");
            return -1;
        }
    }
}
