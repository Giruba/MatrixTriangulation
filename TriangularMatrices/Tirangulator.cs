using System;
using System.Collections.Generic;
using System.Text;

namespace TriangularMatrices
{
    static class Tirangulator
    {
        public static void LowerTriangular(int[,] inputMatrix) {
            int[,] matrix = inputMatrix;
            for (int i = 0; i < matrix.GetLength(0); i++) {
                for (int j = 0; j < matrix.GetLength(1); j++) {
                    if (i < j) {
                        matrix[i, j] = 0;
                    }
                }
            }
            PrintMatrix(matrix);
        }

        public static void upperTriangular(int[,] inputMatrix)
        {
            int[,] matrix = inputMatrix;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i > j)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            PrintMatrix(matrix);
        }

        public static void PrintRequiredMatrix(int option, int[,] inputMatrix) {
            try
            {
                switch (option)
                {
                    case 1:
                        LowerTriangular(inputMatrix);
                        break;
                    case 2:
                        upperTriangular(inputMatrix);
                        break;
                    case 3:
                        StriclyLowerTriangular(inputMatrix);
                        break;
                    default:
                        StrictlyUpperTriangular(inputMatrix);
                        break;
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown Exception is"+exception.Message);
            }
        }

        public static void StriclyLowerTriangular(int[,] inputMatrix)
        {
            int[,] matrix = inputMatrix;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((i < j) || (i==j))
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            PrintMatrix(matrix);
        }


        public static void StrictlyUpperTriangular(int[,] inputMatrix)
        {
            int[,] matrix = inputMatrix;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((i > j) || (i==j))
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            PrintMatrix(matrix);
        }

        public static void PrintMatrix(int[,] matrix) {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
