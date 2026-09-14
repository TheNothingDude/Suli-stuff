using System;
using System.Collections.Generic;

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

        public static void Jatekmenet()
        {
            Console.WriteLine(udvozlo + "\n");
            int sajat = SajatTaskaValaszt();


            Taska.JatekosTaskaBeallit(sajat);
            Console.Clear();
            Taskak.StartJatek();
        }
    }
}
