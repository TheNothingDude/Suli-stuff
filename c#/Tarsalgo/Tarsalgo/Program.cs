using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Tarsalgo
{


    internal class Program
    {
        struct embi
        {
            public int ora;
            public int perc;
            public int id;
            public bool be;
        }
        static void Add(ref embi[] t, embi e)
        {
            embi[] tmp = new embi[t.Length+1];
            for (int i = 0;i<t.Length;i++)
            {
                tmp[i] = t[i];
            }
            tmp[t.Length] = e;
            t= tmp;
        }
        static void Add(ref int[] t, int e)
        {
            int[] tmp = new int[t.Length + 1];
            for (int i = 0; i < t.Length; i++)
            {
                tmp[i] = t[i];
            }
            tmp[t.Length] = e;
            t = tmp;
        }
        static embi[] Tarolas()
        {
            FileStream fs = new FileStream("ajto.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            embi[] embik = new embi[0];
            string sor;
            string[] data;
            while((sor =sr.ReadLine()) != null)
            {
                data = sor.Split(' ');
                embi e;
                e.ora = int.Parse(data[0]);
                e.perc = int.Parse(data[1]);
                e.id = int.Parse(data[2]);
                if (data[3] =="be")
                {
                    e.be = true;
                }
                else
                {
                    e.be= false;
                }
                Add(ref embik, e);
                
            }
            sr.Close();
            fs.Close();
            return embik;

        }
        static Dictionary<int, int> Hanyszor(embi[] t)
        {
            Dictionary<int,int> hany = new Dictionary<int,int>();
            foreach(embi e in t)
            {
                if(!hany.ContainsKey(e.id))
                {
                    hany.Add(e.id, 0);
                }
            }
            foreach(embi e in t) 
            {
                hany[e.id]++;
            }
            return hany;
        }

        static bool Kiment(embi[] t, int id)
        {
            for(int i = t.Length - 1; i >= 0; i--)
            {
                if(t[i].id == id && t[i].be ==true)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            embi[] embik = Tarolas();

            //1
            Console.WriteLine("1 fel");
            Console.WriteLine($"első {embik[0].id}");
            bool megvan=false; 
            for(int i = embik.Length-1;  i >= 0 && megvan != true; i-- )
            {
                if (embik[i].be==false)
                {
                    Console.WriteLine($"utolso {embik[i].id}");
                    megvan = true;

                }
            }
            Dictionary<int, int> dict = Hanyszor(embik);
            FileStream fs = new FileStream("adhaladas.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            for(int i = 1; i<=41; i++)
            {
                if(dict.ContainsKey(i))
                {
                    sw.WriteLine($"{i}:{dict[i]}");
                }
            }
            sw.Close();
            fs.Close();
            int[] ids= new int[0];
            foreach(var ele in dict)
            {
                Add(ref ids, ele.Key);
            }
            //4
            Console.WriteLine("4.fel");
            foreach(int i in ids)
            {
                if(!Kiment(embik, i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
