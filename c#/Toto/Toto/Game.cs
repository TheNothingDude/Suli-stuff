using System;
using Spectre.Console;
using Spectre.Console.Rendering;
namespace Toto
{
    static class Game
    {
        static FigletText Figlet = new FigletText("Totó").Centered();
        static Random rnd = new Random();
        static Text introText = new Text("Üdvözöljük a Totó játékban \n A játék szabályai nagyon egyszerűek. 13 kérdést kell megvalaszolnia, mind a 13-ra van A, B, vagy X opció. Minden kerdesre egy helyes valasz van.").Centered();

        static char GetInput()
        {
            string str_inp = Console.ReadLine().ToLower();
            string[] answers = new string[3] { "a", "b", "x", };
            if (str_inp == string.Empty || !answers.Contains(str_inp))
            {
                throw new Exception("A megadható opciók A / B / X");
            }
            return char.Parse(str_inp);
        }
        static public void StartGame()
        {
            Data.ReadCsv("toto.csv");
            AnsiConsole.Write(Figlet);
            AnsiConsole.Write(introText);
            Console.ReadKey();
            int correct = 0;
            for (int i = 0;  i < 13; i++)
            {
                Console.Clear();
                char userInput = ' ';
                bool wronginput = true;
                Question currentQ = Data.qlist[rnd.Next(Data.qlist.Count)];
                Data.qlist.Remove(currentQ);
                Console.WriteLine($"{i+1}. {currentQ.QuestionString}");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"A: {currentQ.A_ans} \t B: {currentQ.B_ans} \t X: {currentQ.X_ans}");
                while (wronginput)
                {
                    try
                    {
                        Console.Write("Melyiket valasztja (A/B/C): ");
                        userInput = GetInput();
                        wronginput = false;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        wronginput = true;
                    }
                }
                if (userInput == currentQ.Correct)
                {
                    correct++;
                }
        
            }
            Console.WriteLine();
            Console.Write($"{correct}/ 13 helyes válasz");
            Console.Write($"  {Math.Round((correct) / 13.0 * 100, 2)}%");

        }
    }
}
