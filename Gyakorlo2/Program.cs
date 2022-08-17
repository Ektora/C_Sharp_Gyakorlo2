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

        Console.WriteLine("Beszúrásos rendezés:");

        printArray(t);

        DateTime timeStart = DateTime.Now;
        insertionSort(t);
        DateTime timeEnd = DateTime.Now;

        printArray(t);

        Console.WriteLine(timeEnd.Ticks - timeStart.Ticks);

        Console.WriteLine("Buborék rendezés:");

        for (int i = 0; i < t.Length; i++)
        {
            t[i] = rnd.Next(10);
        }

        printArray(t);

        timeStart = DateTime.Now;
        bubbleSort(t);
        timeEnd = DateTime.Now;

        printArray(t);

        Console.WriteLine(timeEnd.Ticks - timeStart.Ticks);

        Console.WriteLine("Kiválasztásos rendezés:");

        for (int i = 0; i < t.Length; i++)
        {
            t[i] = rnd.Next(10);
        }

        printArray(t);

        timeStart = DateTime.Now;
        selectionSort(t);
        timeEnd = DateTime.Now;

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

    static void bubbleSort(int[] a)
    {
        int i, j, k;
        for(i = 1; i<= a.Length; i++)
        {
            for(j = 0; j< a.Length-1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    k = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = k;
                }
            }
        }
    }

    static void selectionSort(int[] a)
    {
        int min, seged;
        for(int i = 0; i < a.Length; i++)
        {
            min = i;
            for(int j = i+1; j< a.Length; j++)
            {
                if (a[j] < a[min])
                    min = j;
            }
            if(i != min)
            {
                seged = a[i];
                a[i] = a[min];
                a[min] = seged;
            }
        }
    }

}