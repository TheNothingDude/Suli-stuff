using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http.Headers;

namespace LegyenOnIsMilliomos
{
    public struct question
    {
        public int difficulty;
        public string question_string;
        public string A_answear;
        public string B_answear;
        public string C_answear;
        public string D_answear;
        public char correctAnswear;
        public string category;
    }

    static class Questions
    {
        public static question[][] qsorted;
        static question[] q = new question[0];

        static void Add<T>(ref T[] tomb, T ujElem)
        {
            T[] tmp = new T[tomb.Length + 1];
            for (int i = 0; i < tomb.Length; i++)
                tmp[i] = tomb[i];
            tmp[tmp.Length - 1] = ujElem;
            tomb = tmp;
        }

        static question[] SortHelp(int diff)
        {
            question[] array = new question[0];
            foreach(question q1 in q)
            {
                if(q1.difficulty == diff)
                {
                    Add(ref array, q1);
                }
            }
            return array;
        }
        static void Sort()
        {
            qsorted = new question[15][];
            for(int i = 1;i <= 15; i++)
            {
                qsorted[i-1] = SortHelp(i);
            }
        }
        public static void ReadCvs()
        {
            FileStream fs = new FileStream("./loim.csv", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            sr.ReadLine();
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                question q1 = new question();
                string[] data = line.Split(';');
                q1.difficulty = int.Parse(data[0]);
                q1.question_string = data[1];
                q1.A_answear = data[2];
                q1.B_answear = data[3];
                q1.C_answear = data[4];
                q1.D_answear = data[5];
                q1.correctAnswear = char.Parse(data[6]);
                q1.category = data[7];
                Add(ref q, q1);

            }
            sr.Close();
            fs.Close();
            Sort();

        }
     
    }
}
