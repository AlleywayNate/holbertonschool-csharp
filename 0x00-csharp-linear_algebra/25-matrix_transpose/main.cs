using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix1 = {{14, -3, 0}, {-11, -5, 3}, {2, -9, 13}};
        double[,] matrix2 = {{6, 16}, {5, 2}};

        double[,] result = MatrixMath.Transpose(matrix1);

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}