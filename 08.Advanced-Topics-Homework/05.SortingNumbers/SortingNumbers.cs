using System;
// using System.Collections.Generic
/*
 Write a program that reads a number n and a sequence of n integers, sorts them and prints them. Examples:
 */
class SortingNumbers
{
    static void Main()
    {
        Console.Title = "Problem 5.	Sorting Numbers";
        Console.WriteLine("Enter a number n and a sequence of n integers.");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            numbers[i] = num;
        }
        Array.Sort(numbers);
        Console.WriteLine("In sorted order:");
        foreach(int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}