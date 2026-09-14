using System;

namespace MyApp
{
    internal class Program
    {
        static string Sub(string s, int start_i, int end_i=-1)
        {
           string returnstr = "";
           if(end_i+start_i>s.Length)
            {
                return "Anyád";
            }
           
           if(end_i!=-1)
            {
                for(int i = start_i; i< start_i + end_i; i++)
                {
                    returnstr += s[i];
                }
                return returnstr;
            }
            else
            {
                end_i = s.Length;
                for(int i = start_i; i< end_i; i++)
                {
                    returnstr += s[i];
                }
                return returnstr;
            }
        
        }
        
        
        static void Main(string[] args)
        {
           System.Console.WriteLine(Sub("Henlo szia", 15));
        }
    }
}