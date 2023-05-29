using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        double[] vector = {};
        double[] vector1 = {-9};
        double[] vector2 = {-4, 0, 10};
        double[] vector3 = {3, 7, -9};
        double[] vector4 = {7, -3, -9, 5};

        double res = VectorMath.DotProduct(vector2, vector3);

        Console.WriteLine(res);
    }
}