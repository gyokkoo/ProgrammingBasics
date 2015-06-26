using System;
/*
Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). 
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. 
The output is like in the examples below. Examples:
 */
class MinMaxSumAverage
{
    static void Main()
    {
        Console.Title = "Problem 3.	Min, Max, Sum and Average of N Numbers";
        Console.WriteLine("Enter a positive integer.");
        Console.Write("n = ");
        string line = Console.ReadLine();
        double min = double.MaxValue;
        double max = double.MinValue;
        double sum = 0;
        int integerN = int.Parse(line);
        if (integerN < 1)
        {
            Console.WriteLine("{0} is not an positive integer!", integerN);
            return;
        }
        Console.WriteLine("Enter {0} numbers, each on separated line.", integerN);
        for (int i = 0; i < integerN; i++)
        {
            double number = double.Parse(Console.ReadLine());
            if (number > max)
            {
                max = number;
            }
            if (number < min)
            {
                min = number;
            }
            sum += number;
        }
        double average = sum / integerN;
        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:F2}", average);
    }
}