using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace MyApp
{
    internal class Program
    {
        static int[,] MatrixLetrehoz()
        {
            FileStream fs= new FileStream("remhir.be", FileMode.Open);
            StreamReader sr= new StreamReader(fs);
            string sor = sr.ReadLine();
            string[] adatok = sor.Split(' ');
            int[,] m = new int[int.Parse(adatok[0]),int.Parse(adatok[0])];
            while((sor = sr.ReadLine()) != null)
            {
                adatok = sor.Split(' ');
                m[int.Parse(adatok[0])-1,int.Parse(adatok[1])-1]=1;

            }
            sr.Close();
            fs.Close();
            return m;
        }

        static int OszlopCount(int[,] m, int oszlop)
        {
            int c=0;
            for(int i =0;i<m.GetLength(0);i++)
            {
                if(m[i,oszlop]==1)
                {
                    c++;
                }
            }
            return c;
        }
        static int SorCount(int[,] m, int sor)
        {
            int c =0;
            for(int j=0; j<m.GetLength(1); j++)
            {
                if(m[sor,j]==1)
                {
                    c++;
                }
            }
            return c;
        }

        static int Indul(int[,] m)
        {
            for(int j = 0; j<m.GetLength(1);j++)
            {
                if(OszlopCount(m, j) ==0)
                {
                    return j+1;
                }
            }
            return -1;
        }
        static int[] NemTovabbAd(int[,]m)
        {
            int[] nemadok = new int[m.GetLength(0)];
            int c =0;
            for(int i = 0; i<m.GetLength(0);i++)
            {
                if(SorCount(m,i)==0)
                {
                    nemadok[c] = i+1;
                }
                c++;
            }
            return nemadok;
        }
        static int Max(int[,] m)
        {
            int max= SorCount(m, 0);
            for(int i =0; i < m.GetLength(0); i++)
            {
                if(max<SorCount(m, i))
                {
                    max= SorCount(m,i);
                }
            }
            return max;

        }
        static void Main(string[] args)
        {
            int[,] m= MatrixLetrehoz();
            for(int i =0; i<m.GetLength(0);i++)
            {
                for(int j =0; j<m.GetLength(1);j++)
                {
                    System.Console.Write(m[i,j]);
                }
                System.Console.WriteLine();
            }
              System.Console.WriteLine("A:");
            System.Console.WriteLine(Indul(m));
            System.Console.WriteLine("B:");
            foreach(int i in NemTovabbAd(m))
            {
                if(i!=0)
                System.Console.WriteLine(i);
            }
            System.Console.WriteLine("C:");
            for(int i =0 ; i<m.GetLength(0);i++)
            {
                if(SorCount(m,i) == Max(m))
                {
                    System.Console.WriteLine(i+1);
                }
            }
        }
    }
}