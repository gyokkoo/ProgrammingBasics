using System;
/*
Write the bubble sort algorithm for sorting an array of integers. Create a method BubbleSort() and use it to sort arrays. 
 */
class BubbleSort
{
    static void Main()
    {
        Console.Title = "Problem 5.	* Bubble Sort";
        Console.WriteLine("Enter n and elements of array[n].");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Element[{0}] = ", i);
            int number = int.Parse(Console.ReadLine());
            arr[i] = number;
        }
        Console.Write("Your entered array is -> ");
        foreach(int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        Console.Write("Array in sorted order -> ");

        foreach (int num in Bubblesort(arr))
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
    static int[] Bubblesort(int[] array)
    {
        int temp = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
        return array;
    }
}
