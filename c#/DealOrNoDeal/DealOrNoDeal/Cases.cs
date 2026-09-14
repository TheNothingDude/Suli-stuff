using System;
using System.Collections.Generic;

namespace _11C_All_Az_Alku
{
    static class Taskak
    {
        static Taska[] taskak = new Taska[23];
        static List<int> osszegek = new List<int>
        {
            50000000, 20000000, 15000000, 10000000, 7000000, 5000000, 2500000, 1000000, 800000, 500000, 300000, 150000, 80000, 50000, 25000, 10000, 5000, 1000, 500, 100, 10, 5, 1
        };
        static Random rand = new Random();
        static int korok = 1;
        static int[] nyitasok = new int[9] { 5, 3, 3, 3, 2, 2, 2, 1, 1 };
        static double[] ajanlatSzazalek = new double[9]
        {0.2, 0.3, 0.3, 0.3, 0.5, 0.5, 0.5, 0.6, 0.7 };


        private static int GetOsszeg()
        {
            if (osszegek.Count == 0)
                return -1;

            int index = rand.Next(0, osszegek.Count);
            int osszeg = osszegek[index];
            osszegek.RemoveAt(index);

            return osszeg;
        }


        private static void InitTaskak()
        {
            for (int i = 0; i < taskak.Length; i++)
                taskak[i] = new Taska(GetOsszeg(), i + 1);

        }


        public static void StartJatek()
        {
            Console.ForegroundColor = ConsoleColor.White;
            InitTaskak();
            TaskakRajzol();
        }

        private static void TaskakRajzol(int x = 0, int y = 0)
        {
            Console.SetCursorPosition(x, y);
            int width = Console.WindowWidth;
            int egySorba = 0;

            for (int i = 0; i < taskak.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                if (taskak[i].Sorszam == Taska.JatekosTaska)
                    Console.ForegroundColor = ConsoleColor.Blue;
                else if (taskak[i].Nyitva)
                    Console.ForegroundColor = ConsoleColor.Red;

                Taska.TaskaKirajzol(x, y, taskak[i].Sorszam);
                x += 6;
                egySorba++;

                if (width / 6 == egySorba)
                {
                    y += 4;
                    x = 0;
                    egySorba = 0;
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n");
        }


        public static int BankAjanlat()
        {
            int osszeg = 0;
            int db = 0;
            for (int i = 0; i < taskak.Length; i++)
                if (!taskak[i].Nyitva)
                {
                    osszeg += taskak[i].Osszeg();
                    db++;
                }

            double atlag = (double)osszeg / db;

            int rFaktor = rand.Next(-25000, 25000);

            return
               Math.Abs(((int)Math.Floor(atlag * ajanlatSzazalek[korok - 1])) + rFaktor);
        }
    }
}
