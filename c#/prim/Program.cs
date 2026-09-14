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
            System.Console.WriteLine("írj be egy pozitív egész szamot:");
            long szam = long.Parse(System.Console.ReadLine());


            bool osztok = false;

            if (szam == 1)
            {
                return false;
            }
            else if (szam == 2)
            {
                return true;
            }
            else
            {
                for(long i =3; i*i <szam && !osztok; i+=2 )
                {
                    if(szam%i==0)
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
           System.Console.WriteLine(prim(32124515616));
        }
        

    }
}