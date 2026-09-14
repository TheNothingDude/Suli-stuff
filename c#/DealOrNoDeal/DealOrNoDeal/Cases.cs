using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealOrNoDeal
{
    static class Cases
    {
        static Case[] cases = new Case[23];
        static List<int> values = new List<int>
        {
            50000000, 20000000, 15000000, 10000000, 7000000, 5000000, 2500000, 1000000, 800000, 500000, 300000, 150000,
            80000, 50000, 25000, 10000, 5000, 1000, 500, 100, 10, 5, 1
        };
        static int rounds = 1;
        static int[] Openings = new int[9] { 5,3,3,3,2,2,2,1,1};
        static double[] offerPercent = new double[9] { 0.2, 0.3, 0.3, 0.3, 0.5, 0.5, 0.5, 0.6, 0.7 };
        static Random rnd = new Random();
        private static int GetValue()
        {
            if (values.Count == 0)
            {
                return -1;
            }
            int index = rnd.Next(0, values.Count);
            int value = values[index];
            values.RemoveAt(index);
            return value;
        }

        private static void InitCases()
        {
            for (int i = 0; i < cases.Length; i++)
                cases[i] = new Case(GetValue(), i + 1);
        }

        public static void StartGame()
        {
            InitCases();
            CaseDraw();
        }
        private static void CaseDraw(int x =0, int y = 0)
        {
            Console.SetCursorPosition(x, y);
            int width = Console.WindowWidth;
            int oneLine =0;

            for(int i  = 0; i < cases.Length; i++)
            {
                cases[i].DrawCase(x, y);
                x += 6;
                oneLine++;

                if(width / 6 <= oneLine)
                {
                    y += 4;
                    x = 0;
                    oneLine = 0;
                }
            }

            Console.WriteLine();
            Console.WriteLine();
        }



        public static int BankOffer(int round)
        {
            int sum = 0;
            int c = 0;
            for(int i = 0;i < cases.Length;i++)
            {
                if (!cases[i].Opened)
                {
                    sum += cases[i].Value;
                    c++;
                }
            }
            double avg = (double)sum / c;
            int rFakt = rnd.Next(-25000, 25000);
            return Math.Abs((int)Math.Floor(avg * offerPercent[round-1]) + rFakt);
        }
    }
}
