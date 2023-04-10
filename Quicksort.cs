using System;
namespace quicksort
{
	public static class Quicksort
	{
        static void Swap<T>(T[] arr, int i, int j)
        {
            T temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }


        static int Partition<T>(T[] arr, int l, int r) where T : IComparable
        {
            T v = arr[(l + r) / 2];
            int i = l, j = r;
            lock(arr)
            {
                while (i <= j)
                {
                    while (arr[i].CompareTo(v) < 0) i++;
                    while (arr[j].CompareTo(v) > 0) j--;
                    if (i >= j) break;
                    Swap(arr, i++, j--);
                }
            }
            return j;
        }


        public static void Sort<T>(T[] arr, int l, int r) where T : IComparable
        {
            if (l < r)
            {
                int q = Partition<T>(arr, l, r);
                Sort<T>(arr, l, q);
                Sort<T>(arr, q + 1, r);
            }
        }
    }
}

