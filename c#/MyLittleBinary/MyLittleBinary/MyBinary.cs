using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLittleBinary
{
    class MyBinary
    {
        long biNum;
        public long BiNum
        {
            get { return biNum; }
            set 
            { 
                string s = value.ToString();
                for(int i = 0; i < s.Length; i++)
                {
                    if(s[i] != '0')
                    {
                        s.Remove(i,1);
                        s.Insert(i, "1");
                    }
                }
                biNum = long.Parse(s);
            }
        }
        public MyBinary()
        {
            BiNum = 0;
        }
        public MyBinary(long biNum)
        {
            BiNum = biNum;
        }
        public MyBinary(MyBinary other)
        {
            this.biNum = other.biNum;
        }
        private static void BitSum(bool a, bool b, ref bool cin, ref bool s)
        {
            s = a^b^cin;
            cin = a && b || cin && (a || b);
        }
        public static MyBinary operator+(MyBinary a, MyBinary b)
        {
            string aStr = a.ToString();
            string bStr = b.ToString();
            if (aStr.Length < bStr.Length)
            {
                aStr = aStr.PadLeft(bStr.Length, '0');
            }
            else
            {
                bStr = bStr.PadLeft(aStr.Length, '0');
            }
            bool c  = false;
            bool s = false;
            string sum = "";
            for(int i =  aStr.Length - 1; i >= 0; i--)
            {
                bool aBit = aStr[i] == '1';
                bool bBit = aStr[i] == '1';
                BitSum(aBit, bBit, ref c, ref s);
                
                sum = (s?"1":"0") + sum;
            }

            if (c)
                sum = "1" + sum;

            long NewBin = long.Parse(sum);
            return new MyBinary(NewBin);
        }

        public string ToString()
        {
            return biNum.ToString();
        }

        public int Decimal()
        {
            string s = biNum.ToString();
            int i = s.Length-1;
            int sum = 0;
            int j = 0;  
            while (i >= 0)
            {
                int bit = s[j] == '1' ? 1 : 0;
                sum += bit * (int)Math.Pow(2, i);
                i--;
                j++;
            }
            return sum;
        }
        public static MyBinary operator<<(MyBinary b, int count)
        { 
            MyBinary newB = new MyBinary(b);
            for(int i = 0; i < count; i++)
            {
                b.biNum *= 10;
            }
            return newB;
        }
    }
}
