using System;

namespace SouthPark
{
    interface IMedve { void Eszik(); }
    interface IDiszno { void Eszik(); }
    interface IEmber { void Eszik(); }
    
    class MedveDisznoEmber : IMedve, IDiszno, IEmber
    {
        public void Eszik()
        {
            Console.WriteLine("MedveDisznoEmber eszik");
        }
        void IMedve.Eszik()
        {
            Console.WriteLine("Csak a medve eszik");
        }
    } 
    internal class Program
    {
        static void Main(string[] args)
        {
            MedveDisznoEmber mde = new MedveDisznoEmber();
            mde.Eszik();

            IMedve m = new MedveDisznoEmber();
            m.Eszik();
        }
    }
}