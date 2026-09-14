using System;
using System.Linq;
using System.IO;

namespace Influencer
{
    internal class Program
    {
        static void Betesz(ref int[] t, int ujElem) // elem betétele int listába
        {
            int[] tmp = new int[t.Length + 1];
            for (int i = 0; i < t.Length; i++)
                tmp[i] = t[i];
            tmp[t.Length] = ujElem;
            t = tmp;
        }
        static void Betesz(ref string[] t, string ujElem) // elem betétele string listába
        {
            string[] tmp = new string[t.Length + 1];
            for (int i = 0; i < t.Length; i++)
                tmp[i] = t[i];
            tmp[t.Length] = ujElem;
            t = tmp;
        }

        static int Kivesz(ref int[] t) // elem kivétele int listából
        {
            int vissza = t[0];
            int[] tmp = new int[t.Length - 1];
            for (int i = 1; i < t.Length; i++)
                tmp[i - 1] = t[i];

            t = tmp;

            return vissza;
        }


        static int[] BFS(int[,] matrix, int kezdopont) // szélességi bejárás
        {
            int csucsok = matrix.GetLength(0);
            int[] sor = new int[0];
            int[] tav = new int[csucsok];
            for (int i = 0; i < tav.Length; i++)
                tav[i] = -1;
            tav[kezdopont] = 0;
            Betesz(ref sor, kezdopont);

            while (sor.Length > 0)
            {
                int kivettElem = Kivesz(ref sor);
                for (int szomszed = 0; szomszed < csucsok; szomszed++)
                {
                    if (matrix[kivettElem, szomszed] == 1 && tav[szomszed] == -1)
                    {
                        Betesz(ref sor, szomszed);
                        tav[szomszed] = tav[kivettElem] + 1;
                    }
                }
            }
            return tav;
        }
        static string[] GetNames() // nevek listába szedése
        {
            FileStream fs1 = new FileStream("halozat.txt", FileMode.Open);
            StreamReader sr1 = new StreamReader(fs1);
            string line = sr1.ReadLine();
            string[] data = line.Split(' ');
            string[] names = new string[0];
            while ((line = sr1.ReadLine()) != null)
            {
                data = line.Split(' ');
                foreach (string i in data)
                {
                    if (!names.Contains(i))
                    {
                        Betesz(ref names, i);
                    }
                }
            }
            sr1.Close();
            fs1.Close();
            return names;
        }
        static int[,] CreateMatrix(int length) // int mátrix létrehozása
        {
            FileStream fs = new FileStream("halozat.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            string[] data = line.Split(' ');
            int[,] r = new int[length, length];
            while ((line = sr.ReadLine()) != null)
            {
                data = line.Split(' ');
                r[data[0][0]-'A',data[1][0]-'A'] = r[data[1][0] - 'A', data[0][0] - 'A'] = 1;
            }
            sr.Close();
            fs.Close();
            return r;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a kezdőpont nevét: ");
            string kezdoPontNev = Console.ReadLine(); // felhasználó által megadott név
            int kezdoPont = kezdoPontNev[0] - 'A'; // megadott név int értéke
            string[] names = GetNames(); // összes név listája
            int[,] m = CreateMatrix(names.Length); // nevek közti kapcsolatokat tartalmazó szomszédossági mátrix
            int[] tavok = BFS(m, kezdoPont); // kezdőponttól megadott távolságok listája

            // A names és a tavok lista indexelése összefüggő, tehát az első helyen állo névhez az első helyen álló táv tartozik

            // távolságok és annak megfelelően a nevek rendezése növekvő sorrendbe
            for (int i = 0; i < tavok.Length - 1; i++)
            {
                for (int j = i + 1; j < tavok.Length; j++)
                {
                    if (tavok[i] > tavok[j])
                    {
                        tavok[i] ^= tavok[j];
                        tavok[j] ^= tavok[i];
                        tavok[i] ^= tavok[j];
                        string temp;
                        temp = names[j];
                        names[j] = names[i];
                        names[i] = temp;

                    }
                }
            }
            // végső kiírás
            Console.WriteLine($"Név\tTávolság tőle: {kezdoPontNev}");
            for (int i = 0; i < tavok.Length; i++)
                Console.WriteLine($"{names[i]}\t{tavok[i]}");
        }
    }
}
