using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Stack<T>
    {
        T[] data;
        public int Count { get { return data.Length; }}
        public Stack()
        {
            data = new T[0];
        }
        public void Push(T val)
        {
            T[] tmp = new T[Count + 1];
            for(int i = 0; i < Count; i++)
            {
                tmp[i] = data[i];
            }
            tmp[Count] = val;
            data = tmp;
        }
        public T Pop()
        {
            if(Count == 0)
            {
                return default;
            }
            T ret = data[Count - 1];
            T[] tmp = new T[Count - 1];
            for(int i = 0;i < tmp.Length;i++)
            {
                tmp[i] = data[i];
            }
            data = tmp;
            return ret;
        }
        public bool Contains(T val)
        { 
            for(int i = 0; i <Count; i++)
            {
                if (data[i].Equals(val))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
