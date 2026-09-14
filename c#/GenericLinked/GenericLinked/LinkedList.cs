using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GenericLinked
{
    internal class LinkedList<T> : IEnumerable<T> where T : IComparable<T>
    {
        Node<T> head;
        Node<T> tail;
        int count;
        public int Count { get { return count; } }
        public LinkedList()
        {
            count = 0;
            tail = null;
            head = null;
        }

        public void AddFirst(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (count == 0)
            {
                head = newNode;
                tail = newNode;
                count++;
                return;
            }
            newNode.Next = head;
            head.Prev = newNode;
            head = newNode;
            count++;
        }
        public void AddLast(T item)
        {
            if (count == 0)
            {
                AddFirst(item);
                return;
            }
            Node<T> newNode = new Node<T>(item);
            newNode.Prev = tail;
            tail.Next = newNode;
            tail = newNode;
            count++;
        }
        public T RemoveFirst()
        {
            if (count == 0)
            {
                return default(T);
            }
            T r = head.Data;
            if (count == 1)
            {
                tail = tail.Next;
                head = head.Next;
                count--;
                return r;
            }
            head = head.Next;
            count--;
            return r;
        }
        public T RemoveLast()
        {
            if (count == 0)
            {
                return default(T);
            }
            T r = tail.Data;
            if (count == 1)
            {
                tail = tail.Next;
                head = head.Next;
                count--;
                return r;
            }
            tail = tail.Prev;
            tail.Next.Prev = null;
            tail.Next = null;   
            count--;
            return r;
        }
        private void Switch(Node<T> a , Node<T> b)
        {
            T tmp = a.Data;
            a.Data = b.Data;
            b.Data = tmp;
        }
        public void Sort()
        {
            for(Node<T> i = head; i.Next != null; i = i.Next)
            {
                for(Node<T> j = i.Next; j != null; j = j.Next)
                {
                    if(i.Data.CompareTo(j.Data) > 0)
                    {
                        Switch(i, j);
                    }
                }
            }
        }
        public bool Contains(T value)
        {
            for(Node<T> node = head; node != null; node = node.Next)
            {
                if(node.Data.Equals(value))
                {
                    return true;
                }
            }
            return false;
        }
        public void Insert(int index, T value)
        {
            if(count == 0)
            {
                AddFirst(value);
                return; 
            }
            Node<T> newNode = new Node<T>(value);
            int c = 0;
            for(Node<T> i = head; i != null; i = i.Next, c++)
            {
                if(c == index-1)
                {


                    newNode.Prev = i;
                    newNode.Next = i.Next.Next;
                    if(i.Prev != null)
                        i.Prev.Next = newNode;
                    i.Next.Prev = newNode;
                    i.Next = newNode;
                }
            }
            count++;
        }
        public T this[int i]
        {

            get 
            {
                if(i < 0  || i >= count)
                {
                    throw new IndexOutOfRangeException();
                }
                int c = 0;
                if(i <= count/2)
                {
                    for (Node<T> node = head; node != null; node = node.Next, c++)
                    {
                        if (c == i)
                        {
                            return node.Data;
                        }
                    }
                    return default(T);
                }
                else
                {
                    c = count;
                    for (Node<T> node = tail; node != null; node = node.Prev, c--)
                    {
                        if(c == i)
                        {
                            return node.Data;
                        }
                    }
                    return default(T);
                }
            }
            set
            {
                if (i < 0 || i >= count)
                {
                    throw new IndexOutOfRangeException();
                }
                int c = 0;
                if (i <= count / 2)
                {
                    for (Node<T> node = head; node != null; node = node.Next, c++)
                    {
                        if (c == i)
                        {
                            node.Data = value;
                        }
                    }
                }
                else
                {
                    c = count;
                    for (Node<T> node = tail; node != null; node = node.Prev, c--)
                    {
                        if (c == i)
                        {
                            node.Data = value;
                        }
                    }
                }

            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            for(Node<T> node = head; node != null; node = node.Next)
            {
                yield return node.Data;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public override string ToString()
        {
            string s = string.Empty;
            for (Node<T> i = head; i != null; i = i.Next)
            {
                s += $"{i.Data}, ";
            }
            return s;
        }
    }
}
