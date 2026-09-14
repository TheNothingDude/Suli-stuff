using System;

namespace _11C_All_Az_Alku
{
    internal class Taska
    {
        int osszeg;
        bool nyitva;
        int sorszam;
        public int Sorszam { get { return sorszam; } }
        public bool Nyitva { get { return nyitva; } }

        static int jatekosTaska;

        public Taska(int osszeg, int sorszam)
        {
            this.osszeg = osszeg;
            this.sorszam = sorszam;
            nyitva = false;
        }


        public static void JatekosTaskaBeallit(int sorszam)
        {
            jatekosTaska = sorszam;
        }

        public static int JatekosTaska
        {
            get { return jatekosTaska; }
        }

        public int Kinyit()
        {
            nyitva = true;
            return osszeg;
        }

        public int Osszeg()
        {
            return osszeg;
        }


        static char[,] taskaRajz = new char[,]
        {
            {'┌', '█', '█', '┐' },
            {'│', ' ', ' ', '│' },
            {'└', '─', '─', '┘' },
        };

        public static void TaskaKirajzol(int x, int y, int sorszam)
        {
            for (int i = 0; i < taskaRajz.GetLength(0); i++)
            {
                for (int j = 0; j < taskaRajz.GetLength(1); j++)
                {


                    Console.SetCursorPosition(x + j, y + i);
                    Console.Write(taskaRajz[i, j]);
                }
            }

            Console.SetCursorPosition(x + 1, y + 1);
            Console.Write(sorszam.ToString().PadLeft(2, ' '));
        }
    }
}
