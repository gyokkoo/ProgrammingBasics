using System;
/*
Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop. Examples:
n	k	n! / k!
5	2	60
6	5	6
8	3	6720
 */
class CalculateNK
{
    static void Main()
    {
        Console.Title = "Problem 6.	Calculate N! / K!";
        Console.WriteLine("Enter two integers n and k (1<k<n<100).");
        Console.Write("n = ");
        double n = double.Parse(Console.ReadLine());
        Console.Write("k = ");
        double k = double.Parse(Console.ReadLine());
        double factorialN = 1;
        double factorialK = 1;
        double difference = n - k;
        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
            if ((i + difference) <= n)
            {
                factorialK *= i;
            }
        }
        double result = factorialN / factorialK;
        Console.WriteLine(result);
    }
}

