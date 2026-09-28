using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegyenOnIsMilliomos
{
    static class Game
    {
        static void Interface()
        {
            Console.WriteLine("Köszöntünk a Legyen Ön Is Milliomos játékban!");
            Console.WriteLine("A játék szintekre osztható, maximum 15 szint lehet. Minden szinten egy kérdésre kell válaszolnia. Minden kérdéshez\ntartozik négy válaszlehetőség (A, B, C, D). A négy válaszlehetőség közül minden esetben csak egy a helyes.");
            Console.WriteLine("Minden szintnek megfelelően négyzetesen fog pontot kapni.");
            Console.WriteLine();
        }

        public static void Gameplay()
        {
            Interface();
            Questions.ReadCvs();
            Random r = new Random();
            int pontszam = 0;
            bool end = false;
            for (int i = 1; i <= 15 && !end; i++)
            {
                question[] questions = Questions.qsorted[i];
                question currentQuestion = questions[r.Next(0, questions.Length)];
                Console.WriteLine(currentQuestion.question_string);
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine($"\tA - {currentQuestion.A_answear,-20} | \tB - {currentQuestion.B_answear, -20}");
                Console.WriteLine($"\tC - {currentQuestion.C_answear,-20} | \tD - {currentQuestion.D_answear, -20}");
                Console.WriteLine();


                Console.Write("Írja be a helyes válasz betűjelét: ");
                char valasz = char.Parse(Console.ReadLine().ToUpper());

                if(valasz == currentQuestion.correctAnswear)
                {
                    pontszam += i*i;
                    Console.WriteLine("Helyes a válasz!");
                }
                else
                {
                    Console.WriteLine($"Vége a játéknak\n Elért pontszám: {pontszam}");
                    end = true;
                }
            }

        }
    }
}
