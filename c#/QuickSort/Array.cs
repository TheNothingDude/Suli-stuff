using System.Runtime.InteropServices;

namespace QuickSort;

class Array
{
    static Random r = new Random();
    private int[] array;

    public Array(int N)
    {
        array = new int[N];
        for (int i = 0; i < N; i++)
        {
            array[i] = r.Next(-100, 100);
        }
    }

    public Array(Array other)
    {
        this.array = new int[other.array.Length];
        for (int i = 0; i < other.array.Length; i++)
        {
            this.array[i] = other.array[i];
        }
    }

    public void QuickSort()
    {
        QuickSort(0, array.Length - 1);
    }
    public void BubbleSort()
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[i])
                {
                    int tmp = array[j];
                    array[j] = array[i];
                    array[i] = tmp;
                }
            }
        }
    }
    private void QuickSort(int left, int right)
    {
        int pivot = array[left];
        int lHold = left;
        int rHold = right;

        while (left < right)
        {
            while (array[right] >= pivot && left < right) --right;
            if (left != right)
            {
                array[left] = array[right];
                ++left;
            }

            while (array[left] <= pivot && left < right) ++left;
            if (left != right)
            {
                array[right] = array[left];
                right--;
            }
        }

        array[left] = pivot;
        pivot = left; //pivot == index
        left = lHold;
        right = rHold;

        if (left < pivot)
        {
            QuickSort(left, pivot - 1);
        }
        if (right > pivot)
        {
            QuickSort(pivot + 1, right);
        }
    }
    public override string ToString()
    {
        string s = String.Empty;
        foreach (int i in array)
        {
            s += i.ToString() + ", ";
        }
        return s;
    }
}
