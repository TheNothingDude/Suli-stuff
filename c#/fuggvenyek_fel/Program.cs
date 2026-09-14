using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace MyApp
{
    internal class Program
    {
        static Random rnd = new Random();
        static double MertaniKozep(double a, double b)
        {
                return Math.Pow(a * b, 1.0 / 2);
        }
        static double SzamtaniKozep(double a, double b)
        {
            return (a+b)/2;
        }
        static int Osztalyoz(float pont)
        {
            if(pont >= 0 && pont <=40)
            {
                return 1;
            }
            else if(pont>40 && pont <=57)
            {
                return 2;
            }
            else if(pont >=58 && pont <=80)
            {
                return 3;
            }
            else if(pont >= 81 && pont<=92)
            {
                return 4;
            }
            else if(pont >=93 && pont <=100)
            {
                return 5;
            }
            else
            {
                return -1;
            }

        }
        static string SzovegesOsztalyzat(int jegy)
        {
            switch(jegy)
            {
                case 1:
                    return "Elégtelen";
                case 2:
                    return "Elégséges";
                case 3:
                    return "Közepes";
                case 4:
                    return "Jó";
                case 5:
                    return "Jeles";
                default:
                    return "Buta";
            }
            
        }
        static void Min_Max(int[] t, ref int min,ref int max)
        {
            min = t.Min();
            max = t.Max();
        }
        static int EgyDobas()
        {
            return rnd.Next(1,7); 
        }
        static int[] EzerDobas()
        {

            int[] dobasok = new int[1000];
            for(int i =0; i < 1000; i++)
            {
                dobasok[i] = EgyDobas();

            } 
            return dobasok;
        }
        static IDictionary<char, int> Statistika()
        {
            Dictionary<char, int> stats = new Dictionary<char, int>
            {
                {'1',0},
                {'2',0},
                {'3',0},
                {'4', 0},
                {'5',0},
                {'6',0}
            };
            foreach(int i in EzerDobas())
            {
                if(i ==1)
                {
                    stats['1'] +=1;
                }
                else if(i ==2)
                {
                    stats['2'] +=1;
                }
                else if(i==3)
                {
                    stats['3'] +=1;
                }
                 else if(i==4)
                {
                    stats['4'] +=1;
                }
                 else if(i==5)
                {
                    stats['5'] +=1;
                }
                 else if(i==6)
                {
                    stats['6'] +=1;
                }
            }
            return stats;
        }

        static void RendezNovekvo(ref int a, ref int b, ref int c)
        {
            if(b < a)
            {
                a ^= b;
                b ^= a;
                a ^= b;
            }
            if(c < a)
            {
                a ^= c;
                c ^= a;
                a ^= c;
            }
            if(b>c)
            {
                b ^= c;
                c ^= b;
                b ^= c;
            }
        }
        static int[,] Egysegmatrix(int N)
        {
            int [,] M = new int[N,N];

            for(int i =0; i<N; i++)
            {
                for(int j =0; j<N; j++)
                {
                    if(j==i)
                    {
                        M[i,j] =1;
                    }
                    else
                    {
                        M[i,j] =0;
                    }
                }
            }
            return M;
        }
        static void EgysegMatrixMegjelen(ref int[,] m)
        {
            for(int i =0; i<m.GetLength(0); i++)
            {
                for(int j =0; j<m.GetLength(1); j++)
                {
                    System.Console.Write(m[i,j]);
                }
                System.Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            // System.Console.WriteLine(mertaniKozep(5,6));
            // System.Console.WriteLine(SzamtaniKozep(5,6));
            // System.Console.WriteLine(SzovegesOsztalyzat(Osztalyoz(82)));
            // Random rnd = new Random();
            
            // int[] t = new int[40];
            // for(int i =0; i < t.Length; i++)
            // {
            //     t[i] = rnd.Next(1,50);
            // }
            // int min=t[1];
            // int max=t[1];
            // Min_Max(t, ref max , ref min);
            // System.Console.WriteLine($" {max} {min}");
            // foreach(var ele in Statistika())
            // {
            //     System.Console.WriteLine($"{ele.Key}:{ele.Value}");
            // }
            // int x=3, y =5, z=2;
            // RendezNovekvo(ref x,ref y,ref z);
            // System.Console.WriteLine($"{x}, {y}, {z}");
            int[,] m = Egysegmatrix(7);
            EgysegMatrixMegjelen(ref m);
        }
    }
}