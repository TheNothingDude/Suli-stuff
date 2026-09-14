using System;
using System.Threading;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Channels;
using System.Xml;

namespace feladat
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int width = System.Console.WindowWidth;
            int hieght = System.Console.WindowHeight;

            Random rnd = new Random();

            System.Console.BackgroundColor = ConsoleColor.Green;
            System.Console.Clear();

            #region felso
            System.Console.Write("╔"); //alt+201
            for (int x = 1; x < width - 1; x++)
            {
                System.Console.Write("═");
            }
            #endregion
            System.Console.Write("╗");

            #region balkeret
            for (int y = 1; y < hieght - 1; y++)
            {
                System.Console.SetCursorPosition(0, y);
                System.Console.WriteLine("║");
            }
            #endregion
            for (int y = 1; y < hieght - 1; y++)
            {
                System.Console.SetCursorPosition(width - 1, y);
                System.Console.WriteLine("║");
            }
            System.Console.Write("╚");
            for (int x = 1; x < width - 1; x++)
            {
                System.Console.Write("═");
            }
            System.Console.Write("╝");

            int x_poz = rnd.Next(1, width - 2), y_poz =  rnd.Next(1, hieght - 2);
            bool x_i = true, y_i =true;
            System.Console.CursorVisible = false;
            System.Console.SetCursorPosition(x_poz, y_poz);
            System.Console.Write("O");

    
            while(true)
            {
                Thread.Sleep(100);
                System.Console.SetCursorPosition(x_poz, y_poz);
                System.Console.Write(' ');
                if (x_i && y_i)
                {
                    y_poz++;
                    x_poz++;
                }
                if (x_i && y_i == false)
                {
                    x_poz++;
                    y_poz--;
                }
                if (!x_i && !y_i)
                {
                    x_poz--;
                    y_poz--;
                }
                if( !x_i && y_i)
                {
                    x_poz--;
                    y_poz++;
                }
                if(x_poz == width-2 || x_poz == 1)
                {
                    x_i = !x_i;
                }
                if(y_poz == hieght-2 || y_poz==1)
                {
                    y_i = !y_i;
                }

                Thread.Sleep(100);
                System.Console.SetCursorPosition(x_poz, y_poz);
                System.Console.Write('O');
            }
        }
    }
}