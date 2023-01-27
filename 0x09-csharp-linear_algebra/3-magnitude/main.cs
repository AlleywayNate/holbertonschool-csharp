using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        double[] vector = {7, -3, -9};

        Console.WriteLine(VectorMath.Magnitude(vector));
        
        double[] vector1 = {-3, -9};

        Console.WriteLine(VectorMath.Magnitude(vector1));

        double[] vector2 = {7, -3, -9, 5};

        Console.WriteLine(VectorMath.Magnitude(vector2));

        double[] vector3 = {-9};

        Console.WriteLine(VectorMath.Magnitude(vector3));
        
        double[] vector4 = {};

        Console.WriteLine(VectorMath.Magnitude(vector4));
    }
}