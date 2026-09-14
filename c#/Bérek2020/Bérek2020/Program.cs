using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bérek2020
{
    internal class Program
    {
        struct Dolgozo
        {
            public string nev;
            public string nem;
            public string reszleg;
            public int belepes;
            public int ber;
        }
        static void Add(ref Dolgozo[] t, Dolgozo item)
        {
            Dolgozo[] tmp = new Dolgozo[t.Length+1];
            for(int i = 0; i < t.Length; i++)
            {
                tmp[i] = t[i];
            }
            tmp[t.Length] = item;
            t = tmp;
        }
        static void Add(ref string[] t, string item)
        {
            string[] tmp = new string[t.Length + 1];
            for (int i = 0; i < t.Length; i++)
            {
                tmp[i] = t[i];
            }
            tmp[t.Length] = item;
            t = tmp;
        }
        static Dolgozo[] Store()
        {
            Dolgozo[] r = new Dolgozo[0];
            FileStream fs = new FileStream("berek2020.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string line;
            string[] data;
            sr.ReadLine();
            while((line = sr.ReadLine()) != null)
            {
                data = line.Split(';');
                Dolgozo d = new Dolgozo();
                d.nev = data[0];
                d.nem = data[1];
                d.reszleg = data[2];
                d.belepes = int.Parse(data[3]);
                d.ber = int.Parse(data[4]);
                Add(ref r, d);
            }

            
            sr.Close();
            fs.Close();
            return r;
        }   

        static double AtlagBer(Dolgozo[] t)
        {
            int sum = 0;
            foreach(Dolgozo d in t)
            {
                sum += d.ber;
            }
            return Math.Round(((sum) / (double)t.Length)/1000, 1);
        }
        static Dolgozo? MaxReszleg(Dolgozo[] t, string reszleg)
        {
            int max = t[0].ber;
            Dolgozo r = new Dolgozo();
            string[] reszlegek = GetReszlegek(t);
            if(reszlegek.Contains(reszleg))
            {
                foreach (Dolgozo d in t)
                {
                    if (d.reszleg == reszleg && d.ber > max)
                    {
                        max = d.ber;
                        r = d;
                    }
                }
                return r;
            }
            else
            {
                return null;
            } 
        }
        static int ReszlegNum(Dolgozo[] t, string reszleg)
        {
            int c = 0;
            foreach (Dolgozo d in t)
            {
                if (d.reszleg == reszleg)
                {
                    c++;
                }
            }
            return c;
        }
        static string[] GetReszlegek(Dolgozo[] t)
        {
            string[] r = new string[0];
            foreach (Dolgozo d in t)
            {
                if(!r.Contains(d.reszleg))
                {
                    Add(ref r, d.reszleg);
                }
            }
            return r;
        }
        
        static void Main(string[] args)
        {
            Dolgozo[] dolgozok = Store();
            string user_inp;
            Console.WriteLine($"3. feladat: {dolgozok.Length} fő");
            Console.WriteLine($"4. feladat: {AtlagBer(dolgozok)} ezer forint");
            Console.Write("5. feladat: Kérem egy részleg nevét: ");
            user_inp = Console.ReadLine();
            if(MaxReszleg(dolgozok, user_inp) == null)
            {
                Console.WriteLine("6. feladat: A megadott részleg nem létezik a cégnél");
            }
            else
            {
                Dolgozo maxDolgozo = (Dolgozo)MaxReszleg(dolgozok, user_inp);
                Console.WriteLine($"6. feladat: A legtöbbet kereső dolgozó a részlegen: \n neve: {maxDolgozo.nev} \n neme: {maxDolgozo.nem} \n belépés: {maxDolgozo.belepes} \n bér: {maxDolgozo.ber}");
            }
            string[] reszlegek = GetReszlegek(dolgozok);
            Console.WriteLine("7.feladat: Statisztika: ");
            foreach(string s in reszlegek)
            {
                Console.WriteLine($"\t{s}: {ReszlegNum(dolgozok, s)} fő ");
            }
        }
    }
}
