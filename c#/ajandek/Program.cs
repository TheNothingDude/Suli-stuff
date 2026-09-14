using System;
using System.Collections.Generic;
 
 
class Program
{
    static void Main()
    {
        int n = 9;
        int[] given = new int[] { 2, 3, 4, 5, 3, 5, 8, 9, 8 };
        bool[] gifts = new bool[9];
        int counter = 0;
        List<int> duplikáns = new List<int>();
 
        for (int i = 0; i < given.Length; i++)
        {
            int kinek_ad = given[i] - 1;
 
            if (gifts[kinek_ad])
            {
                duplikáns.Add(i);
                counter++;
            }else
            {
                gifts[kinek_ad] = true;
            }
        }
        Console.WriteLine(counter);
        for (int i = 0; i < duplikáns.Count; i++)
        {
            bool fut = true;
            for (int j = 0; fut && j < gifts.Length; j++)
            {
                if (!gifts[j])
                {
                    if (i != j)
                    {
                        gifts[j] = true;
                        Console.WriteLine($"{duplikáns[i] + 1} {j+1}");
                        fut = false;
                    }
                }
            }
        }
 
    }
}