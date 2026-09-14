using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5,5]
            {
                {0,1,1,0,1},
                {0,0,0,0,0},
                {0,1,0,1,1},
                {0,0,0,0,0},
                {0,0,0,0,0}
            };
            //a
            // for(int j =0; j < matrix.GetLength(1); j++)
            // {
            //     bool van_1 = false;
            //     for(int i =0; i<matrix.GetLength(0) && !van_1;i++)
            //     {
            //         if(matrix[i,j] !=0)
            //         {
            //             van_1=true;
            //         }
            //     }
            //     if(!van_1)
            //     {
            //         System.Console.WriteLine((j+1) +" ");
            //     }
            // }
            //b
            for(int i=0 ; i<matrix.GetLength(0); i++)
            {
                bool adta = false;
                for(int j =0; j<matrix.GetLength(1) && !adta; j++)
                {
                    if(matrix[i,j] != 0)
                    {
                        adta = true;
                    }
                }
                if(!adta)
                {
                    System.Console.WriteLine(i+1 +" ");
                }
            }
            //c
            int max = 0;
            int c =0;
            for(int i=0 ; i<matrix.GetLength(0); i++)
            {
                for(int j =0; j<matrix.GetLength(1); j++)
                {
                    
                }
            }

        }
    }
}