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

            // // System.Console.WriteLine("kys");
            // System.Console.ForegroundColor = ConsoleColor.Red;
            // // System.Console.BackgroundColor = ConsoleColor.Blue;
            // // System.Console.WriteLine("kys now");

            // System.Console.BackgroundColor = ConsoleColor.Green;
            // // System.Console.Clear();
            // // Thread.Sleep(2000);
            // // System.Console.WriteLine("Now");
            // // Thread.Sleep(5000);
            // // System.Console.WriteLine("now");
            // System.Console.SetCursorPosition(10, 10);
            // System.Console.ForegroundColor = ConsoleColor.White;
            // System.Console.WriteLine("hello");

            string nev = "Nemes-Hertelendy Áron";
            System.Console.BackgroundColor = ConsoleColor.DarkBlue;
            System.Console.Clear();
            System.Console.SetCursorPosition((Console.WindowWidth- nev.Length) / 2 , Console.WindowHeight / 2);
            System.Console.Write(nev);
            Thread.Sleep(12000);
            
        }
    }
}