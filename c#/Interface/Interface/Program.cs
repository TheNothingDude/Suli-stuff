using System;

namespace Interface
{
    public interface IPaymentMethod
    {
        bool PaymentProccessing(int osszeg);
    }
    public class CardPayment : IPaymentMethod
    {
        public string Kartyaszam {  get; set; }
        public CardPayment(string kartyaszam)
        {
            Kartyaszam = kartyaszam;
        }
        public bool PaymentProccessing(int osszeg)
        {
            Console.WriteLine();
            return true;
        }

    }
    public class Utanvet : IPaymentMethod
    {
        public string Lakcim { get; set; }
        public Utanvet(string lakcim)
        {
            Lakcim = lakcim;
        }
        public bool PaymentProccessing(int osszeg)
        {
            Console.WriteLine($"{osszeg} osszegu megrendeles a {Lakcim} cimre szallitva");            
            return true;
        }
    }
    public class Utalasos
    {
        public string Szamlaszam {  get; set; }
        public bool Pay(int osszeg)
        {
            Console.WriteLine($"Megtortent az utalas a szamla szamra {Szamlaszam}");
            return true;
        }
    }
    public class Cart
    {
        public int Vegosszeg { get; set; }
        public void StartPayment(IPaymentMethod paymentMethod)
        {
            Console.WriteLine("folyamatban");
            bool works = paymentMethod.PaymentProccessing(Vegosszeg);
            if (works)
            {
                Console.WriteLine("Sikeres fizetes");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart();
            cart.Vegosszeg = 10000;
            IPaymentMethod paymentMethod = new CardPayment("1293213101-15133");

            Utalasos utalasos = new Utalasos();
            utalasos.Szamlaszam = "121314121515";


        }
    }
}