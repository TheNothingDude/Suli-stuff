namespace Akcios;

class RohatdParadicsom : Termek , IAkciozhato
{
    double tomeg;
    public RohatdParadicsom(double tomeg, int ar) : base("rohatd paradicsom", ar)
    {
        this.tomeg = tomeg;
    }
    public override int MennyibeKerul()
    {
        return (int)(tomeg*egysegar);
    }
    public int akciosAr()
    {
        return (int)(egysegar*0.8);
    }
    public override string ToString()
    {
        return $"{tomeg} kg {base.ToString()}";
    }
}
