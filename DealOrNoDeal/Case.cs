using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealOrNoDeal
{
    class Case
    {
        int id;
        int value;
        bool opened;
        bool users;

        public int Id { get { return id; } }
        public int Value { get { return value; } set { this.value = value; }  }
        public bool Users { get { return users; } }
        public Case(int id, int value)
        {
            this.id = id;
            this.value = value;
        }

        public int Open()
        {
            opened = true;
            return value;
        }

    }
}
