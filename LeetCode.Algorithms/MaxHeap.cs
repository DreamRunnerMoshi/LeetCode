namespace Algorithms
{
    public class MaxHeap
    {
        int[] arr;
        int count;
        int size;

        public int GetLeftChild(int pos)
        {
            int l = 2 * pos + 1;
            return l >= count ? -1 : l;
        }

        public int GetRightChild(int pos)
        {
            int r = 2 * pos + 2;
            return r >= count ? -1 : r;
        }

        public void Heapify(int[] num, int n)
        {
            arr = new int[n];
            size = n;
            for (int i = 0; i < n; i++)
                arr[i] = num[i];
            count = n;

            for (int i = (count - 1) / 2; i >= 0; i--)
            {
                PercolateDown(i);
            }
        }
        public void PercolateDown(int pos)
        {
            int l = GetLeftChild(pos);
            int r = GetRightChild(pos);
            int max = pos;
            if (l != -1 && arr[max] < arr[l])
                max = l;
            if (r != -1 && arr[max] < arr[r])
                max = r;
            if (max != pos)
            {
                int temp = arr[pos];
                arr[pos] = arr[max];
                arr[max] = temp;
                PercolateDown(max);
            }
        }
        public int RemoveMax()
        {
            int data = arr[0];
            arr[0] = arr[count - 1];
            count--;
            PercolateDown(0);
            return data;
        }
    }
}
