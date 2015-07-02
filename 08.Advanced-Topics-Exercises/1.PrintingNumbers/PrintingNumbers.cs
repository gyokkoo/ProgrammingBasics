using System;
/*
Write a method PrintEvenNumbers() that prints all even numbers in the given range (inclusive).
•	The method should receive minRange and maxRange as arguments
•	The method should not return a result
The numbers should be read from the console.
    Input	Output
    43      44 
    50	    46
            48
            50
*/
class PrintingNumbers
{
    static void Main()
    {
        Console.Title = "Problem 1.	Printing Numbers";
        Console.WriteLine("Enter minimum range and maximum range.");
        Console.Write("minRange = ");
        int minRange = int.Parse(Console.ReadLine());
        Console.Write("maxRange = ");
        int maxRange = int.Parse(Console.ReadLine());
        PrintEvenNumbers(minRange, maxRange);
    }
    static void PrintEvenNumbers(int minRange, int maxRange)
    {
        for (int i = minRange; i <= maxRange; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}