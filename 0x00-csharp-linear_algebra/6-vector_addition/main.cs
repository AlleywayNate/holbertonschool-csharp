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

        double[] result = VectorMath.Add(vector2, vector2);

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}