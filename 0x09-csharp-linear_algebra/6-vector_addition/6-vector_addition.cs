using System;
using System.Collections.Generic;

/// <summary> 6. Vector addition #2 </summary>
class VectorMath
{
    /// <summary> method that adds two vectors and returns the resulting vector. </summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length != 2 && vector1.Length != 3)
            return new double[] {-1};
        if (vector2.Length == vector1.Length)
        {
            double[] newvector = new double[vector1.Length];
            for (int i = 0; i < vector1.Length; i++)
            {
                newvector[i] = vector1[i] + vector2[i];
            }
            return newvector;
        }
        return new double[] {-1};
    }
}
