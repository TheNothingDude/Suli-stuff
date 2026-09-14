using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Ellista
{
    class Ellista
    {
        Csucs[] graf = new Csucs[0];
        public Csucs[] Graf { get { return graf; }}
        public int Length
        {
            get { return graf.Length; }
        }

        public Ellista(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string line;
            string[] data;
            while ((line = sr.ReadLine()) != null)
            {
                data = line.Split(';');
                Add(new Csucs(data[0], RemoveFirst<string>(data)));                
            }
            sr.Close();
            fs.Close();
        }
        private void Add(Csucs a)
        {
            Csucs[] tmp = new Csucs[graf.Length+1];
            for (int i = 0; i <graf.Length; i++)
            {
                tmp[i] = graf[i];
            }
            tmp[graf.Length] = a;
            graf = tmp;
        }
        private T[] RemoveFirst<T>(T[] data)
        {
            T[] tmp = new T[data.Length-1];
            for (int i = 1; i < data.Length; i++)
            {
                tmp[i-1] = data[i];
            }
            return tmp;
        }
        public string ToString()
        {
            string s = "";
            for(int i = 0;i < graf.Length;i++)
            {
                s += $"{graf[i].Name} => ";
                foreach(Dict c in graf[i].Neigbors)
                {
                    s += $"{c.Name}: {c.Val}, ";
                }
                s += "\n";
            }
            return s;
        }
    }
}
