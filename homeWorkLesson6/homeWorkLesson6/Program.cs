using System;

class Program
{
    static void sort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            
            int min_idx = i;
            for (int j = i + 1; j < n; j++)
                if (arr[j] < arr[min_idx])
                    min_idx = j;

            
            int temp = arr[min_idx];
            arr[min_idx] = arr[i];
            arr[i] = temp;
        }
    }

    
    static void printArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");
        Console.WriteLine();

    }

    static void bubbleSort(int[] arr1)
    {
        int n = arr1.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (arr1[j] > arr1[j + 1])
                {
                    // swap temp and arr[i]
                    int temp = arr1[j];
                    arr1[j] = arr1[j + 1];
                    arr1[j + 1] = temp;
                }

    }
        static void printArray1(int[] arr1)
        {
            int n = arr1.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr1[i] + " ");
            Console.WriteLine();


            
        }


    void s(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; ++i)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }
    static void printArray3(int[] arr3)
    {
        int n = arr3.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr3[i] + " ");

        Console.Write("\n");
    }


    public static void Main()
        {
            int[] arr = { 64, 25, 12, 22, 11 };
            sort(arr);
            Console.WriteLine("Сортування 1 ");
            printArray(arr);

        int[] arr1 = { 64, 34, 25, 12, 22, 11, 90 };
        bubbleSort(arr1);
        Console.WriteLine("Сортування2 ");
        printArray(arr1);

        int[] arr3 = { 12, 11, 13, 5, 6 };
        Program ob = new Program();
        ob.s(arr3);
        Console.WriteLine("Сортування3 ");
        printArray(arr3);
    }

}