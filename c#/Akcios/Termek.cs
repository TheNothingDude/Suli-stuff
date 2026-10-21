namespace Akcios
{
    abstract class Termek
    {   
        string name;
        protected int egysegar;

        public Termek(string name, int egysegar)
        {
            this.name = name;
            this.egysegar = egysegar;
        }
        public abstract int MennyibeKerul();
        public override string ToString()
        {
            return $"{name} - {egysegar}";
        }
    }

}

