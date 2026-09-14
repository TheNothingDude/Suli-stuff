using System;
using System.IO;
using Microsoft.VisualBasic;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // FileStream fs = new FileStream("gyumolcsok.txt", FileMode.Open);
            // StreamReader sr = new StreamReader(fs);

            //     string s;
            //     while ((s = sr.ReadLine())!=null)
            //     {
            //         System.Console.WriteLine(s);
            //     }
            //     fs.Close();
            //sr.Close();

            FileStream fs = new FileStream("zoldsegek.txt", FileMode.Create);

            StreamWriter sw = new StreamWriter(fs);
            System.Console.WriteLine("írj be egy zoldcsit: ");
            string s;
            while((s = System.Console.ReadLine()) != string.Empty)
            {
                sw.WriteLine(s);
                System.Console.WriteLine("írj be még egy zöldcsit: ");
            }
            sw.Close();
            FileStream zold = new FileStream("zoldsegek.txt", FileMode.Append);
            StreamWriter zold_sw = new StreamWriter(zold);
            string extra;
            System.Console.WriteLine("Add meg ujabb zoldet");
            while((extra = System.Console.ReadLine()) != string.Empty)
            {
                zold_sw.WriteLine(zold);
                System.Console.WriteLine("írj be még egy zöldcsit: ");
            }
            zold_sw.Close();
            zold.Close();
            fs.Close();
        
        
           
        }
    }
}