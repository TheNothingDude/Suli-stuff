using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace fesu
{
    internal class SkipList
    {
        MainNode head;
        int gerincCount;

        public SkipList()
        {
            head = new MainNode();
            gerincCount = 0;
        }
        //copy constructor

        public void AddFirst(string data)
        {
            MainNode newNode = new MainNode(data);
            gerincCount++;
            if (gerincCount == 0)
            {
                head = newNode;
                return;
            }
            newNode.Next = head;
            head = newNode;

        }
        //remove
        public void AddFirst(string data, int index)
        {
            if(index> gerincCount || index <0)
            {
                return;
            }
            MainNode p;
            Node newNode = new Node(data);
            int c = 0;
            for (p = head; p.Next != null && c < index; p = p.Next, c++);
            if(p.NodeCount == 0)
            {
                p.Down = newNode;
                p.NodeCount++;
                return;
            }
            newNode.Down = p.Down;
            p.Down = newNode;
            p.NodeCount++;
        }
        public string ToString()
        {
            string s = "";
            for(MainNode i = head; i != null; i = i.Next)
            {
                s += $"{i.Data}: ";
                for(Node j = i.Down; j != null; j = j.Down)
                {
                    s += $"{j.Data}, ";
                }
                s += "\n";
            }
            return s;
        }

        public string this[int index1, int index2]
        {
            get
            {
                int c = 0;
                if (index1 >= 0 && index2 >= 0 && index1 < gerincCount)
                {
                    MainNode i;
                    if (index2 == 0)
                    {
                        for (i = head; i.Next != null && c < index1; i = i.Next, c++);
                        return i.Data;
                    }
                    for (i = head; i.Next != null && c < index1; i = i.Next, c++);
                    if(i.NodeCount < index2)
                    {
                        return null;
                    }
                    c = 1;
                    Node j;
                    for (j = i.Down; j.Down != null && c < index2; j = j.Down, c++) ;
                    return j.Data;

                }
                else
                {
                    return null;
                }
                
            }
            set
            {
                int c = 0;
                if (index1 >= 0 && index2 >= 0 && index1 < gerincCount)
                {
                    MainNode i;
                    if (index2 == 0)
                    {
                        for (i = head; i.Next != null && c < index1; i = i.Next, c++) ;
                        i.Data = value;
                    }
                    for (i = head; i.Next != null && c < index1; i = i.Next, c++);
                    if (i.NodeCount < index2)
                    {
                        return;
                    }
                    c = 1;
                    Node j;
                    for (j = i.Down; j.Down != null && c < index2; j = j.Down) ;
                    j.Data = value;
                }
            }
        }

    }
}
