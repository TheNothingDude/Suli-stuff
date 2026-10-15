using System;

namespace ExceptionShii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] t = new int[5] { 1, 2, 3, 4, 5 };
            try
            {
                System.Console.WriteLine("which one do u want?");
                int i = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine(t[i]);
            }
            catch (IndexOutOfRangeException err)
            {
                System.Console.WriteLine("try a smaller num");
            }
            catch (FormatException err)
            {
                System.Console.WriteLine("try a number");
            }
            catch (Exception err)
            {
                System.Console.WriteLine(err.Message);
            }
            catch
            {
                System.Console.WriteLine("idk smth happened");
            }
            System.Console.WriteLine("veged van kishaver");
        }
    }
}