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
    public void HeapSort()
    {
        int n = array.Length;
        for (int i = (n / 2) - 1; i >= 0; i--)
            Heapify(n, i);
        for (int i = n - 1; i > 0; i--)
        {
            int tmp = array[i];
            array[i] = array[0];
            array[0] = tmp;
            Heapify(i, 0);
        }

    }
    private void Heapify(int n, int i)
    {
        int left = 2 * i + 1;
        int right = 2 * i + 2;
        int max_index = i;

        if (left < n && array[left] > array[max_index])
            max_index = left;
        if (right < n && array[right] > array[max_index])
        {
            max_index = right;
        }
        if (max_index != i)
        {
            int tmp = array[i];
            array[i] = array[max_index];
            array[max_index] = tmp;
            Heapify(n, max_index);
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
