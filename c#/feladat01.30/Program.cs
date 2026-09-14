    using System;
    using System.Reflection.Metadata;
    using System.IO;
    using System.Diagnostics;
    using System.Data.Common;
    using System.Xml.Serialization;
    using Microsoft.VisualBasic;
    namespace MyApp
    {
        internal class Program
        {
            static int[,] MatrixLertehoz()
            {
                FileStream fs = new FileStream("verseny.be", FileMode.Open);
                StreamReader sr= new StreamReader(fs);
                string sor = sr.ReadLine();
                string[] data = sor.Split(' ');
                int[,] m = new int[int.Parse(data[0]),int.Parse(data[0])];
                while((sor = sr.ReadLine()) != null)
                {
                    data = sor.Split(' ');
                    m[int.Parse(data[0])-1,int.Parse(data[1])-1]=1;
                }
                sr.Close();
                fs.Close();
                return m;
            }
            static int SorCount(int[,] m, int sor)
            {
                int c = 0;
                for(int j=0; j<m.GetLength(1);j++)
                {
                    if(m[sor,j]==1)
                    {
                        c++;
                    }
                }
                return c;            
            }
            static int OszlopCount(int[,] m, int oszlop)
            {
                int c = 0;
                for(int j=0; j<m.GetLength(0);j++)
                {
                    if(m[j,oszlop]==1)
                    {
                        c++;
                    }
                }
                return c;    
            }
            static bool[] Kiesett(int[,] m)
            {
                bool[] r= new bool[m.GetLength(0)];
                for(int j=0; j<m.GetLength(0);j++)
                {
                    if(OszlopCount(m,j) >0)
                    {
                        r[j]=true;
                    }
                }
                return r;
            }
            static int MaxKiesett(int[,] m)
            {
                int max=-1;
                for(int i =0; i<m.GetLength(0);i++)
                {
                    if(Kiesett(m)[i] == true)
                    {
                        if(max<SorCount(m,i))
                        {
                            max = SorCount(m,i);
                        }
                    }
                }
                for(int i =0; i<m.GetLength(0);i++)
                {
                    if(SorCount(m,i) == max)
                    {
                        return i+1;
                    }
                }
                return -1;
            }
            static void Main(string[] args)
            {
                int[,] m = MatrixLertehoz();

                for(int i = 0; i<m.GetLength(0);i++)
                {
                    for(int j=0;j<m.GetLength(1);j++)
                    {
                        System.Console.Write(m[i,j]);
                    }
                    System.Console.WriteLine();
                }

                System.Console.WriteLine(MaxKiesett(m));
            }
            
        }
    }