using System;
using System.Threading;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Channels;
using System.Xml;
using System.Runtime.ConstrainedExecution;
using System.Net;
using System.Xml.Serialization;

namespace feladat
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // char c = 'a';
            // System.Console.WriteLine((int)c);
            // System.Console.WriteLine((char)65);
            // System.Console.WriteLine((char) 97);


            // for(char ch='a'; ch<='z'; ch++)
            // {
            //     System.Console.WriteLine(ch);
            // }

            // Random rnd = new Random();
            // char rndchar= (char)rnd.Next(((int) 'A'), ((int)'Z')+1);
            // System.Console.WriteLine($"Randon karakter: {rndchar}");
            // char[] cht= new char[] {'r', 'K', 'i', '8'};
            // System.Console.Write(cht[2]);
            // cht[2] = 'X';
            // System.Console.Write(cht[2]);

            //stringek


            // string s = "Ez a keddi nap nagyon hosszú";

            // System.Console.WriteLine(s[6]);
            // // s[5] ="K"  :-<

            // string uj = string.Empty;


            // for (int i =0; i < s.Length; i++)
            // {
            //     if(s[i] !='e')
            //     {
            //         uj+= s[i];
            //     }
            //     else
            //     {
            //         uj +='E';
            //     }
            // }
            // System.Console.WriteLine(uj);


            // string esacape

            // string s= "\"Ég a napmelegtől a a kopár szík sarja...\" - Arany János ";


            // foreach(char ch in s)
            // {
            //     System.Console.Write(ch);
            // }





            // string összehasonlítás
            // string a = "egyik";
            // string b = "egyika";


            // int x = string.Compare(a,b);

            // if(x==0){System.Console.WriteLine("Megegyeznek");}
            // else if(x>0){System.Console.WriteLine("A b string nagyobb, mint az string");}

            // else{ System.Console.WriteLine("Az a sting nagyobb");}
            //if(a==b) mukodik



            //keres

            // string str= "verylongverylonglongstring";

            // char[] chars = new char[] {'y', 'z', 'o'};

            // //inedx
            // System.Console.WriteLine((str.IndexOf('r')));
            // System.Console.WriteLine(str.IndexOf('x'));
            // System.Console.WriteLine(str.LastIndexOf('o'));



            // //karakter
            // System.Console.WriteLine(str.IndexOfAny(chars));
            // System.Console.WriteLine(str.LastIndexOfAny(chars));


            // //true/false
            // System.Console.WriteLine(str.Contains("long"));



            //mod

             //kisbetu


            //  System.Console.WriteLine(str.ToUpper());
            //  System.Console.WriteLine("SAVEGGB".ToLower());   



            //  System.Console.WriteLine(str.Substring(3,5));

            //  System.Console.WriteLine(str.Substring(10)); // végig

            //  System.Console.WriteLine(str.Remove(8,2));



            // //beszur
            // System.Console.WriteLine(str.Insert(6,"SMALL"));
            // //csere

            // System.Console.WriteLine(str.Replace('o', 'O'));


            // //trimmel
            // string s = "   bla bla la    ";
            // System.Console.WriteLine(s.Trim());

            // s= "rrrrrrrrrrrrraaaaaarrrrrrrrr";

            // System.Console.WriteLine(s.Trim('r'));



            // //pudding


            // int ora = 6;
            // int perc = 9;

            // string sora= ora.ToString().PadLeft(2,'0');
            // string sperc= perc.ToString().PadLeft(2,'0');

            // System.Console.WriteLine($"{sora}:{sperc}");

            // double d1= 0.123;
            // double d2 = 34.1;
            // double d3= 12.0;
            // string sd1 = d1.ToString();
            // string sd2 = d2.ToString();
            // string sd3 = d3.ToString();

            // sd1= sd1.Substring(0, sd1.IndexOf(',')) + ',' + sd1.Substring(sd1.IndexOf(',')+1).PadRight(3, '0');
            // sd2= sd2.Substring(0, sd2.IndexOf(',')) + ',' + sd2.Substring(sd2.IndexOf(',')+1).PadRight(3, '0');
            // //  sd3= sd3.Substring(0, sd3.IndexOf(',') !=-1?) + ',' + sd3.Substring(sd3.IndexOf(',')+1).PadRight(3, '0');

            // System.Console.WriteLine(sd1);
        

            //1. fel

            // System.Console.WriteLine("c:\\alma");
            // System.Console.WriteLine("c:\\\\alma");

            // //2.fel
            // int c=0;
            // System.Console.WriteLine("Adj meg egy mondatot: ");
            // string inp = System.Console.ReadLine();
            
            // foreach(char ch in inp)
            // {
            //     if(ch == 'a')
            //     {
            //         c+=1;
            //     }
            // }
            // System.Console.WriteLine(c);
            //3.fel
            // int c=0;

            // System.Console.WriteLine("Adj meg egy mondatot: ");
            // string inp = System.Console.ReadLine();
            // System.Console.WriteLine("Adj meg a betüt: ");
            // char inp_char = System.Console.ReadKey().KeyChar;
            // System.Console.WriteLine();
            // foreach(char ch in inp)
            // {
            //     if(ch == inp_char)
            //     {
            //         c+=1;
            //     }
            // }
            // System.Console.WriteLine(c);

            //4.fel
            System.Console.WriteLine("Adj meg egy mondatot: ");
            string inp = System.Console.ReadLine();
            Dictionary<char, int> stats = new Dictionary<char, int>();
            foreach(char ch in inp)
            {
                foreach(var num in stats)
                {
                    if (num.Key != ch)
                    {
                        stats.Add(ch,0);
                    }
                }
               
            }

            foreach(char ch in inp)
            {
                foreach(var ele in stats)
                {
                    if (ele.Key == ch)
                    {
                        stats[ele.Key]++;
                    }
                }
            }
            foreach(var ele in stats)
            {
                System.Console.WriteLine($"{ele.Key}: {ele.Value}");
            }
        
            
        }
    }
}