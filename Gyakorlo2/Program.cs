class Test
{
    static void Main(string[] args)
    {
        /*
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


        Console.WriteLine("Gyors rendezés:");

        for (int i = 0; i < t.Length; i++)
        {
            t[i] = rnd.Next(10);
        }

        printArray(t);

        timeStart = DateTime.Now;
        quickSort(t, 0, t.Length-1);
        timeEnd = DateTime.Now;

        printArray(t);

        Console.WriteLine(timeEnd.Ticks - timeStart.Ticks);
        */

        // 8. feladat (Matematika: kombinációk)
        /*
        int[] tomb = new int[10];
        for (int i=0; i < tomb.Length; i++)
        {
            tomb[i] = Convert.ToInt32(Console.ReadLine());
        }
        quickSort(tomb,0,tomb.Length-1);
        for (int i = 0; i < tomb.Length - 1; i++)
        {
            if (i > 0 && tomb[i] == tomb[i - 1])
                continue;
            for (int j = i + 1; j < tomb.Length; j++)
            {
                if (tomb[j] == tomb[j - 1])
                    continue;
                Console.WriteLine(tomb[i] + " " + tomb[j]);
            }
        }
        */
        Random rnd = new Random();
        int[] t = new int[] {2,3,4, 4, 4, 4}; 

        Console.WriteLine("Van 4-es minta a tömbben: " + isConsecutiveFour(t));
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

    static void quickSort(int[] a, int left, int right)
    {
        int i = left, j = right, seged, kozep = a[left];

        while (i <= j)
        {
            while (a[i] < kozep) i++;
            while (a[j] > kozep) j--;
            if (i <= j)
            {
                seged = a[i];
                a[i] = a[j];
                a[j] = seged;
                i++;
                j--;
            }
        }

        if(left < j)
            quickSort(a, left, j);
        if(i < right)
            quickSort(a, i, right);
    }

    static bool isConsecutiveFour(int[] values)
    {
        if (values.Length < 4) return false;
        int counter = 1, value = values[0];
        for(int i = 1; i < values.Length; i++)
        {
            if(value == values[i])
            {
                counter++;
            }
            else
            {
               value = values[i];
                counter = 1;
            }

            if(counter == 4)
            {
                return true;
            }
        }
        return false;
    }
}