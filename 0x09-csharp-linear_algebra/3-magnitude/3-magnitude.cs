using System;
using System.Collections.Generic;

/// <summary> 3. Magnitude #2 </summary>
class VectorMath
{
    /// <summary> method that calculates and returns the length of a given vector </summary>
    public static double Magnitude(double[] vector)
    {
        double sqr = 0;
        int len = 0;
        foreach (var item in vector)
        {
            len += 1;
            sqr = Math.Pow(item, 2) + sqr;
        }
        if (len < 2 || len > 3)
            return -1;
        return Math.Round(Math.Sqrt(sqr), 2);
    }
}
