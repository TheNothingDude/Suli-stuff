using System.Security.Cryptography.X509Certificates;
namespace feladat
{

    internal class Program
    {    
        struct Pont
        {
            public double x;
            public double y;
        }
        struct Polar
        {
            public double fi;
            public double r;
        }
        static double PontTav(Pont p)
        {   
            double tav = Math.Sqrt((Math.Pow(p.x, 2) + Math.Pow(p.y, 2)));
            return tav;
        }
        static double KetPont(Pont pa, Pont pb)
        {
            return Math.Sqrt(Math.Pow(pb.x-pa.x, 2)+Math.Pow(pb.y-pa.y, 2));
        }
        static bool Egysegkor(Pont a)
        {
            if(PontTav(a) >= 1)
            {
                return false;
            }
            return true;
        }
        static Polar PolarPont(Pont a)
        {
            Polar p;
            p.r = PontTav(a);
            p.fi = Math.Atan(a.y/a.x)* (180 / Math.PI);
            return p;
        }
        static Pont Decartes(Polar a)
        {
            Pont p;
            p.y = Math.Sin(a.fi *(Math.PI/180))*a.r;
            p.x = Math.Cos(a.fi * (Math.PI/180))*a.r;
            return p;
        }
        static int Kord(Pont a)
        {
            Polar Pa = PolarPont(a);
            double deg = Pa.fi;
            int c=0;    
            if (deg<0)
            {
                deg = 360+deg;
            }
            if(deg %90==0)
            {
                return 0;
            }
            for(int i=0; i <= deg; i++)
            {
                if(i%90==0)
                {
                   c+=1; 
                }
            }
            return c;
        }
        static bool ArrayKor(Pont[] pontok)
        {
            foreach(Pont p in pontok)
            {
                if(PontTav(p)<1)
                {
                    return true;
                }
            }
            return false;
        }

        static Pont max(Pont[] pontok)
        {
            Pont max = pontok[0];
            foreach(Pont p in pontok)
            {
                if(PontTav(p) > PontTav(max))
                {
                    max = p;
                }
            }
            return max;
        }
        static Pont min(Pont[] pontok)
        {
            Pont min = pontok[0];
            foreach(Pont p in pontok)
            {
                if(PontTav(p) < PontTav(min))
                {
                    min = p;
                }
            }
            return min;
        }
        static int Derek(Pont[] a)
        {
            Polar p = PolarPont(); 
        }
    static void Main(string[] args)
        {
            Pont p1;
            p1.x = -5;
            p1.y = 2;
            System.Console.WriteLine($"A p1 pont táva: { Math.Round(PontTav(p1))}");
            Pont p2;
            p2.x = 0;
            p2.y = 2;
            System.Console.WriteLine($"A p1 és p2 pont távolsága: {Math.Round(KetPont(p1,p2), 2)}");
            System.Console.WriteLine(Egysegkor(p1));
            Polar p;
            p.fi = 60;
            p.r = 5;

            System.Console.WriteLine($"x:{Math.Round(Decartes(p).x,2)}, y:{Math.Round(Decartes(p).y,2)}");
            System.Console.WriteLine(Kord(p1));
            System.Console.WriteLine(PolarPont(p1).fi);




            Pont[] pontok = new Pont[12];
            Random rnd = new Random();
            for(int i =0; i< pontok.Length; i++)
            {
                Pont b;
                b.x = rnd.Next(-100,100)/10;
                b.y = rnd.Next(-100,100)/10;
                pontok[i] = b;
            }





        }
    }
}
