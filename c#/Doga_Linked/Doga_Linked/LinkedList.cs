using System;
using System.Runtime.InteropServices;


namespace Doga_Linked
{
    class LinkedList
    {
        Node head;
        int lenght;

        public LinkedList()
        {
            head = null;
            lenght = 0;
        }
        public LinkedList(double d)
        {
            head = new Node(d);
            lenght = 1;
        }
        public LinkedList(double[] ds)
        {
            foreach (double d in ds)
            {
                AddLast(d);
            }
        }
        public LinkedList(LinkedList other)
        {
            for (Node p = other.head; p != null; p = p.Next)
            {
                AddLast(p.Data);
            }
        }
        public void AddFirst(double d)
        {
            Node newNode = new Node(d);
            if(lenght == 0)
            {
                head = newNode;
                lenght++;
                return;
            }
            newNode.Next = head;
            head = newNode;
            lenght++;
        }
        public void AddLast(double d)
        {
            Node node = new Node(d);
            if (lenght == 0)
            {
                head = node;
                lenght++;
                return;
            }
            Node p;
            for (p = head; p.Next != null; p = p.Next);
            p.Next = node;
            lenght++;
        }
        public bool Contains(double d)
        {
            for(Node p = head; p != null;p = p.Next)
            {
                if(p.Data == d)
                {
                    return true;
                }
            }
            return false;
        }
        public double RemoveLast()
        {
            Node p;
            for (p = head; p.Next.Next!= null; p = p.Next);
            double r = p.Next.Data;
            p.Next = null;
            return r;
        }
        public string ToString()
        {
            string s = "";
            for(Node p = head; p != null; p= p.Next)
            {
                if(p.Next != null)
                {
                    s += $"{p.Data} -> ";
                }
                else
                {
                    s += p.Data;
                }
            }
            return s;
        }

        public double? this[int index]
        {
            get
            {
                if(index < lenght && index >= 0)
                {
                    Node p = head;
                    for(int i = 0; i < lenght; i++, p = p.Next)
                    {
                        if(i == index)
                        {
                            return p.Data;
                        }
                    }
                    return null;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
