using System;

namespace _11C_LinkedList
{
    class Node
    {
        int data;
        Node next;

        public Node(int data)
        {
            this.data = data;
            next = null;
        }

        public int Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }

        public Node Next
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }
    }

    class LinkedList
    {
        Node head;
        int count;

        public LinkedList()
        {
            head = null;
            count = 0;
        }

        // Másoló konstruktor
        public LinkedList(LinkedList other)
        {
            head = null;
            count = 0;
            for (Node p = other.head; p != null; p = p.Next)
                AddLast(p.Data);
        }

        // Csere
        private void Switch(Node a, Node b)
        {
            int tmp = a.Data;
            a.Data = b.Data;
            b.Data = tmp;
        }
        // Rendező metódust
        public void Sort(bool asc = true)
        {
            for (Node i = head; i.Next != null; i = i.Next)
            {
                for (Node j = i.Next; j != null; j = j.Next)
                {
                    if ((asc && j.Data < i.Data) || (!asc && j.Data > i.Data))
                        Switch(i, j);
                }
            }
        }

        public int? this[int index]
        {
            get
            {
                if (index >= 0 && index < count)
                {
                    Node p = head;
                    for (int i = 0; i < count; i++, p = p.Next)
                    {
                        if (i == index)
                            return p.Data;
                    }
                }

                return null;
            }
            set
            {
                if (index >= 0 && index < count)
                {
                    Node p = head;
                    for (int i = 0; i < count; i++, p = p.Next)
                    {
                        if (i == index)
                        {
                            p.Data = (int)value;
                            return;
                        }
                    }
                }
            }
        }

        public void AddFirst(int value)
        {
            Node newNode = new Node(value);

            if (count == 0)
            {
                head = newNode;
                count++;
                return;
            }

            newNode.Next = head;
            head = newNode;
            count++;
        }

        public void AddLast(int value)
        {
            Node newNode = new Node(value);

            if (count == 0)
            {
                head = newNode;
                count++;
                return;
            }

            Node p;
            for (p = head; p.Next != null; p = p.Next);

            p.Next = newNode;
            count++;
        }


        public bool Contains(int value)
        {
            for (Node p = head; p != null; p = p.Next)
                if (p.Data == value)
                    return true;

            return false;
        }

        public int? RemoveFirst()
        {
            if (count == 0)
            {
                return null;
            }

            int ret = head.Data;

            head = head.Next;
            count--;

            return ret;
        }

        public int? RemoveLast()
        {
            if (count == 0)
            {
                return null;
            }

            int ret;

            Node p;
            for (p = head; p.Next.Next != null; p = p.Next) ;
            ret = p.Next.Data;
            p.Next = null;

            count--;
            return ret;
        }

        public void Clear()
        {
            head = null;
            count = 0;
        }

        public void Reverse()
        {
            LinkedList tmp = new LinkedList();

            for (Node p = head; p != null; p = p.Next)
                tmp.AddFirst(p.Data);

            head = tmp.head;
        }

        // LL bejárása
        public string ToString()
        {
            string s = "";

            /*
            Node p = head;
            while(p != null)
            {
                s += p.Data + " ";
                p = p.Next;
            }
            */

            for (Node p = head; p != null; p = p.Next)
                s += p.Data + " ";

            return s;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList l = new LinkedList();
            l.AddFirst(13);
            l.AddFirst(15);
            l.AddFirst(6);
            l.AddFirst(7);
            l.AddFirst(69);
            l.AddFirst(100);
            l.AddFirst(50);

            l.AddLast(2);
            l.AddLast(8);
            l.AddLast(51);


            l[2] = -1;

            Console.WriteLine(l.ToString());

            l.RemoveFirst();
            Console.WriteLine(l.ToString());
            l.RemoveFirst();
            Console.WriteLine(l.ToString());


            l.RemoveLast();
            Console.WriteLine(l.ToString());
            l.RemoveLast();
            Console.WriteLine(l.ToString());


            l.Reverse();
            Console.WriteLine(l.ToString());


            Console.WriteLine("\n");

            LinkedList l2 = new LinkedList(l);
            l2.AddFirst(7);
            l2.AddFirst(2);
            l2.AddFirst(19);
            l2.AddFirst(-8);

            Console.WriteLine(l2.ToString());
            l2.Sort();
            Console.WriteLine(l2.ToString());
            l2.Sort(false);
            Console.WriteLine(l2.ToString());


            Console.ReadKey();
        }
    }
}