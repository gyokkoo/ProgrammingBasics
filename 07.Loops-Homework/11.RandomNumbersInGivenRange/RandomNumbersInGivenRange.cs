using System;
/*
Write a program that enters 3 integers n, min and max (min ≤ max) and prints n random numbers in the range [min...max].
Examples:
n	min	max	random numbers
5	0	1	1 0 0 1 1

 */
class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Title = "Problem 11.	Random Numbers in Given Range";
        Console.WriteLine("Enter three integers n, min and max (min<=max).");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("min = ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("max = ");
        int max = int.Parse(Console.ReadLine());
        Console.Write("Random numbers = ");
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            int randomNumber = rnd.Next(min, (max + 1));
            Console.Write(randomNumber + " ");
        }
        Console.WriteLine();
    }
}
