using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Channels;

namespace feladat
{

    internal class Program
    {
        static bool prim(long szam)
        {
            bool osztok = false;

            if (szam == 1 || szam % 2==0)
            {
                return false;
            }
            else if (szam == 2)
            {
                return true;
            }
            else
            {
                for (long i = 3; i * i < szam && !osztok; i += 2)
                {
                    if (szam % i == 0)
                    {
                        osztok = true;
                    }
                }
            }
            if (osztok)
            {
                return false;
            }
            else
            {
                return true;

            }
        }        
        static void Main(string[] args)
        {
            // int[] tomb = new int[300];
            // Random rand = new Random();

            // for (int i = 0; i < tomb.Length; i++)
            // {
            //     tomb[i] = rand.Next(0, 1000);
            // }
            //bubi
            // for (int i = 0; i < tomb.Length - 1; i++)
            // {
            //     for (int j = i + 1; j < tomb.Length; j++)
            //     {
            //         if (tomb[j] < tomb[i])
            //         {
            //             tomb[i] ^= tomb[j];
            //             tomb[j] ^= tomb[i];
            //             tomb[i] ^= tomb[j];
            //         }
            //     }
            // }
            //kiválasztás(min)
            // for(int i =0; i < tomb.Length-1; i++)
            // {
            //     int min_index = i;
            //     for (int j = i + 1; j < tomb.Length; j++)
            //     {
            //         if (tomb[j] < tomb[min_index])
            //         {
            //             min_index = j;
            //         }
            //     }
            //     if(i != min_index)
            //     {
            //         tomb[i] ^= tomb[min_index];
            //         tomb[min_index] ^= tomb[i];
            //         tomb[i] ^= tomb[min_index];
            //     }
            // }
            //beszur(növ)

            // for(int i =0; i < tomb.Length-1; i++)
            // {
            //     for(int j =i+1; j>0 && tomb[j] < tomb[j-1]; j--)
            //     {
            //         tomb[j] ^= tomb[j-1];
            //         tomb[j-1] ^= tomb[j];
            //         tomb[j] ^= tomb[j-1];
            //     }
            // }


            // foreach(int i in tomb)
            // {
            //     System.Console.Write($"{i} \t");
            // }



            int[] t = new int[20];
            System.Console.WriteLine("írjon be egy szamot: ");
            int szam = int.Parse(System.Console.ReadLine());
            int N = 0;
            while (szam != 0 && N < 20)
            {
                t[N++] = szam;
                if (N < 20)
                {
                    System.Console.WriteLine("írjon be egy szamot: ");
                    szam = int.Parse(System.Console.ReadLine());
                }

            }

            foreach (int i in t)
            {
                System.Console.Write($"{i} \t");
            }


            for (int i = 0; i < N - 1; i++)
            {
                for (int j = i + 1; j > 0 && t[j] > t[j - 1]; j--)
                {
                    t[j] ^= t[j - 1];
                    t[j - 1] ^= t[j];
                    t[j] ^= t[j - 1];
                }
            } 
            System.Console.WriteLine();
            foreach (int i in t)
            {
                System.Console.Write($"{i} \t");
            }
            System.Console.WriteLine($"Max: {t[0]}, Min:{t[N - 1]}");
            for(int i = 0; i < N; i++)
            {
                System.Console.WriteLine(prim(t[i]));
            }



        }

    }
}   