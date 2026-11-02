using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;

namespace Toto
{
    struct Question
    {
        public string QuestionString;
        public string A_ans;
        public string B_ans;
        public string X_ans;
        public char Correct;
    }
    static class Data
    {
        public static List<Question> qlist = new List<Question>();
        public static void ReadCsv(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            while ((line = sr.ReadLine()) != null) 
            {
                Question q = new Question();
                string[] data = line.Split(';');
                q.QuestionString = data[0];
                q.A_ans = data[1];
                q.B_ans = data[2];
                q.X_ans = data[3];
                q.Correct = char.Parse(data[4].ToLower());
                qlist.Add(q);
                
            }
            sr.Close();
            fs.Close();

        }
    }
}
