using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;

class Program
{
    static Random r = new Random();
    const int keretX = 3;
    const int keretY = 1;
    const int keretW = 50;
    const int keretH = 20;

    /// <summary>
    /// Kirajzolja a játéktér keretét
    /// </summary>
    public static void KeretRajzol()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.SetCursorPosition(keretX, keretY);
        Console.Write("╔");
        for (int x = keretX+1; x < keretW+keretX; x++)
            Console.Write("═");
        Console.Write("╗");

        for(int y=keretY+1; y < keretH+keretY; y++)
        {
            Console.SetCursorPosition(keretX, y);
            Console.Write("║");
            Console.SetCursorPosition(keretW+keretX, y);
            Console.Write("║");
        }

        Console.SetCursorPosition(keretX, keretY + keretH);
        Console.Write("╚");

        for(int x=keretX+1; x < keretW+keretX; x++)
            Console.Write("═");

        Console.Write("╝");
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    /// <summary>
    /// Véletlenszerűen generál egy felvehető ételt a játéktéren
    /// </summary>
    /// <param name="etelX">Étel X koordinátája</param>
    /// <param name="etelY">Étel Y koordinátája</param>
    public static void EtelGeneral(ref int etelX, ref int etelY, ConsoleColor fgcolor)
    {
        etelX = r.Next(keretX+1, keretW+keretX);
        etelY = r.Next(keretY+1, keretH+keretY);
        Console.SetCursorPosition(etelX, etelY);
        Console.ForegroundColor = fgcolor;
        Console.Write("X");
        Console.ForegroundColor = ConsoleColor.White;
    }

    /// <summary>
    /// Megjeleníti a játékos pontszámát
    /// </summary>
    /// <param name="pontszam"></param>
    public static void EredmenyMegjelenit(int pontszam)
    {
        Console.SetCursorPosition(keretW+keretX+3, keretY+1);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"Pontszámod: {pontszam}");
        Console.ForegroundColor = ConsoleColor.White;
    }

    /// <summary>
    /// A nyilak segítségével a karakter mozgatását valósítja meg
    /// </summary>
    /// <param name="x">A karakter X koordinátája</param>
    /// <param name="y">A karakter Y koordinátája</param>
    /// <param name="jatek">true, ha folytatódjon a játék</param>
    public static void Iranyit(ref int x, ref int y, ref bool jatek)
    {
        ConsoleKeyInfo key = Console.ReadKey(true);
        Console.SetCursorPosition(x,y);
        Console.Write(" ");
        switch(key.Key)
        {
            case ConsoleKey.UpArrow:
                if(y>keretY+1) 
                    y--;
                break;
            case ConsoleKey.DownArrow:
                if(y<keretH+keretY-1)
                    y++;
                break;
            case ConsoleKey.LeftArrow:
                if(x> keretX+1)
                {
                    x--;
                }
                break;
            case ConsoleKey.RightArrow:
                if(x < keretW+keretX-1)
                {
                    x++;
                }
                break;
            case ConsoleKey.Escape:
                jatek = false;
                break;
        }
        Console.SetCursorPosition(x,y);
        Console.Write("O");
    }
        

    public static void Main()
    {
        Console.Clear();
        Console.CursorVisible = false;
        Console.SetWindowSize(80, 40);    
        
        KeretRajzol();       

        int pontszam = 0;
        int x = 26;     // A karakterünk X koordinájáta
        int y = 11;     // A karakterünk Y koordinájáta
        int etelX = 0;  // Az étel X koordinátája
        int etelY = 0;  // Az étel Y koordinátája
        int bonuszX = 0;
        int bonuszY = 0;
        bool jatek = true;      // Amíg true, addig fut a játék (ciklus)

        EtelGeneral(ref etelX, ref etelY, ConsoleColor.Red);
        EredmenyMegjelenit(pontszam);
        int i = 0;
        while(jatek)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("O");

            // Figyeljük, hogy van-e billentyű leütés
            if (Console.KeyAvailable)
            {
                // A billentyűnek megfelelően változtatjuk a karakterünk pozícióját
                Iranyit(ref x, ref y, ref jatek);                

                // Ha a karakterünk elkapja az ételt...                
                if(x == etelX && y == etelY)
                {
                    pontszam++;
                    EtelGeneral(ref etelX, ref etelY, ConsoleColor.Red);
                    EredmenyMegjelenit(pontszam);
                }

                if(i % 75 == 0)
                {
                    Console.SetCursorPosition(bonuszX, bonuszY);
                    Console.Write(" ");
                    bonuszX = bonuszY = 0;
                }
                else if(i % 50 ==0)
                {
                    EtelGeneral(ref bonuszX, ref bonuszY, ConsoleColor.Yellow);
                }
                
                if(x == bonuszX && y == bonuszY)
                {
                    pontszam +=3;
                    bonuszX = bonuszY = 0;
                    EredmenyMegjelenit(pontszam);
                }
                Thread.Sleep(25);
                i++;
            }           
        }
    }
}