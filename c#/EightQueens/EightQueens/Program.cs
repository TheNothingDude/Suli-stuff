// C# program to implement 8 queen problem
using System;
namespace Eightqueens
{
    class Queen
    {
        static int solutionCount = 0;
        static bool hasPrintedExample = false;
        static bool isSafe(int[,] mat, int row, int col)
        {
            int n = mat.GetLength(0);
            int i, j;

            for (i = 0; i < row; i++)
                if (mat[i, col] == 1)
                    return false;

            for (i = row - 1, j = col - 1; i >= 0 && j >= 0; i--, j--)
                if (mat[i, j] == 1)
                    return false;

            for (i = row - 1, j = col + 1; j < n && i >= 0; i--, j++)
                if (mat[i, j] == 1)
                    return false;

            return true;
        }
        static void PrintBoard(int[,] mat)
        {
            int n = mat.GetLength(0);
            Console.WriteLine("Example Solution Layout:");
            Console.WriteLine("-------------------------");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mat[i, j] == 1 ? " Q " : " . ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------\n");
        }
        static void placeQueens(int row, int[,] mat)
        {
            int n = mat.GetLength(0);

            if (row == n) { 
                solutionCount++;
                if (!hasPrintedExample)
                {
                    PrintBoard(mat);
                    hasPrintedExample = true;
                }
                return; 
            }
                

            for (int i = 0; i < n; i++)
            {

                if (isSafe(mat, row, i))
                {
                    mat[row, i] = 1;
                    placeQueens(row + 1, mat);
                    mat[row, i] = 0;
                }
            }
        }
        static void Main()
        {
            solutionCount = 0;
            hasPrintedExample = false;

            int[,] mat = new int[8, 8];

            placeQueens(0, mat);

            Console.WriteLine($"Total number of solutions found: {solutionCount}");
        }
    }

}