using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int index = 0;
        try
        {
            for (int i = 0; i < n; i++)
            {
                    Console.WriteLine(myList[i]);
                    index+=1;
            }
        }
        catch
        {
        }
            return index;
    }
}
