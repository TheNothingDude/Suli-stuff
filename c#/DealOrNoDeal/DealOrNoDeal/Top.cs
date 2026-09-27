using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace DealOrNoDeal
{
    static class Top
    {

        static public void GenToplist()
        {
            FileStream fs = new FileStream("./toplista.csv", FileMode.Create);
            fs.Close();
        }
        static public void Add(string name, int value)
        {

            FileStream fs;
            if (File.Exists("./toplista.csv"))
            {
                fs = new FileStream("./toplista.csv", FileMode.Append);
            }
            else
            {
                fs = new FileStream("./toplista.csv", FileMode.Create);
            }
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine($"{name};{value}");
            sw.Close();
            fs.Close();
        }
        static public List<string> Sort()
        {
            List<string> l = new List<string>();
            if (!File.Exists("./toplista.csv"))
                return l;
            FileStream fs = new FileStream("toplista.csv", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string line = string.Empty;
            while ((line = sr.ReadLine()) != null)
            {
                if (!string.IsNullOrWhiteSpace(line))
                    l.Add(line);
            }
            sr.Close();
            fs.Close();
            for (int i = 0; i < l.Count - 1; i++)
            {
                for (int j = i + 1; j < l.Count; j++)
                {
                    if (int.Parse(l[i].Split(';')[1]) < int.Parse(l[j].Split(';')[1]))
                    {
                        string temp = string.Empty;
                        temp = l[i];
                        l[i] = l[j];
                        l[j] = temp;
                    }
                }
            }
            return l;
        }

    }
}
