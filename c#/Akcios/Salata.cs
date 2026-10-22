using System;

namespace Akcios
{
    class Salata : Termek
    {
        int db;
        public Salata(int db, int ar) : base("salata", ar)
        {
            this.db = db;
        }

        public override int MennyibeKerul()
        {
            return db*egysegar;
        }
        public override string ToString()
        {
            return $"{db} {base.ToString()}";
        }

    }
}


