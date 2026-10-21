using System;
using System.IO;

namespace Akcios;

class Vegyesbolt
{
    static List<Termek> termekek = new List<Termek>();
    public static void Bevesarlok(string path)
    {
        FileStream fs = new FileStream(path, FileMode.Open);
        StreamReader sr = new StreamReader(fs);
        string line; 
        while ((line = sr.ReadLine()) != null)
        {
            string[] parts = line.Split(';');
            switch (parts[0])
            {
                case "salata":
                    termekek.Add(new Salata(int.Parse(parts[2]), int.Parse(parts[1])));
                    break;
                case "paradicsom":
                    termekek.Add(new RohatdParadicsom(double.Parse(parts[2]), int.Parse(parts[1])));
                    break;
            }

        }
        sr.Close();
        fs.Close();
    }
    public static void MiVanAKosaramban()
    {
        FileStream fs = new FileStream("kosar.txt", FileMode.Create);
        StreamWriter sw = new StreamWriter(fs);
        foreach (Termek termek in termekek)
        {
            if (termek is IAkciozhato)
            {
                sw.Write(termek.ToString() + " ");
                sw.WriteLine((termek as IAkciozhato).akciosAr());
            }
            else
            {
                sw.WriteLine(termek.ToString());
            }
        }
        sw.Close();
        fs.Close();
    }
}
