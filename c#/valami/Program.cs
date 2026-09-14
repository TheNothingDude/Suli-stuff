using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ciklus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //elöl
            //int x;
            //Console.WriteLine("Pozitív szám kell: ");
            //x = int.Parse(Console.ReadLine());
            //while (x < 0)
            //{
            //    Console.WriteLine("Pozitív szám kell");
            //    x = int.Parse(Console.ReadLine());
            //}

            //hátul

            //int y;

            //do {
            //    Console.WriteLine("Pozitív szám kell: ");
            //    y = int.Parse(Console.ReadLine());

            //    if (y<0) {
            //        Console.WriteLine("Nem pozitív");
            //    }
            //} while (y<0);

            // for (int i = 0; i <20;i++) 
            // {
            //     Console.Write($"{i+1}, ");


            // }
            // for (int i = 1; i <= 10;i++) { 
            //     for (int j = 1; j <=10; j++)
            //     {
            //         Console.Write($"{j*i} \t");

            //     }
            //     Console.WriteLine();
            // }
            //1 fel
            //int x;
            //fel2
            // while (x != 0)
            // {
            //      System.Console.WriteLine("Adj meg egy szamot: ");
            //     x = int.Parse(System.Console.ReadLine());
            // }
            // do
            // {
            //     System.Console.WriteLine("Adj meg egy szamot: ");
            //     x = int.Parse(System.Console.ReadLine());
            // } while (x != 0);

            //fel3
            // int i = 0;
            // while (i < 10)
            // {
            //     System.Console.WriteLine("easy");
            //     i++;
            // }
            // for (int i = 0; i < 10; i++) {
            //     System.Console.WriteLine("easy");
            // }

            //fel4
            // for (int i = 1; i <= 15; i++)
            // {
            //     System.Console.Write($"{i}");
            //     System.Console.WriteLine();
            // }
            //fel 5
            // for (int i = 1; i <= 20; i++)
            // {
            //     System.Console.Write($"{i} \t {i * i}");
            //     System.Console.WriteLine();
            // }

            //fel6
            // for (int i = 101; i <= 200; i++)
            // {
            //     if (i%5==0) {
            //         System.Console.WriteLine(i);
            //     }
            // }

            //fel7
            // for (int i = 20; i <= 50; i++)
            // {
            //     if (i%6==0 ||i%8==0)
            //     {
            //         System.Console.WriteLine(i);
            //     }
            // }
            //fel8
            // int kezd;
            // int veg;
            // System.Console.WriteLine("Add meg a kedő értéket: ");
            // kezd = int.Parse(Console.ReadLine());
            // System.Console.WriteLine("Add meg a vég értéket: ");
            // veg = int.Parse(Console.ReadLine());
            // for (int i = kezd ;i <= veg; i++ ) {
            //     if (i%2==0) {
            //         System.Console.WriteLine(i);
            //     }
            // }
            //fel9
            // for (int i =100; i >= -50; i=i-10) {
            //     System.Console.WriteLine(i);
            // }
            //fel10
            // int x;
            // for (int i = 0; i < 5; i++)
            // {
            //     System.Console.WriteLine("add meg egy számot: ");
            //     x = int.Parse(System.Console.ReadLine());
            //     System.Console.WriteLine(x*x);
            // }
            //fel11
            // int n;
            // int o = 0;
            // System.Console.WriteLine("> ");
            // n = int.Parse(System.Console.ReadLine());
            // for (int i = 1; i <= n; i++)
            // {
            //     o += i;
            // };
            // System.Console.WriteLine(o);
            //12
            // int x;
            // int c = 0;
            // System.Console.Write(">");
            // x = int.Parse(System.Console.ReadLine());
            // while (x != 0)
            // {
            //     c += 1;
            //     System.Console.Write(">");
            //     x = int.Parse(System.Console.ReadLine());

            // }
            // System.Console.WriteLine(c);
            //13   
            // int x;
            // int c = 0;
            // System.Console.Write(">");
            // x = int.Parse(System.Console.ReadLine());
            // while (x != 0)
            // {
            //     c += x;
            //     System.Console.Write(">");
            //     x = int.Parse(System.Console.ReadLine());

            // }
            // System.Console.WriteLine(c);
            //14
            // int x;
            // int max = 0;
            // System.Console.Write(">");
            // x = int.Parse(System.Console.ReadLine());
            // max = x;
            // while (x != 0)
            // {
            //     System.Console.Write(">");
            //     x = int.Parse(System.Console.ReadLine());
            //     if (max < x)
            //     {
            //         max = x;
            //     };
            // };
            // System.Console.WriteLine(max);
            //15
            //     int x;
            //     int c = 0;
            //     System.Console.Write(">");
            //     x = int.Parse(System.Console.ReadLine());
            //     for (int i = 1; i <= x; i++)
            //     {
            //         if (x % i == 0)
            //         {
            //             c += 1;
            //         }
            //     }
            //     System.Console.WriteLine(c);
            //16
            // int x;
            // int c = 0;
            // System.Console.Write(">");
            // x = int.Parse(System.Console.ReadLine());
            // for (int i = 1; i <= x; i++)
            // {
            //     if (x % i == 0)
            //     {
            //            System.Console.WriteLine(i);
            //     }
            // }
            // if (c / 2 == x)
            // {
            //     System.Console.WriteLine("Tökéletes");
            // }
            // else
            // {
            //     System.Console.WriteLine("nem Tökéletes");
            // }
            //17
            // int n, a, b, temp;
            // System.Console.Write(">");
            // n = int.Parse(System.Console.ReadLine());
            // a = 0;
            // b = 1;
            // temp = 0;

            // while (n > temp)
            // {
            //     System.Console.WriteLine(b);
            //     temp = a + b;
            //     a = b;
            //     b = temp;
            // }
            //18
            // int x;
            // int c = 0;
            // System.Console.Write(">");
            // x = int.Parse(System.Console.ReadLine());
            // for (int i = 1; i <= x; i++)
            // {
            //     if (x % i == 0)
            //     {
            //         c += 1;
            //     }
            // }
            // if (c == 2)
            // {
            //     System.Console.WriteLine("Prím");

            // }
            // else
            // {
            //     System.Console.WriteLine("Nem prím");
            // }
            //19
            int x;
            int c = 0;
            System.Console.Write(">");
            x = int.Parse(System.Console.ReadLine());
            int ox = x;
            while (x % 2 == 0)
            {
                c += 1;
                x = x / 2;
            }
            for (int i = 1; i <= c; i++)
            {
                System.Console.Write("2*");
            }
            System.Console.Write($"{x} = {ox}");
        }
    }
}
