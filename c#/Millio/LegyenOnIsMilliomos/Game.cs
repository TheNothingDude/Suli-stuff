using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegyenOnIsMilliomos
{
    static class Game
    {
        static void Interface()
        {
            System.Console.WriteLine("Köszöntünk a Legyen Ön Is Milliomos játékban!");
            Console.WriteLine();
            TypeLine("A játék szintekre osztható, maximum 15 szint lehet. Minden szinten egy kérdésre kell válaszolnia.\nMinden kérdéshez tartozik négy válaszlehetőség (A, B, C, D). A négy válaszlehetőség közül minden esetben csak egy a helyes.");
            System.Console.WriteLine("Minden szintnek megfelelően négyzetesen fog pontot kapni.");
            Console.WriteLine();
            Console.WriteLine("A továbbhaladáshoz nyomjon entert!");
            Console.ReadLine();
        }
        public static void Type(string p_input)
        {
            char[] letters = p_input.ToCharArray();
            foreach (char c in letters)
            {
                Console.Write(c);
                if(c != ' ')
                {
                    Thread.Sleep(5);
                }
            }
        }
        public static void TypeLine(string p_input)
        {
            char[] letters = p_input.ToCharArray();
            foreach (char c in letters)
            {
                Console.Write(c);
                if(c != ' ')
                {
                    Thread.Sleep(5);
                }
            }
            Console.WriteLine();
        }
        private static void DisplayQuestions(question currentQuestion)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Type($"Nehézségi szint: {currentQuestion.difficulty}\n");
            Console.ForegroundColor = ConsoleColor.White;
            Type(currentQuestion.question_string);
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------------");
            TypeLine($"|\tA - {currentQuestion.A_answear,-20}\t|\tB - {currentQuestion.B_answear}");
            System.Console.WriteLine("-----------------------------------------------------------------------------------");
            TypeLine($"|\tC - {currentQuestion.C_answear,-20}\t|\tD - {currentQuestion.D_answear}");
            System.Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine();
        }
        private static void DisplayAnswers(question currentQuestion)
        {
            Console.Clear();
            string[] answers = new string[] { currentQuestion.A_answear, currentQuestion.B_answear, currentQuestion.C_answear, currentQuestion.D_answear };
            int currectAnsIndex = (int)currentQuestion.correctAnswear - 65;


            Console.WriteLine("-----------------------------------------------------------------------------------");
            for (int i = 0; i < answers.Length; i++)
            {
                if (i == currectAnsIndex)
                {
                    Console.Write("|");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"\t{((char)(i + 97)).ToString().ToUpper()} - {answers[i],-20}\t");
                }
                else
                {
                    Console.Write("|");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"\t{((char)(i + 97)).ToString().ToUpper()} - {answers[i],-20}\t");
                }
                if (i == 1)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("-----------------------------------------------------------------------------------");
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------------");
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
                question[] questions = Questions.qsorted[i-1];
                question currentQuestion = questions[r.Next(0, questions.Length)];
                DisplayQuestions(currentQuestion);
                Console.Write("Írja be a helyes válasz betűjelét: ");
                char valasz = char.Parse(Console.ReadLine().ToUpper());
                if(char.IsDigit(valasz))
                {
                    System.Console.WriteLine("Szamok nem megengedettek");
                    return;
                }
                DisplayAnswers(currentQuestion);
                if (valasz == currentQuestion.correctAnswear)
                {
                    pontszam += i * i;
                    Console.Write($"Helyes a válasz!\nElért pontszám: ");
                    Console.WriteLine($"{pontszam}", Console.ForegroundColor = ConsoleColor.Yellow);

                }
                else
                {
                    Console.Write($"Vége a játéknak\nElért pontszám: ");
                    Console.WriteLine($"{pontszam}", Console.ForegroundColor = ConsoleColor.Yellow);
                    Console.ForegroundColor = ConsoleColor.White;
                    end = true;
                }
                Thread.Sleep(2000);
            }

        }
    }
}