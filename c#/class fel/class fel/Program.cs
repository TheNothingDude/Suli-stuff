using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_fel
{
    class Tomb
    {

        int[] t;
        public Tomb()
        {
            t = new int[0];
        }
        public Tomb(int item)
        {
            t = new int[1];
            t[0] = item;
        }
        public Tomb(Tomb other)
        {
            this.t = new int[other.t.Length];
            for (int i = 0; i < other.t.Length; i++)
            {
                this[i] = other[i];
            }
        }
        
        public int Elemszam
        {
            get { return t.Length; }
        }

        public bool TartalmazzaE(int item)
        {
            bool found = false;
            for(int i = 0; i < t.Length && !found; i++)
            {
                if (t[i] == item)
                {
                    found = true;
                }
            }
            return found;
        }

        public void Add(int newItem)
        {
            int[] tmp = new int[this.t.Length+1];
            for (int i = 0; i < t.Length; i++)
            {
                tmp[i] = (int)this[i];
            }
            tmp[t.Length] = newItem;
            t = tmp;
        }

        public int? this[int index]
        {
            get
            {
                if(index >= 0 && index < t.Length)
                    return t[index];
                return null;
            }
            set
            {
                if (index >= 0 && index < t.Length)
                    t[index] = (int)value;
            }
        }
        public void Remove(int index)
        {
            if(index < 0 && index < t.Length)
            {
                int[] tmp = new int[this.t.Length - 1];

                for (int i = 0; i < t.Length; i++)
                {
                    if (i < index)
                    {
                        tmp[i] = t[i];
                    }
                    else
                    {
                        tmp[i - 1] = t[i];
                    }

                }
                t = tmp;
            }
   
    
        }
        public string ToString()
        {
            string s = "";
            for(int i = 0;i < t.Length;i++)
            {
                s += $"{t[i]} ";
            }
            return s;
        }

        public void ErtekTorol(int item)
        {
            Tomb tmp = new Tomb();
            for(int i = 0;i < t.Length; i++)
            { 
                if (t[i] != item)
                {
                    tmp.Add(t[i]);
                }
            }
            t = tmp.t;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Tomb t = new Tomb();
            Tomb t2 = new Tomb(2);
            Tomb t3 = new Tomb(t2);
            t.Add(1);
            t.Add(2);
            t.Add(2);
            t.Add(4);
            t.Add(421);
            t.ErtekTorol(2);
            Console.WriteLine(t.ToString());
        }
    }
}
