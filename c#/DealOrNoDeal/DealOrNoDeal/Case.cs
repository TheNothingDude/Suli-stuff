using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealOrNoDeal
{
    class Case
    {
        int value;
        bool opened;
        static int playersCase;
        int id;
        static char[,] draw = new char[,]
        {
            {'┌', '█', '█', '┐' },
            {'│', ' ', ' ', '│' },
            {'└', '─', '─', '┘' },
        };
        public int Id { get { return id; } }
        public bool Opened
        {
            get { return opened; }
        }
        public Case(int value, int id)
        {
            this.value = value;
            this.id = id;
            opened = false;
        }
        public static void SetPlayersCase(Case s)
        {
            playersCase = s.id;
        }

        public int Open()
        {
            opened = true;
            return value;
        }

        public int Value
        {
            get { return value; }
        }



        public void DrawCase(int x, int y)
        {
            for (int i = 0; i < draw.GetLength(0); i++)
            {
                for(int j = 0;  j < draw.GetLength(1); j++)
                {
                    Console.SetCursorPosition(x+ j, y + i);
                    Console.WriteLine(draw[i,j]);
                }
            }
            string num = id.ToString();
            if (id <= 9)
            {
                Console.SetCursorPosition(x+2, y+1);
                Console.WriteLine(num);
            }
            else
            {
                Console.SetCursorPosition(x+1, y+1);
                Console.Write(num[0]);
                Console.Write(num[1]);
            }
        }
    }
}
