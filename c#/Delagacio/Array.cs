namespace Delagacio;

class Array
{
    static Random rnd = new Random();
    public delegate void Transformer(ref int item);

    private int[] data;
    public int Length => data.Length;

    public int this[int index]
    {
        get => data[index];
    }
    public Array(int size)
    {
        data = new int[size];
        for (int i = 0; i < size; i++)
        {
            data[i] = rnd.Next(1, 100);
        }
    }
    public void Transform(Transformer T)
    {
        for (int i = 0; i < data.Length; i++)
        {
            T(ref data[i]);
        }
    }
}
