using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        double[] vector = {};
        double[] vector1 = {-9};
        double[] vector2 = {-3, -9};
        double[] vector3 = {7, -3, -9};
        double[] vector4 = {7, -3, -9, 5};

        double scalar = 0.5;

        double[] res = VectorMath.Multiply(vector3, scalar);

        foreach (var item in res)
        {
            Console.WriteLine(item);
        }
    }
}