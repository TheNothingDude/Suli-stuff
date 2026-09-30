namespace Resturant;

class Drink : BaseOrder
{
    private int dl;
    public Drink(string name, int dl, int price) : base(price,name)
    {
        this.dl = dl;
    }
        
    public override int OrderShow()
    {
        return Order();
    }
    protected override int Order()
    {
        return price * dl;
    }
}