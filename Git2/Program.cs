using System;

class Program
{
    static void Main()
    {
        int[] arr = { 5, 2, 8, 3, 9, 9, 9 };
        Console.WriteLine("Исходный массив:");
        PrintArray(arr);
        BubbleSort(arr);
        Console.WriteLine("\nОтсортированный массив:");
        PrintArray(arr);
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}