using System;

/// <summary> 12. Dot product #2 </summary>
class VectorMath
{
    /// <summary> method that calculates dot product of either two 2D or two 3D vectors. </summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != 2 && vector1.Length != 3)
            return -1;
        if (vector2.Length == vector1.Length)
        {
            double res = 0.0;
            for (int i = 0; i < vector1.Length; i++)
            {
                vector1[i] = vector1[i] * vector2[i];
                res = res + vector1[i];
            }
            return res;
        }
        return -1;
    }

}
