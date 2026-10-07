using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

namespace interfacesssss
{
    class Kepregeny
    {
        static FileStream fs;
        static StreamReader sr;
        static List<ISuperHero> szuperhosok = new List<ISuperHero>();
        public static void Szereplok(string path)
        {
            fs = new FileStream(path, FileMode.Open);
            sr = new StreamReader(fs);
            string line = string.Empty;
            while((line = sr.ReadLine()) != null)
            {
                string[] data = line.Split(" ");
                IMilliardos b = null;
                if(data[0] == "Vasember")
                {
                    b = new Vasember();
                }
                else if(data[0] == "Batman")
                {
                   b = new Batman();
                }
                for(int i = 0; i < int.Parse(data[1]); i++)
                {
                        b.kutyutKeszit();
                }
                szuperhosok.Add((b as ISuperHero));
            }
            sr.Close();
            fs.Close();
        }
        public static void Szuperhosok()
        {
            foreach(ISuperHero h in szuperhosok)
            {
                System.Console.WriteLine(h);
            }   
        }
    }
}