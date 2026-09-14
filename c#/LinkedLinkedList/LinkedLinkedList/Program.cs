using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLinkedList
{
    class Node
    {
        int data;
        Node next;
        Node prev;

        public Node(int data)
        {
            this.data = data;
            next = null;
            prev = null;
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
        public Node Previous
        {
            get { return prev; }
            set { prev = value; }
        }
    }
    class LinkedList
    { 
        Node head;
        Node tail;
        int count;

        public LinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public void AddFist(int val)
        {
            Node newNode = new Node(val);

            if (count == 0)
            {
                head = newNode;
                tail = newNode;
                count++;
                return;
            }
            newNode.Next = head;
            head.Previous = newNode;
            head = newNode;
            count++;
        }
        public void AddLast(int val)
        {
            Node newNode = new Node(val);

            if (count == 0)
            {
                head = newNode;
                tail = newNode;
                count++;
                return;
            }
            Node p;
            for (p = head; p.Next != null; p = p.Next);
            tail = newNode;
            newNode.Previous = p;
            p.Next = newNode;
            count++;

        }


        public int? this[int index]
        {
            get
            {
                if(index > 0 && index<count)
                {
                    Node p = head;
                    if (count / 2 < index)
                    {
                        for (int i = count; i > 0; i--, p = p.Next)
                        {
                            if (i == index)
                            {
                                return p.Data;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < count; i++, p = p.Next)
                        {
                            if (i == index)
                            {
                                return p.Data;
                            }
                        }
                    }
                }
                return null;
            }
        }
        public void InsertAt(int index, int val)
        {
           Node newNode = new Node(val);
           if(index>0 && index<count-1)
            {
                if(count/2 < index)
                {
                    Node p = tail;
                    for(int i = count;i > 0; i--, p = p.Previous)
                    {
                        if(i == index)
                        {
                         
                            p.Next.Previous = newNode;
                            newNode.Next = p.Next;
                            p.Next = newNode;
                            newNode.Previous = p;
                        }
                    }
                }
            }
           
        }
        public string ToString()
        {
            string r = "";
            for(Node p = head; p != null; p = p.Next)
            {
                r += $"{p.Data}, ";
   
            }
            return r;
        }
        public string ReverseString()
        {
            string r = "";
            for (Node p = tail; p != null; p = p.Previous)
            {
                r += $"{p.Data}, ";

            }
            return r;
        }
    
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList l = new LinkedList();
            l.AddFist(1);
            l.AddFist(2);
            l.AddLast(67);
            l.AddLast(31);
            l.InsertAt(3, 21);
            Console.WriteLine(l.ToString());
            Console.WriteLine(l.ReverseString());
            
        }
    }
}
