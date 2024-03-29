﻿using System;

/// <summary> 14. Matrix addition #1 </summary>
class MatrixMath
{
    /// <summary> method that adds two matrices and returns the resulting matrix. </summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if ((matrix1.GetLength(0) != 2 && matrix1.GetLength(0) != 3) || 
            matrix1.GetLength(0) != matrix2.GetLength(0) ||
            (matrix1.GetLength(1) != 2 && matrix1.GetLength(1) != 3) ||
            matrix1.GetLength(0) != matrix1.GetLength(1))
            return new double[,] {{-1}};

        double[,] nmatrix = new double[matrix1.GetLength(0), matrix1.GetLength(0)];
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                nmatrix[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return nmatrix;
    }
}
