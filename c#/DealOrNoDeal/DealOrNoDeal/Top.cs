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
            int c = 0;
            FileStream fs = new FileStream("./toplista.csv", FileMode.Open);
            StreamWriter sw = new StreamWriter(fs);
            StreamReader sr = new StreamReader(fs);
            sw.WriteLine($"{name};{value}");
        }
        static public void Sort()
        {

        }
    }
}
