using System;
/*
Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order. Examples:
n	randomized numbers 1…n
3	2 1 3
 */
class RandomizeTheNumbers
{
    static void Main()
    {
        Console.Title = "Problem 12.	* Randomize the Numbers 1…N";
        Console.WriteLine("Enter integer n.");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = i + 1;
        }
        Random rand = new Random();
        int rnd, temp;
        for (int i = 0; i < numbers.Length; i++)
        {
            rnd = rand.Next(numbers.Length);
            temp = numbers[i];
            numbers[i] = numbers[rnd];
            numbers[rnd] = temp;
        }
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}