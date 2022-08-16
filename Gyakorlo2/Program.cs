class Test
{
    static void Main(string[] args)
    {

        Random rnd = new Random();
        int[] t = new int[30];

        for (int i = 0; i < t.Length; i++)
        {
            t[i] = rnd.Next(10);
        }

        printArray(t);

        DateTime timeStart = DateTime.Now;
        insertionSort(t);
        DateTime timeEnd = DateTime.Now;

        printArray(t);

        Console.WriteLine(timeEnd.Ticks - timeStart.Ticks);

    }

    static void printArray(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + " ");
        }
        Console.WriteLine();
    }

    static void insertionSort(int[] a)
    {
        int key, i;
        for(int j = 1; j < a.Length; j++)
        {
            key = a[j];
            i = j - 1;
            while(i>=0 && a[i] > key)
            {
                a[i + 1] = a[i];
                i--;
            }
            a[i + 1] = key;
        }
    }
}