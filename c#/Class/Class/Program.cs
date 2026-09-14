using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Kutya
    {
        string nev;
        int eletkor;
        bool ugatos;

        public Kutya(string nev,int eletkor, bool ugatos)
        {
           this.nev = nev;
           this.eletkor = eletkor;
           this.ugatos = ugatos;
        }

        public Kutya(Kutya copy)
        {
            this.nev = copy.nev;
            this.eletkor = copy.eletkor;
            this.ugatos = copy.ugatos;
        }


        public string getNev()
        {
            return this.nev;
        }
        public void setNev(string ujNev)
        {
            this.nev = ujNev;
        }

        public string Nev
        {
            get 
            {
                return this.nev;
            }
            set 
            {
                this.nev = value;            
            }
        }
        public string HarapE
        {
            get
            {
                return ugatos ? "Nem hapapos" : "Harapos";
            }
        }

        public string ToString()
        {
            return $"Nev {nev} | {eletkor} | {HarapE} ";
        }

           
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Kutya k1 = new Kutya("Foxi", 8, true);

            k1.setNev("Boksi");
            Console.WriteLine($"A kutya neve: {k1.getNev()}");
            k1.Nev = "Morzsi";

            Console.WriteLine($"{k1.Nev} {k1.HarapE.ToLower()}");
            Kutya dio = new Kutya("Dio", 10, false);
            //Kutya mak = dio;
            Kutya mak = new Kutya(dio);
            mak.Nev = "Mogyi";
            Console.WriteLine($"Dio kutya adatai: {dio.ToString()}");
            Console.WriteLine($"Mak kutya adatai: {mak.ToString()}");
        }
    }
}
