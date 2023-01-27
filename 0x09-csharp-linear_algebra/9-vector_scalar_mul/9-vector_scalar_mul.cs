using System;

/// <summary> 9. Vector-scalar multiplication #2 </summary>
class VectorMath
{
    /// <summary> method that multiplies a vector and a scalar and returns the resulting vector. </summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length == 2 || vector.Length == 3)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = vector[i] * scalar;
            }
            return vector;
        }
        return new double[] {-1};
    }
}
