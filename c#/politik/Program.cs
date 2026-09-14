using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;

namespace MyApp
{
    internal class Program
    {
        public struct Jelolt
        {
            public int ker;
            public int szavazat;
            public string nev;
            public string part;
        }

        static void FajlOlvas(ref Jelolt[] t)
        {
            FileStream fs= new FileStream("szavazatok.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string sor;
            while((sor = sr.ReadLine()) != null)
            {
                string[] adatok = sor.Split(' ');
                Jelolt act;
                act.ker = int.Parse(adatok[0]);
                act.szavazat = int.Parse(adatok[1]);
                act.nev = adatok[2] + " " + adatok[3];
                act.part = adatok[4];
                Add(ref t, act);
            }
            
            
            sr.Close();
            fs.Close();   
        }


        static void Add(ref Jelolt[] t, Jelolt uj)
        {
            Jelolt[] tmp = new Jelolt[t.Length+1];
            for(int i=0; i<t.Length;i++)
            {
                tmp[i] = t[i];
            } 
            tmp[t.Length] = uj;
            t=tmp;
        }
        static string Szavazat(Jelolt[] t, string nev)
        {
            foreach(Jelolt n in t)
            {
                if(nev == n.nev)
                {
                    return $"A képveselőjelölt {n.szavazat} szavazatot kappott";
                }
            }
            return "Ilyen nevű képviselő nem szerepel a nyilvántartásban";
        }
        static int Sum(Jelolt[] t)
        {
            int s =0;
            foreach(Jelolt n in t)
            {
                s+=n.szavazat;
            }
            return s;
        }
        static double Arany(Jelolt[] t)
        {
            return Math.Round(Sum(t) / (double)(12345)*100, 2);
        }

        static Dictionary<string, double>Partok(Jelolt[] t)
        {
            Dictionary<string, double> partok = new Dictionary<string, double>();
            foreach(Jelolt n in t)
            {
                if(!partok.ContainsKey(n.part))
                {
                    partok[n.part] =0;
                }
            }
            foreach(var ele in partok)
            {
                foreach(Jelolt n in t)
                {
                    if(ele.Key==n.part)
                    {
                        partok[ele.Key]+=n.szavazat;
                    }
                }
            }
            foreach(var ele in partok)
            {
                partok[ele.Key] =  Math.Round(ele.Value/Sum(t)*100, 2);
            }
            return partok;
    

        }
        static int Max(Jelolt[] t)
        {
            int max=0;
            foreach(Jelolt n in t)
            {
                if(n.szavazat> max)
                {
                    max = n.szavazat;
                }
            }
            return max;
        }
    static Jelolt KiNyer(Jelolt[] t, int ker)
    {

     Jelolt winner = t[0];
     winner.szavazat = 0;
     foreach (Jelolt j in t)
     {
         if (j.ker == ker && winner.szavazat > j.szavazat)
         {
             winner = j;
         }
     }
     if(winner.szavazat !=0)
     {
         return winner;
     }
     else
     {
         winner.ker = -1;
         return winner;
     }
    }
        static Dictionary<int, Jelolt> Keruletek(Jelolt[] t)
       {
           Dictionary<int, Jelolt> nyerok = new Dictionary<int, Jelolt>();
           int i = 1;
           Jelolt j;
           while((j= KiNyer(t, i)).szavazat != -1)
           {
               nyerok[i] = j;
               i++;
           }
           return nyerok;
       }
        static void Main(string[] args)
        {

            Jelolt[] jeloltek = new Jelolt[0];

            FajlOlvas(ref jeloltek);

            // for(int i=0; i< jeloltek.Length; i++)
            // {
            //     System.Console.WriteLine($"{jeloltek[i].ker}, {jeloltek[i].szavazat}, {jeloltek[i].nev}, {jeloltek[i].part}");
            // }
            System.Console.WriteLine("2. feladat: ");
            System.Console.WriteLine($"A helyhatósági választáson {jeloltek.Length} képviselőjelölt indult");
            System.Console.WriteLine("3. feladat: ");
            System.Console.WriteLine(Szavazat(jeloltek,"Hold Ferencz"));
            System.Console.WriteLine("4 feladat: ");
            System.Console.WriteLine($"A választáson {Sum(jeloltek)} állampolgár, a jogosultak {Arany(jeloltek)}% vett részt");

            System.Console.WriteLine("5. feladat: ");
            foreach(var ele in Partok(jeloltek))
            {
                if(ele.Key == "-")
                {
                    System.Console.WriteLine($"Független jelöltek: {ele.Value}");
                }
                else
                {
                    System.Console.WriteLine($"{ele.Key}: {ele.Value}%");
                }
            }
            System.Console.WriteLine("6. feladat: ");
            foreach(Jelolt n in jeloltek)
            {
                if(n.szavazat == Max(jeloltek))
                {
                    System.Console.WriteLine($"A legtöbb szavatatott kapott {n.nev}, {n.part} tagja és {n.szavazat} szavazatott kapott");
                }
            }
            //7
            System.Console.WriteLine();
            foreach(var ele in Keruletek(jeloltek))
            {
                Console.WriteLine($"{ele.Key}:{ele.Value}");
            }

         
        }
    }
}