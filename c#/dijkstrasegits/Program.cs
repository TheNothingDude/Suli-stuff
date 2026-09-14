using System;

namespace MyApp
{
    internal class Program
    {
        /// <summary>
        /// How many 1s in a matrix
        /// </summary>
        /// <param name="m">matrix</param>
        /// <param name="oszlop">oszlop</param>
        /// <returns></returns>
        static int HanyKap(int[,] m, int oszlop)
        {
            int db =0;
            oszlop--;
            for(int j =0; j< m.GetLength(0); j++)
            {
                if(m[j,oszlop] !=0)
                {
                    db++;
                }
            }
            return db;
            
        }
/// <summary>
/// első olyan sorszám akitől kap
/// </summary>
/// <param name="m"></param>
/// <param name="oszlop"></param>
/// <returns></returns>
        static int ElsoAjandekozo(int[,] m, int oszlop)
        {
            oszlop--;
            for(int j =0; j< m.GetLength(0); j++)
            {
                if(m[j,oszlop] ==1)
                {
                    return j+1;
                }
            }    
            return -1;
        }
        static int MasodikAjandekozo(int[,] m, int oszlop)
        {
            oszlop--;
            bool elso_e = false;
            for(int j =0; j< m.GetLength(0); j++)
            {
                if(m[j,oszlop] ==1 && elso_e)
                {
                    return j + 1;
                }
                else if(m[j,oszlop] ==1 && !elso_e)
                {
                    elso_e = true;
                }
                    
            }    
            return -1;
        }
        
        static void Main(string[] args)
        {
            int[,] ajandekgraf =
            {
                {0,1,0,0,0,0,0,0,0},
                {0,0,1,0,0,0,0,0,0},
                {0,0,0,1,0,0,0,0,0},
                {0,0,0,0,1,0,0,0,0},
                {0,0,1,0,0,0,0,0,0},
                {0,0,0,0,1,0,0,0,0},
                {0,0,0,0,0,0,0,1,0},
                {0,0,0,0,0,0,0,0,1},
                {0,0,0,0,0,0,0,1,0}
            };

            for(int i =1; i < ajandekgraf.GetLength(1);i++)
            {
                while(HanyKap(ajandekgraf,i) >1)
                {
                    int Ado = ElsoAjandekozo(ajandekgraf, i);
                    bool csere = false;

                    for(int k=1; k<ajandekgraf.GetLength(1) && !csere; k++)
                    {
                        if(Ado == k && HanyKap(ajandekgraf, i) ==0) 
                        {
                            Ado = MasodikAjandekozo(ajandekgraf, i);
                        }
                        if(HanyKap(ajandekgraf, k) ==0)
                        {
                            System.Console.Write($"i={i}, k={k}, ado={Ado}");
                            ajandekgraf[Ado-1, k-1] = 1;
                            ajandekgraf[Ado-1, i-1] =0;
                            csere = true;
                        }
                    }
                    System.Console.WriteLine();
                }
            }
            
            for(int i =0; i < ajandekgraf.GetLength(0); i++)
            {
                for(int j =0; j <  ajandekgraf.GetLength(1); j++)
                {
                    System.Console.Write(ajandekgraf[i,j] + " ");
                }
                System.Console.WriteLine();
            }
        }
    }
}