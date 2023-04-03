namespace lab15
{
    public static class Program
    {
        static Random rnd = new Random();
        static int[] arr = new int[10];


        static void ShowArr()
        {
            for (int t = 0; t < 1000; t++)
            {
                for (int i = 0; i < arr.Length; i++)
                    Console.Write(arr[i] + " ");
                Console.WriteLine();
            }
        }


        static int CompareAsc(int x, int y)
        {
            Thread.Sleep(5);
            return x.CompareTo(y);
        }

        static void SortArrAscending()
        {
            Array.Sort(arr, CompareAsc);
        }


        static int CompareDesc(int x, int y)
        {
            Thread.Sleep(5);
            return y.CompareTo(x);
        }

        static void SortArrDescending()
        {
            Array.Sort(arr, CompareDesc);
        }


        public static void Main()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(100);
            }

            Thread sortingAscThread = new Thread(SortArrAscending);
            Thread sortingDescThread = new Thread(SortArrDescending);
            Thread showingThread = new Thread(ShowArr);

            showingThread.Start();
            sortingAscThread.Start();
            sortingDescThread.Start();
        }
    }
}