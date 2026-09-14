using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Set
{
    class Set<T> where T : IComparable<T>
    {
        T[] data;
        int count;
        public int Count { get { return count; } }
        public Set()
        {
            data = new T[0];
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (data[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }
        public void Add(T item)
        {
            if (!Contains(item))
            {
                T[] tmp = new T[count + 1];
                for (int i = 0; i < count; i++)
                {
                    tmp[i] = data[i];
                }
                tmp[count] = item;
                data = tmp;
                count++;
            }

        }
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < count - 1; ++i)
            {
                s += data[i].ToString() + ", ";
            }
            s += data[count - 1].ToString();
            return s;
        }

        public void Remove(T item)
        {
            if (!Contains(item))
            {
                return;
            }
            bool find = false;
            T[] tmp = new T[count - 1];
            for (int i = 0; i < tmp.Length; ++i)
            {
                if (data[i].Equals(item)) { find = true; }
                if (!find)
                    tmp[i] = data[i];
                else tmp[i] = data[i + 1];
            }
            data = tmp;
            count--;
        }

        public T Max()
        {
            T max = data[0];
            for (int i = 1; i < count; ++i)
            {
                if (data[i].CompareTo(max) > 0)
                {
                    max = data[i];
                }
            }
            return max;
        }
        public T Min()
        {
            T min = data[0];
            for (int i = 1; i < count; ++i)
            {
                if (data[i].CompareTo(min) < 0)
                {
                    min = data[i];
                }
            }
            return min;
        }
        public static Set<T> Intersect(Set<T> A, Set<T> B)
        {
            Set<T> s = new Set<T>();
            for (int i = 0; i < A.Count; ++i)
            {
                if (B.Contains(A.data[i]))
                {
                    s.Add(A.data[i]);
                }
            }
            return s;
        }
        public static Set<T> Except(Set<T> A, Set<T> B)
        {
            Set<T> s = new Set<T>();
            for (int i = 0; i < A.Count; ++i)
            {
                if (!B.Contains(A.data[i]))
                {
                    s.Add(A.data[i]);
                }
            }
            return s;
        }
        public static Set<T> Union(Set<T> A, Set<T> B)
        {
            Set<T> s = new Set<T>();
            for (int i = 0; i < A.Count; i++)
            {
                s.Add(A.data[i]);
            }
            for (int i = 0; i < B.count; i++)
            {
                s.Add(B.data[i]);
            }
            return s;
        }
        public static Set<T> operator /(Set<T> A, Set<T> B)
        {
            return Except(A, B);
        }

}

}
