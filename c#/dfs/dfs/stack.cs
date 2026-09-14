using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dfs
{
    class Stack
    {
        int[] data;
        public int Count
        { get { return data.Length; } }

        public Stack()
        {
            data = new int[0];
        }

        public void Push(int NewVal)
        {
            int[] tmp = new int[data.Length+1];
            tmp[0] = NewVal;
            for(int i = 1; i < tmp.Length; i++)
            {
                tmp[i] = data[i-1];
            }
            data = tmp;
        }
        public int? Pop()
        {
            if(Count == 0)
            {
                return null;
            }
            int ret = data[0];
            int[] tmp  = new int[data.Length-1];

            for(int i = 1;i<data.Length; i++)
            {
                tmp[i-1] = data[i];
            }

            data = tmp;
            return ret;
        }
    }
}
