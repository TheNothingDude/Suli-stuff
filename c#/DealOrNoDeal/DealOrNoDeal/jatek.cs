using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace _11C_All_Az_Alku
{
    static class Jatek
    {
        static string udvozlo = "Üdvözöllek as Áll Az Alkú játéban!" + Environment.NewLine +
                    "A játékban 23 táska vesz részt, amelyből most egyet ki kell majd választanod. " + Environment.NewLine +
                    "Ezt a táskát a játék végéig nem szabad kinyitni, csak majd akkor, ha elfogyott az összes többi nyitható táska" + Environment.NewLine +
                    "Minden körben bizonyos mennyiségű táskát lehet kinyitni, amelyek vagy csökkentik vagy növelik a megnyerhető összeget." + Environment.NewLine +
                    "Minden kör végén a bank tesz egy ajánlatot, amit vagy elfogadsz, vagy játszol tovább." + Environment.NewLine +
                    "Kérlek írd be a választott táska sorszámát (1-23)!";

        static string formatError = "Csakis egész számot írhatsz be!";
        static string rangeError = "Csakis 1-23 közötti számot írhatsz be!";
        static string nyitoSzoveg = "Nyiss ki egy zart taskat";
        static Random rand = new Random();
        static int[] nyitasok = new int[9] { 5, 3, 3, 3, 2, 2, 2, 1, 1 };
        static public int korok = 1;
        static public double[] ajanlatSzazalek = new double[9];

        private static int BemenetValidacio()
        {
            bool siker = false;

            while (!siker)
            {
                Console.WriteLine("Választott táska sorszáma: ");
                string s = Console.ReadLine();

                siker = int.TryParse(s, out int sorszam);

                if (siker == false)
                    Console.WriteLine(formatError);
                else if (sorszam < 1 || sorszam > 23)
                {
                    Console.WriteLine(rangeError);
                    siker = false;
                }
                if (siker == true)
                {
                    return sorszam;
                }
            }
            return -1;
        }
        public static int SajatTaskaValaszt()
        {
            bool siker = false;

            while (!siker)
            {
                Console.WriteLine("Választott táska sorszáma: ");
                string s = Console.ReadLine();

                siker = int.TryParse(s, out int sorszam);

                if (siker == false)
                    Console.WriteLine(formatError);
                else if (sorszam < 1 || sorszam > 23)
                {
                    Console.WriteLine(rangeError);
                    siker = false;
                }
                if (siker == true)
                {
                    return sorszam;
                }
            }
            return -1;
        }
        private static int BankAjanlat()
        {
            Taska[] taskak = Taskak.GetTaskak();
            int osszeg = 0;
            int db = 0;
            for (int i = 0; i < taskak.Length; i++)
                if (!taskak[i].Nyitva)
                {
                    osszeg += taskak[i].Osszeg();
                    db++;
                }

            double atlag = (double)osszeg / db;

            int rFaktor = rand.Next(-25000, 25000);

            return
               Math.Abs(((int)Math.Floor(atlag * ajanlatSzazalek[korok - 1])) + rFaktor);
        }
        private static void Nyitasok()
        {
            int count = nyitasok[korok-1];
            Console.WriteLine($"Ebben a korben osszesen {count} ladat kell nyitni");
            int sorszam = -1;
            for (int i = count; i > 0; i--)
            {
                while(sorszam == -1)
                {
                    Console.WriteLine(nyitoSzoveg);
                    sorszam = BemenetValidacio();
                    if (sorszam == Taska.JatekosTaska)
                    {
                        sorszam = -1;
                        Console.WriteLine("A sajat taskadat nem nyithatod ki");
                    }
                    else if(Taskak.NyitvaVanE(sorszam))
                    {
                        sorszam = -1;
                        Console.WriteLine("Ez mar nyitva van");
                    }
                }
                Console.Write($"Az altalad nyitott {sorszam}. taskaban ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(Taskak.MennyVanBenne(sorszam));
                Console.ForegroundColor= ConsoleColor.White;
                Console.WriteLine("forint volt");
                Thread.Sleep(1000);
                Taskak.UjraRajzol();
                sorszam = -1;
               
            }

        }
        public static void Jatekmenet()
        {
            Console.WriteLine(udvozlo + "\n");
            int sajat = SajatTaskaValaszt();


            Taska.JatekosTaskaBeallit(sajat);
            Console.Clear();
            Taskak.StartJatek();
            bool elfogadja = false;
            for (int i = 0; i < nyitasok.Length && !elfogadja; i++)
            {
                Nyitasok();
                int ajanlat = BankAjanlat();
                Console.WriteLine($"A bank ajanlata {korok}. kor utan {ajanlat} forint");
                Console.Write("elfogadod? (I/N)");
                string elfogad = Console.ReadLine().ToLower();
                if (string.Compare(elfogad, "i") == 0)
                {
                  Console.WriteLine($"A nyeremeded: {ajanlat} forint");
                  elfogadja = true;
                }
                korok++;
                    
            }
            Console.WriteLine($"Nyeremenyed {Taskak.MennyVanBenne(Taska.JatekosTaska)}");

        }
    }
}
