namespace Resturant;

abstract class BaseOrder
{
    protected int price;
    protected string name;

    public BaseOrder(int price, string name)
    {
        this.price = price;
        this.name = name;
    }
    public abstract int OrderShow();
    protected abstract int Order();
}