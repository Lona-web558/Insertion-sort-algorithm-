using System;

class Program
{
    static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
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

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        int[] numbers = { 12, 11, 13, 5, 6 };

        Console.WriteLine("Original array:");
        PrintArray(numbers);

        InsertionSort(numbers);

        Console.WriteLine("Sorted array:");
        PrintArray(numbers);
    }
}