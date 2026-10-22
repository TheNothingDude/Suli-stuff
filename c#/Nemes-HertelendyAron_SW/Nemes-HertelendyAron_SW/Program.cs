using System;

namespace Nemes_HertelendyAron_SW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                AnakinSkywalker anakin = new AnakinSkywalker();
                Uralkodo uralkodo = new Uralkodo();
                Console.WriteLine("anakin le tudja-e gyozni az uralkodot " + anakin.LegyoziE(uralkodo));
                anakin.EngeddElAHaragod();
                Console.WriteLine($"anakin haragoss ezek utan, ereje: {anakin.Ero}");
                Console.WriteLine($"anakin megterempti az egyensuly?: {anakin.MegteremtiAzEgyensulyt()}");
                anakin.Ero = 1100;
                Console.WriteLine($"Anakin atall a sotet oldalra es nagy erore tesz szert: ereje {anakin.MekkoraAzEreje()}");
                Console.WriteLine($"igy mar kepes egyensuly terempteni?: {anakin.MegteremtiAzEgyensulyt()}");
                uralkodo.EngeddElAHaragod();
                Console.WriteLine($"Az uralkodo megess lesz: ereje {uralkodo.MekkoraAzEreje()}");
                Console.WriteLine($"kepes igy anakin gyozni? {anakin.LegyoziE(uralkodo)}");
                anakin.EngeddElAHaragod();
                Console.WriteLine($"vegleses {anakin}");
                //catch error
                anakin.Ero = -5;
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}